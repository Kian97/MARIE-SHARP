using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;


namespace MARIESHARP2
{
    public static class Machine
    {
        public static string[] MemoryList; //Memory containing hex instructions
        private static string[] CompiledMemory;


        public static DataGridView memoryGrid = null;
        private static void WriteMemory(int address, string value)
        {
            MemoryList[address] = value;
            int row = address / 16; int column = address - (row * 16); memoryGrid[column, row].Value = MemoryList[address];     
        }

        public static State myState = State.Halted; public enum State { Running, Halted, InputPending }; 

        private enum OPCODES { JNS, LOAD, STORE, ADD, SUBT, INPUT, OUTPUT, HALT, SKIPCOND, JUMP, CLEAR, ADDI, JUMPI, LOADI, STOREI }; //Opcodes       
        private static int[] noOperands = new int[] { 10, 9, 8, 5, 7, 6};


        private static List<int> blanklines = new List<int>();
        public static int getLineNum()
        {
            int offset = 0;
            foreach (int line in blanklines) { if (PC > line) { offset++; };}
            return PC + offset;
        }

        //Registers
        public static int AC, IR, MAR, MBR, PC;
        //IO
        public static string OUTPUT = String.Empty;

        public delegate void MachineEvent();
        public static event MachineEvent onExecute;
        public static event MachineEvent onHalt;
        public static event MachineEvent onRequestInput;
        public static event MachineEvent onInputParsed;
        public static event MachineEvent onReset;
      

        public static string DecToHex(int dec, int digits)
        {
            return dec.ToString("X").PadLeft(digits, '0');
        }
        public static int HexToDec(string hex)
        {
            return Int32.Parse(hex, System.Globalization.NumberStyles.HexNumber);
        }


        public static void Clear()
        {
            AC = IR = MAR = MBR = PC = 0; OUTPUT = String.Empty; //reset registers
            blanklines.Clear();
            MemoryList = CompiledMemory = null;
            onReset();
        }

        public static void Reset() //Reset machine state
        {
            if(CompiledMemory != null)
            {
                AC = IR = MAR = MBR = PC = 0; OUTPUT = String.Empty; //reset registers
                MemoryList = (string[])CompiledMemory.Clone(); //reset memory to initial state
                onReset();
            }
        }

        public static void Interpret(string input) //Interpret code
        {
            MemoryList = Enumerable.Repeat(DecToHex(0, 4), 4096).ToArray();

            List<string> inputLines = new List<string>();

            //Parse input, split and strip
            using (StringReader sr = new StringReader(input))
            {
                while (sr.Peek() != -1)
                {      
                    //remove trailing whitespace chars
                    string line = sr.ReadLine().Split('/')[0].Trim(new char[] { ' ', '\t' });
                    if (line == String.Empty) 
                    {
                        blanklines.Add(inputLines.Count);
                        continue; 
                    } //blank line, ignore
                    inputLines.Add(line.ToUpper());
                }
            }

            Dictionary<string, string> dictLabels = new Dictionary<string, string>();

            //Resolve labels into memory address
            for (int mloc = 0; mloc < inputLines.Count; mloc++ ) 
            {
                string[] args = inputLines[mloc].Split(',');
                if (args.Length == 2) //instruction has label
                {
                    dictLabels.Add(args[0].Trim(), DecToHex(mloc, 3)); //add label/address entry
                    inputLines[mloc] = args[1].Trim(); //remove preceeding label from line
                }
            }

            //Parse lines, and resolve into instructions
            for (int l = 0; l < inputLines.Count; l++ )
            {
                string instruction = "";
                string[] args = inputLines[l].Split(' '); //split opcode and operand delineated by ' ' 

                //data defined
                if (args[0] == "DEC") { instruction = '0' + DecToHex(Int32.Parse(args[1]), 3); } 
                else if (args[0] == "HEX") { instruction = '0' + args[1].PadLeft(3, '0'); }
                //Instruction defined
                else 
                {
                    instruction += DecToHex(Array.IndexOf(Enum.GetNames(typeof(OPCODES)), args[0]), 1); //concat hex-digit opcode
                    if (args.Length == 2)
                    {
                        //concat 12-bit operand
                        if (dictLabels.ContainsKey(args[1])) { instruction += dictLabels[args[1]]; } //label
                        else { instruction += args[1].PadLeft(3, '0'); } //raw address
                    }
                    else { instruction += "000"; } //no operand defined, default to 0x000
                }

                MemoryList[l] = instruction; //add instruction to memory
            }
            myState = State.Running;
            CompiledMemory = MemoryList;
        }

