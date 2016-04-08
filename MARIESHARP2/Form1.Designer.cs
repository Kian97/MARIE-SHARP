namespace MARIESHARP2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_code = new System.Windows.Forms.Panel();
            this.tbox_code = new System.Windows.Forms.RichTextBox();
            this.btn_assemble = new System.Windows.Forms.Button();
            this.grid_mem = new System.Windows.Forms.DataGridView();
            this.btn_step = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.btn_restart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_input = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_inp = new System.Windows.Forms.TextBox();
            this.cmb_input = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_pc = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_mbr = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_mar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_ir = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_ac = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_output = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nud_delay = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_open = new System.Windows.Forms.Button();
            this.pnl_code.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_mem)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_delay)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_code
            // 
            this.pnl_code.AutoScroll = true;
            this.pnl_code.BackColor = System.Drawing.Color.White;
            this.pnl_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_code.Controls.Add(this.tbox_code);
            this.pnl_code.Location = new System.Drawing.Point(33, 49);
            this.pnl_code.Name = "pnl_code";
            this.pnl_code.Size = new System.Drawing.Size(424, 480);
            this.pnl_code.TabIndex = 1;
            // 
            // tbox_code
            // 
            this.tbox_code.AcceptsTab = true;
            this.tbox_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_code.Location = new System.Drawing.Point(18, 13);
            this.tbox_code.Name = "tbox_code";
            this.tbox_code.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbox_code.Size = new System.Drawing.Size(386, 447);
            this.tbox_code.TabIndex = 1;
            this.tbox_code.Text = "";
            // 
            // btn_assemble
            // 
            this.btn_assemble.BackColor = System.Drawing.SystemColors.Control;
            this.btn_assemble.Enabled = false;
            this.btn_assemble.Location = new System.Drawing.Point(33, 23);
            this.btn_assemble.Name = "btn_assemble";
            this.btn_assemble.Size = new System.Drawing.Size(80, 20);
            this.btn_assemble.TabIndex = 2;
            this.btn_assemble.Text = "Assemble";
            this.btn_assemble.UseVisualStyleBackColor = false;
            this.btn_assemble.Click += new System.EventHandler(this.btn_assemble_Click);
            // 
            // grid_mem
            // 
            this.grid_mem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_mem.Location = new System.Drawing.Point(33, 535);
            this.grid_mem.Name = "grid_mem";
            this.grid_mem.ReadOnly = true;
            this.grid_mem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_mem.Size = new System.Drawing.Size(1028, 203);
            this.grid_mem.TabIndex = 3;
            // 
            // btn_step
            // 
            this.btn_step.BackColor = System.Drawing.SystemColors.Control;
            this.btn_step.Enabled = false;
            this.btn_step.Location = new System.Drawing.Point(286, 23);
            this.btn_step.Name = "btn_step";
            this.btn_step.Size = new System.Drawing.Size(56, 20);
            this.btn_step.TabIndex = 4;
            this.btn_step.Text = "Step";
            this.btn_step.UseVisualStyleBackColor = false;
            this.btn_step.Click += new System.EventHandler(this.btn_step_Click);
            // 
            // btn_run
            // 
            this.btn_run.BackColor = System.Drawing.SystemColors.Control;
            this.btn_run.Enabled = false;
            this.btn_run.Location = new System.Drawing.Point(224, 23);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(56, 20);
            this.btn_run.TabIndex = 5;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = false;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // btn_restart
            // 
            this.btn_restart.BackColor = System.Drawing.SystemColors.Control;
            this.btn_restart.Enabled = false;
            this.btn_restart.Location = new System.Drawing.Point(348, 23);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(58, 20);
            this.btn_restart.TabIndex = 6;
            this.btn_restart.Text = "Restart";
            this.btn_restart.UseVisualStyleBackColor = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_input);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(507, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 376);
            this.panel1.TabIndex = 7;
            // 
            // btn_input
            // 
            this.btn_input.BackColor = System.Drawing.SystemColors.Control;
            this.btn_input.Location = new System.Drawing.Point(137, 271);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(56, 20);
            this.btn_input.TabIndex = 13;
            this.btn_input.Text = "Input";
            this.btn_input.UseVisualStyleBackColor = false;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.lbl_inp);
            this.panel7.Controls.Add(this.cmb_input);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Location = new System.Drawing.Point(14, 228);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(179, 37);
            this.panel7.TabIndex = 15;
            // 
            // lbl_inp
            // 
            this.lbl_inp.Location = new System.Drawing.Point(50, 8);
            this.lbl_inp.Name = "lbl_inp";
            this.lbl_inp.Size = new System.Drawing.Size(62, 20);
            this.lbl_inp.TabIndex = 16;
            // 
            // cmb_input
            // 
            this.cmb_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_input.FormattingEnabled = true;
            this.cmb_input.Items.AddRange(new object[] {
            "HEX",
            "DEC",
            "ASCII"});
            this.cmb_input.Location = new System.Drawing.Point(118, 7);
            this.cmb_input.Name = "cmb_input";
            this.cmb_input.Size = new System.Drawing.Size(53, 21);
            this.cmb_input.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "INPUT";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.lbl_pc);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Location = new System.Drawing.Point(14, 185);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(179, 37);
            this.panel6.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "(Hex)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_pc
            // 
            this.lbl_pc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_pc.Location = new System.Drawing.Point(50, 7);
            this.lbl_pc.Name = "lbl_pc";
            this.lbl_pc.Size = new System.Drawing.Size(62, 20);
            this.lbl_pc.TabIndex = 9;
            this.lbl_pc.Text = "000";
            this.lbl_pc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "PC";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.lbl_mbr);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(14, 142);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(179, 37);
            this.panel5.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "(Hex)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mbr
            // 
            this.lbl_mbr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_mbr.Location = new System.Drawing.Point(50, 7);
            this.lbl_mbr.Name = "lbl_mbr";
            this.lbl_mbr.Size = new System.Drawing.Size(62, 20);
            this.lbl_mbr.TabIndex = 9;
            this.lbl_mbr.Text = "0000";
            this.lbl_mbr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "MBR";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.lbl_mar);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(14, 99);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(179, 37);
            this.panel4.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "(Hex)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mar
            // 
            this.lbl_mar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_mar.Location = new System.Drawing.Point(50, 7);
            this.lbl_mar.Name = "lbl_mar";
            this.lbl_mar.Size = new System.Drawing.Size(62, 20);
            this.lbl_mar.TabIndex = 9;
            this.lbl_mar.Text = "0000";
            this.lbl_mar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "MAR";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbl_ir);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(14, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 37);
            this.panel3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "(Hex)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ir
            // 
            this.lbl_ir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ir.Location = new System.Drawing.Point(50, 7);
            this.lbl_ir.Name = "lbl_ir";
            this.lbl_ir.Size = new System.Drawing.Size(62, 20);
            this.lbl_ir.TabIndex = 9;
            this.lbl_ir.Text = "0000";
            this.lbl_ir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "IR";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbl_ac);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(14, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 37);
            this.panel2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "(Hex)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ac
            // 
            this.lbl_ac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ac.Location = new System.Drawing.Point(50, 7);
            this.lbl_ac.Name = "lbl_ac";
            this.lbl_ac.Size = new System.Drawing.Size(62, 20);
            this.lbl_ac.TabIndex = 9;
            this.lbl_ac.Text = "0000";
            this.lbl_ac.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "AC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbox_output
            // 
            this.tbox_output.BackColor = System.Drawing.Color.White;
            this.tbox_output.Location = new System.Drawing.Point(749, 49);
            this.tbox_output.Multiline = true;
            this.tbox_output.Name = "tbox_output";
            this.tbox_output.ReadOnly = true;
            this.tbox_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbox_output.Size = new System.Drawing.Size(239, 376);
            this.tbox_output.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(746, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Output:";
            // 
            // nud_delay
            // 
            this.nud_delay.Location = new System.Drawing.Point(477, 25);
            this.nud_delay.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nud_delay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_delay.Name = "nud_delay";
            this.nud_delay.Size = new System.Drawing.Size(61, 20);
            this.nud_delay.TabIndex = 11;
            this.nud_delay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_delay.ValueChanged += new System.EventHandler(this.nud_delay_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(412, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Delay (ms):";
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.SystemColors.Control;
            this.btn_open.Location = new System.Drawing.Point(119, 23);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(80, 20);
            this.btn_open.TabIndex = 13;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 773);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.nud_delay);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbox_output);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.btn_step);
            this.Controls.Add(this.grid_mem);
            this.Controls.Add(this.btn_assemble);
            this.Controls.Add(this.pnl_code);
            this.Name = "Form1";
            this.Text = "MARIE SHARP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_code.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_mem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_delay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_code;
        private System.Windows.Forms.RichTextBox tbox_code;
        private System.Windows.Forms.Button btn_assemble;
        private System.Windows.Forms.DataGridView grid_mem;
        private System.Windows.Forms.Button btn_step;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cmb_input;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_pc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_mbr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_mar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_ir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_ac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lbl_inp;
        private System.Windows.Forms.TextBox tbox_output;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nud_delay;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_input;
        private System.Windows.Forms.Button btn_open;
    }
}

