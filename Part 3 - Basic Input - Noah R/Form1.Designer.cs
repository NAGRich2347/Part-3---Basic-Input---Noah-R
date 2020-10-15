namespace Part_3___Basic_Input___Noah_R
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
            this.titlelbl = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbl4 = new System.Windows.Forms.Label();
            this.outputTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titlelbl.Location = new System.Drawing.Point(13, 13);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(248, 13);
            this.titlelbl.TabIndex = 0;
            this.titlelbl.Text = "This form will generate a sentence using your input.";
            this.titlelbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn1
            // 
            this.btn1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn1.Location = new System.Drawing.Point(216, 88);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(101, 36);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Submit";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            this.btn1.Enter += new System.EventHandler(this.button1_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 51);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(140, 13);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Please enter your first name;";
            this.lbl1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(13, 100);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(141, 13);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "Please enter your height (m):";
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(12, 153);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(113, 13);
            this.lbl3.TabIndex = 6;
            this.lbl3.Text = "Please enter your age:";
            this.lbl3.Click += new System.EventHandler(this.lbl3_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(16, 68);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 7;
            this.txt1.Enter += new System.EventHandler(this.button1_Click);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(16, 116);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 20);
            this.txt3.TabIndex = 9;
            this.txt3.TextChanged += new System.EventHandler(this.txt3_TextChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(15, 169);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(13, 207);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(79, 13);
            this.lbl4.TabIndex = 11;
            this.lbl4.Text = "Your sentence:";
            // 
            // outputTxt
            // 
            this.outputTxt.Location = new System.Drawing.Point(13, 224);
            this.outputTxt.Multiline = true;
            this.outputTxt.Name = "outputTxt";
            this.outputTxt.ReadOnly = true;
            this.outputTxt.Size = new System.Drawing.Size(248, 93);
            this.outputTxt.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(332, 329);
            this.Controls.Add(this.outputTxt);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.titlelbl);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Form1";
            this.Text = "Sentence Generator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox outputTxt;
    }
}

