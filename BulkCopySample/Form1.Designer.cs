namespace BulkCopySample
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
            this.CopyCustomersButton = new System.Windows.Forms.Button();
            this.CopyOrderButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_3 = new System.Windows.Forms.DateTimePicker();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.DELETE = new System.Windows.Forms.GroupBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.DELETE.SuspendLayout();
            this.SuspendLayout();
            // 
            // CopyCustomersButton
            // 
            this.CopyCustomersButton.Location = new System.Drawing.Point(56, 93);
            this.CopyCustomersButton.Name = "CopyCustomersButton";
            this.CopyCustomersButton.Size = new System.Drawing.Size(146, 37);
            this.CopyCustomersButton.TabIndex = 0;
            this.CopyCustomersButton.Text = "Copy Customers";
            this.CopyCustomersButton.UseVisualStyleBackColor = true;
            this.CopyCustomersButton.Click += new System.EventHandler(this.CopyCustomersButton_Click);
            // 
            // CopyOrderButton
            // 
            this.CopyOrderButton.Location = new System.Drawing.Point(56, 169);
            this.CopyOrderButton.Name = "CopyOrderButton";
            this.CopyOrderButton.Size = new System.Drawing.Size(146, 37);
            this.CopyOrderButton.TabIndex = 1;
            this.CopyOrderButton.Text = "Copy Order";
            this.CopyOrderButton.UseVisualStyleBackColor = true;
            this.CopyOrderButton.Click += new System.EventHandler(this.CopyOrderButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "otvori SQL so adapter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(46, 36);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(73, 22);
            this.txtIznos.TabIndex = 10;
            this.txtIznos.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(368, 182);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.txtIznos);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(249, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 312);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECT";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(46, 275);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 28);
            this.button5.TabIndex = 13;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.dtp2);
            this.groupBox2.Controls.Add(this.dtp1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(734, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 312);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INSERT";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(27, 263);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(244, 22);
            this.textBox5.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(27, 235);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(73, 22);
            this.textBox4.TabIndex = 18;
            this.textBox4.Text = "0";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(27, 207);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(73, 22);
            this.textBox3.TabIndex = 17;
            this.textBox3.Text = "0";
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(27, 98);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(200, 22);
            this.dtp2.TabIndex = 16;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(27, 50);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 22);
            this.dtp1.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 32);
            this.button2.TabIndex = 13;
            this.button2.Text = "INSERT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(27, 176);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(73, 22);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(73, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dtp_3);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Location = new System.Drawing.Point(249, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(470, 263);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "UPDATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Kilometri";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtp_3
            // 
            this.dtp_3.Location = new System.Drawing.Point(32, 122);
            this.dtp_3.Name = "dtp_3";
            this.dtp_3.Size = new System.Drawing.Size(200, 22);
            this.dtp_3.TabIndex = 22;
            this.dtp_3.ValueChanged += new System.EventHandler(this.dtp_3_ValueChanged);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(32, 160);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(73, 22);
            this.textBox8.TabIndex = 21;
            this.textBox8.Text = "0";
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(32, 216);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(244, 22);
            this.textBox7.TabIndex = 20;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(154, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 32);
            this.button3.TabIndex = 14;
            this.button3.Text = "UPDATE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(32, 57);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(73, 22);
            this.textBox6.TabIndex = 12;
            this.textBox6.Text = "0";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // DELETE
            // 
            this.DELETE.Controls.Add(this.textBox9);
            this.DELETE.Controls.Add(this.label3);
            this.DELETE.Controls.Add(this.button4);
            this.DELETE.Location = new System.Drawing.Point(726, 362);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(425, 262);
            this.DELETE.TabIndex = 16;
            this.DELETE.TabStop = false;
            this.DELETE.Text = "DELETE";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(100, 80);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(66, 22);
            this.textBox9.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(245, 76);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 31);
            this.button4.TabIndex = 0;
            this.button4.Text = "DELETE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 654);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CopyOrderButton);
            this.Controls.Add(this.CopyCustomersButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.DELETE.ResumeLayout(false);
            this.DELETE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CopyCustomersButton;
        private System.Windows.Forms.Button CopyOrderButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.DateTimePicker dtp_3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox DELETE;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