        public static void Execute(string input) //Excute instruction
        {
            string str = MemoryList[PC]; //get memory value from PC address

            int opcode = HexToDec(str[0].ToString());
            int operand = HexToDec(str.Substring(1, 3));
            IR = HexToDec(str);

            if (opcode == (int)OPCODES.INPUT) //special handling of input opcode
            {
                if (myState == State.InputPending) 
                {
                    if (input == string.Empty) {return; }  
                    else { onInputParsed(); Machine.myState = State.Running; } 
                } 
                else 
                { onRequestInput(); Machine.myState = State.InputPending; return; } 
            }

            if (Array.IndexOf(noOperands, opcode) == -1) //FETCH
            {
                MAR = operand;
                MBR = HexToDec(MemoryList[operand]);
            }
            else { MAR = PC; } //NO FETCH REQUIRED


            PC++;
            //DECODE + EXCUTE
            switch(opcode)
            {
                case((int)OPCODES.LOAD):
                    {
                        AC = MBR;
                        break;
                    }
                case ((int)OPCODES.SUBT):
                    {
                        AC -= MBR;
                        break;
                    }
                case((int)OPCODES.ADD):
                    {
                        AC += MBR;
                        break;
                    }
                case ((int)OPCODES.SKIPCOND): 
                    {
                        if ((operand == 2048 && AC > 0) || (operand == 1024 && AC == 0) || (operand == 0 && AC < 0)) { PC++; }
                        break;
                    }
                case ((int)OPCODES.JUMP):
                    {
                        PC = operand;
                        break;
                    }
                case ((int)OPCODES.OUTPUT):
                    {
                        OUTPUT = AC.ToString();
                        break;
                    }
                case ((int)OPCODES.HALT):
                    {
                        myState = State.Halted; 
                        onHalt();
                        break;
                    }
                case((int)OPCODES.CLEAR):
                    {
                        AC = 0;
                        break;
                    }
                case((int)OPCODES.STORE):
                    {
                        WriteMemory(operand, DecToHex(AC, 4));
                        break;
                    }
                case((int)OPCODES.INPUT):
                    {
                        AC = HexToDec(input);
                        break;
                    }
                case((int)OPCODES.STOREI): 
                    {
                        int IAddress = HexToDec(MemoryList[MAR]);
                        WriteMemory(IAddress, DecToHex(AC, 4));
                        break;
                    }
                case ((int)OPCODES.LOADI):
                    {
                        int IAddress = HexToDec(MemoryList[MAR]);
                        AC = HexToDec(MemoryList[IAddress]);
                        break;
                    }
                case ((int)OPCODES.JUMPI):
                    {
                        int IAddress = HexToDec(MemoryList[MAR]);
                        PC = IAddress;
                        break;
                    }
                case ((int)OPCODES.JNS):
                    {
                        WriteMemory(MAR, DecToHex(PC, 4));
                        PC = MAR + 1;
                        break;
                    }
                case ((int)OPCODES.ADDI): 
                    {
                        int IAddress = HexToDec(MemoryList[MAR]);
                        AC += HexToDec(MemoryList[IAddress]);
                        break;
                    }
            }
            onExecute();
        } 

        
    }
}
