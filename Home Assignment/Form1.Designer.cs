namespace Home_assignment
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
            this.lbldayoftheweek = new System.Windows.Forms.Label();
            this.lblnameofthemonth = new System.Windows.Forms.Label();
            this.lblnomericofthemonth = new System.Windows.Forms.Label();
            this.lbltheyear = new System.Windows.Forms.Label();
            this.txtdayoftheweek = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtdayofthemonth = new System.Windows.Forms.TextBox();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnshowdata = new System.Windows.Forms.Button();
            this.lbloutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbldayoftheweek
            // 
            this.lbldayoftheweek.AutoSize = true;
            this.lbldayoftheweek.Location = new System.Drawing.Point(140, 54);
            this.lbldayoftheweek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldayoftheweek.Name = "lbldayoftheweek";
            this.lbldayoftheweek.Size = new System.Drawing.Size(191, 20);
            this.lbldayoftheweek.TabIndex = 0;
            this.lbldayoftheweek.Text = "Enter day of the week";
            this.lbldayoftheweek.Click += new System.EventHandler(this.lbldayoftheweek_Click);
            // 
            // lblnameofthemonth
            // 
            this.lblnameofthemonth.AutoSize = true;
            this.lblnameofthemonth.BackColor = System.Drawing.Color.Transparent;
            this.lblnameofthemonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblnameofthemonth.Location = new System.Drawing.Point(140, 98);
            this.lblnameofthemonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnameofthemonth.Name = "lblnameofthemonth";
            this.lblnameofthemonth.Size = new System.Drawing.Size(216, 20);
            this.lblnameofthemonth.TabIndex = 1;
            this.lblnameofthemonth.Text = "Enter name of the month";
            // 
            // lblnomericofthemonth
            // 
            this.lblnomericofthemonth.AutoSize = true;
            this.lblnomericofthemonth.Location = new System.Drawing.Point(140, 157);
            this.lblnomericofthemonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnomericofthemonth.Name = "lblnomericofthemonth";
            this.lblnomericofthemonth.Size = new System.Drawing.Size(270, 20);
            this.lblnomericofthemonth.TabIndex = 2;
            this.lblnomericofthemonth.Text = "Enter the nomeric of the month";
            this.lblnomericofthemonth.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbltheyear
            // 
            this.lbltheyear.AutoSize = true;
            this.lbltheyear.Location = new System.Drawing.Point(140, 208);
            this.lbltheyear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltheyear.Name = "lbltheyear";
            this.lbltheyear.Size = new System.Drawing.Size(128, 20);
            this.lbltheyear.TabIndex = 3;
            this.lbltheyear.Text = "Enter the year";
            // 
            // txtdayoftheweek
            // 
            this.txtdayoftheweek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdayoftheweek.Location = new System.Drawing.Point(432, 47);
            this.txtdayoftheweek.Margin = new System.Windows.Forms.Padding(4);
            this.txtdayoftheweek.Name = "txtdayoftheweek";
            this.txtdayoftheweek.Size = new System.Drawing.Size(363, 27);
            this.txtdayoftheweek.TabIndex = 4;
            // 
            // txtyear
            // 
            this.txtyear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtyear.Location = new System.Drawing.Point(432, 206);
            this.txtyear.Margin = new System.Windows.Forms.Padding(4);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(363, 27);
            this.txtyear.TabIndex = 5;
            this.txtyear.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtdayofthemonth
            // 
            this.txtdayofthemonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdayofthemonth.Location = new System.Drawing.Point(432, 157);
            this.txtdayofthemonth.Margin = new System.Windows.Forms.Padding(4);
            this.txtdayofthemonth.Name = "txtdayofthemonth";
            this.txtdayofthemonth.Size = new System.Drawing.Size(363, 27);
            this.txtdayofthemonth.TabIndex = 6;
            // 
            // txtmonth
            // 
            this.txtmonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmonth.Location = new System.Drawing.Point(432, 108);
            this.txtmonth.Margin = new System.Windows.Forms.Padding(4);
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(363, 27);
            this.txtmonth.TabIndex = 7;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(348, 394);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(103, 52);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(525, 394);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(103, 52);
            this.btnexit.TabIndex = 10;
            this.btnexit.Text = "close";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnshowdata
            // 
            this.btnshowdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowdata.Location = new System.Drawing.Point(165, 394);
            this.btnshowdata.Margin = new System.Windows.Forms.Padding(4);
            this.btnshowdata.Name = "btnshowdata";
            this.btnshowdata.Size = new System.Drawing.Size(103, 52);
            this.btnshowdata.TabIndex = 11;
            this.btnshowdata.Text = "show data";
            this.btnshowdata.UseVisualStyleBackColor = true;
            this.btnshowdata.Click += new System.EventHandler(this.btnshowdata_Click);
            // 
            // lbloutput
            // 
            this.lbloutput.BackColor = System.Drawing.SystemColors.Control;
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutput.Location = new System.Drawing.Point(165, 274);
            this.lbloutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(633, 85);
            this.lbloutput.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 562);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.btnshowdata);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtmonth);
            this.Controls.Add(this.txtdayofthemonth);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtdayoftheweek);
            this.Controls.Add(this.lbltheyear);
            this.Controls.Add(this.lblnomericofthemonth);
            this.Controls.Add(this.lblnameofthemonth);
            this.Controls.Add(this.lbldayoftheweek);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldayoftheweek;
        private System.Windows.Forms.Label lblnameofthemonth;
        private System.Windows.Forms.Label lblnomericofthemonth;
        private System.Windows.Forms.Label lbltheyear;
        private System.Windows.Forms.TextBox txtdayoftheweek;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txtdayofthemonth;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnshowdata;
        private System.Windows.Forms.Label lbloutput;
    }
}

