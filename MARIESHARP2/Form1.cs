using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MARIESHARP2
{
    public partial class Form1 : Form
    {
        public static Timer Clock = new Timer() { Interval = 1 };

        public Form1()
        {
            InitializeComponent();


            //handle events
            Clock.Tick += Tick;
            Machine.memoryGrid = grid_mem;
            Machine.onExecute += HandleExecute;
            Machine.onHalt += HandleHalt;
            Machine.onRequestInput += HandleRequestInput;
            Machine.onInputParsed += HandleInputParsed;
            Machine.onReset += HandleReset;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_input.SelectedIndex = 1; //set default input mode

            tbox_code.ReadOnly = true;

            //set data grid style properties
            grid_mem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_mem.RowHeadersWidth = 70;
            grid_mem.AllowUserToResizeRows = false; grid_mem.AllowUserToResizeColumns = false;
            grid_mem.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_mem.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_mem.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_mem.DefaultCellStyle.NullValue = "0000";
            grid_mem.ColumnCount = 16; grid_mem.RowCount = 256;


            for (int c = 0; c < grid_mem.ColumnCount; c++) //initialize column headers
            {
                grid_mem.Columns[c].HeaderText = "+" + c.ToString("X");
                grid_mem.Columns[c].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int r = 0; r < grid_mem.RowCount; r++) //initialize row headers
            { grid_mem.Rows[r].HeaderCell.Value = (r * 16).ToString("X").PadLeft(3, '0'); }
        }


        private void nud_delay_ValueChanged(object sender, EventArgs e)
        {
            Clock.Interval = (int)nud_delay.Value;
        }


        //Machine events
        public void HandleHalt()
        {
            Clock.Stop();
        }
        public void HandleRequestInput()
        {
            lbl_inp.BackColor = Color.PaleVioletRed;
        }
        public void HandleExecute()
        {
            UpdateDisplay();

            if (Machine.OUTPUT != String.Empty)
            {
                switch (cmb_input.SelectedIndex)
                {
                    case (0): tbox_output.Text += Machine.OUTPUT + "\r\n"; //HEX
                        break;
                    case (1): tbox_output.Text += Convert.ToInt32(Machine.OUTPUT, 10).ToString() + "\r\n"; //DEC
                        break;
                    case (2): tbox_output.Text += (string)Machine.OUTPUT + "\r\n"; //ASCII
                       break;
                }
                Machine.OUTPUT = String.Empty;
            }
        }
        public void HandleInputParsed()
        {
            lbl_inp.BackColor = Color.White;
        }
        public void HandleReset()
        {
            tbox_code.Text = tbox_code.Text.ToString();
            UpdateDisplay();
            tbox_output.Clear();
            HandleInputParsed();
        }



        private void UpdateSelection()
        {
            tbox_code.Text = tbox_code.Text.ToString();
            int currentline = Machine.getLineNum();

            tbox_code.Select(tbox_code.GetFirstCharIndexFromLine(currentline) + 1, tbox_code.Lines[currentline].Length - 1);
            tbox_code.SelectionBackColor = Color.LightGreen;
            tbox_code.DeselectAll();
        }
        private void UpdateDisplay()
        {
            lbl_ac.Text = Machine.AC.ToString("X").PadLeft(4, '0');
            lbl_ir.Text = Machine.IR.ToString("X").PadLeft(4, '0');
            lbl_mar.Text = Machine.MAR.ToString("X").PadLeft(3, '0');
            lbl_mbr.Text = Machine.MBR.ToString("X").PadLeft(4, '0');
            lbl_pc.Text = Machine.PC.ToString("X").PadLeft(3, '0');
        }


        public void Tick(object sender, EventArgs e)
        {
            if (Machine.myState == Machine.State.Halted || Machine.myState == Machine.State.InputPending) { return; }
            UpdateSelection();

            Machine.Execute(string.Empty);
        }


        //Buttons
        private void btn_run_Click(object sender, EventArgs e)
        {
            if(Machine.myState != Machine.State.Halted)
            {
                Clock.Start();
            }
        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            if (Machine.myState == Machine.State.InputPending)
            {
                Machine.Execute(Int32.Parse(lbl_inp.Text).ToString("X"));
                UpdateSelection();
                if (Machine.myState == Machine.State.Halted) { Clock.Stop(); }
            }
        }

        private void btn_assemble_Click(object sender, EventArgs e)
        {
            Machine.Interpret(tbox_code.Text); //load memory with interpreted instructions
            for (int i = 0; i < 4096; i++) //display memory in memory grid
            {
                int row = i / 16; int column = i - (row * 16);
                grid_mem[column, row].Value = Machine.MemoryList[i];
            }
            btn_assemble.Enabled = false;
            btn_run.Enabled = btn_step.Enabled = btn_restart.Enabled = true;
        }

        private void btn_step_Click(object sender, EventArgs e)
        {
            Clock.Stop();
            Tick(this, EventArgs.Empty);
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            Machine.Reset(); //reset machine
            grid_mem.Update();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            Machine.Clear();
            btn_restart_Click(this, EventArgs.Empty);

            OpenFileDialog openDialog = new OpenFileDialog() { Filter = "MARIE Assembly File|*.mas" };
            DialogResult dialogResult = openDialog.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                Stream fs = openDialog.OpenFile();
                StreamReader sr = new StreamReader(openDialog.OpenFile());
                tbox_code.Text = sr.ReadToEnd();
                sr.Close(); fs.Close();
            }

            btn_run.Enabled = btn_step.Enabled = btn_restart.Enabled = false;
            btn_assemble.Enabled = true;    
        }







    }
}
