namespace DBG20FinalProject
{
    partial class Add_Staff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.desg = new System.Windows.Forms.TextBox();
            this.EXIT_BUTTON = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ConfirmPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.newPass = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cont = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Table_SAdd = new System.Windows.Forms.DataGridView();
            this.guna2Shapes2 = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2Shapes3 = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2Shapes4 = new Guna.UI2.WinForms.Guna2Shapes();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table_SAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // fName
            // 
            this.fName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName.Location = new System.Drawing.Point(19, 51);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(171, 26);
            this.fName.TabIndex = 46;
            this.fName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.desg);
            this.panel1.Controls.Add(this.EXIT_BUTTON);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.ConfirmPass);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.newPass);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.address);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cont);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.fName);
            this.panel1.Location = new System.Drawing.Point(1, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 330);
            this.panel1.TabIndex = 47;
            // 
            // desg
            // 
            this.desg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desg.Location = new System.Drawing.Point(247, 51);
            this.desg.Name = "desg";
            this.desg.Size = new System.Drawing.Size(171, 26);
            this.desg.TabIndex = 64;
            this.desg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EXIT_BUTTON
            // 
            this.EXIT_BUTTON.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EXIT_BUTTON.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EXIT_BUTTON.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EXIT_BUTTON.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EXIT_BUTTON.FillColor = System.Drawing.Color.Black;
            this.EXIT_BUTTON.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT_BUTTON.ForeColor = System.Drawing.Color.DarkOrchid;
            this.EXIT_BUTTON.Location = new System.Drawing.Point(243, 291);
            this.EXIT_BUTTON.Margin = new System.Windows.Forms.Padding(2);
            this.EXIT_BUTTON.Name = "EXIT_BUTTON";
            this.EXIT_BUTTON.Size = new System.Drawing.Size(173, 37);
            this.EXIT_BUTTON.TabIndex = 63;
            this.EXIT_BUTTON.Text = "View Staff";
            this.EXIT_BUTTON.Click += new System.EventHandler(this.EXIT_BUTTON_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.DarkBlue;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.DarkOrchid;
            this.guna2Button1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(19, 291);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(170, 37);
            this.guna2Button1.TabIndex = 62;
            this.guna2Button1.Text = "Register";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Agency FB", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(243, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 61;
            this.label8.Text = "Confirm Password";
            // 
            // ConfirmPass
            // 
            this.ConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPass.Location = new System.Drawing.Point(243, 253);
            this.ConfirmPass.Name = "ConfirmPass";
            this.ConfirmPass.Size = new System.Drawing.Size(171, 26);
            this.ConfirmPass.TabIndex = 60;
            this.ConfirmPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ConfirmPass.TextChanged += new System.EventHandler(this.ConfirmPass_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Agency FB", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(19, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 59;
            this.label7.Text = "New Password";
            // 
            // newPass
            // 
            this.newPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPass.Location = new System.Drawing.Point(19, 253);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(171, 26);
            this.newPass.TabIndex = 58;
            this.newPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(247, 160);
            this.date.Margin = new System.Windows.Forms.Padding(2);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(171, 20);
            this.date.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Agency FB", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(247, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Agency FB", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(243, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Designation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Agency FB", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(243, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Address";
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(247, 105);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(171, 26);
            this.address.TabIndex = 52;
            this.address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Agency FB", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(16, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Contact";
            // 
            // cont
            // 
            this.cont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cont.Location = new System.Drawing.Point(19, 154);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(171, 26);
            this.cont.TabIndex = 50;
            this.cont.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(16, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Last Name";
            // 
            // lName
            // 
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(19, 106);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(171, 26);
            this.lName.TabIndex = 48;
            this.lName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "First Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Table_SAdd);
            this.panel2.Location = new System.Drawing.Point(437, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 311);
            this.panel2.TabIndex = 48;
            // 
            // Table_SAdd
            // 
            this.Table_SAdd.BackgroundColor = System.Drawing.Color.Orchid;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Table_SAdd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Table_SAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table_SAdd.DefaultCellStyle = dataGridViewCellStyle2;
            this.Table_SAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Table_SAdd.Location = new System.Drawing.Point(0, 4);
            this.Table_SAdd.Name = "Table_SAdd";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Table_SAdd.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Table_SAdd.RowHeadersWidth = 62;
            this.Table_SAdd.Size = new System.Drawing.Size(495, 307);
            this.Table_SAdd.TabIndex = 56;
            // 
            // guna2Shapes2
            // 
            this.guna2Shapes2.BorderColor = System.Drawing.Color.DarkOrchid;
            this.guna2Shapes2.FillColor = System.Drawing.Color.DarkOrchid;
            this.guna2Shapes2.Location = new System.Drawing.Point(691, 343);
            this.guna2Shapes2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Shapes2.Name = "guna2Shapes2";
            this.guna2Shapes2.PolygonSkip = 1;
            this.guna2Shapes2.Rotate = 0F;
            this.guna2Shapes2.Shape = Guna.UI2.WinForms.Enums.ShapeType.Ellipse;
            this.guna2Shapes2.Size = new System.Drawing.Size(133, 130);
            this.guna2Shapes2.TabIndex = 49;
            this.guna2Shapes2.Text = "guna2Shapes2";
            this.guna2Shapes2.Zoom = 80;
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BorderColor = System.Drawing.Color.DarkOrchid;
            this.guna2Shapes1.FillColor = System.Drawing.Color.DarkOrchid;
            this.guna2Shapes1.Location = new System.Drawing.Point(593, -58);
            this.guna2Shapes1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Ellipse;
            this.guna2Shapes1.Size = new System.Drawing.Size(133, 130);
            this.guna2Shapes1.TabIndex = 50;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 80;
            // 
            // guna2Shapes3
            // 
            this.guna2Shapes3.BorderColor = System.Drawing.Color.DarkOrchid;
            this.guna2Shapes3.FillColor = System.Drawing.Color.DarkOrchid;
            this.guna2Shapes3.Location = new System.Drawing.Point(74, -6);
            this.guna2Shapes3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Shapes3.Name = "guna2Shapes3";
            this.guna2Shapes3.PolygonSkip = 1;
            this.guna2Shapes3.Rotate = 0F;
            this.guna2Shapes3.Shape = Guna.UI2.WinForms.Enums.ShapeType.Ellipse;
            this.guna2Shapes3.Size = new System.Drawing.Size(133, 130);
            this.guna2Shapes3.TabIndex = 51;
            this.guna2Shapes3.Text = "guna2Shapes3";
            this.guna2Shapes3.Zoom = 80;
            // 
            // guna2Shapes4
            // 
            this.guna2Shapes4.BorderColor = System.Drawing.Color.DarkOrchid;
            this.guna2Shapes4.FillColor = System.Drawing.Color.DarkOrchid;
            this.guna2Shapes4.Location = new System.Drawing.Point(-21, 349);
            this.guna2Shapes4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Shapes4.Name = "guna2Shapes4";
            this.guna2Shapes4.PolygonSkip = 1;
            this.guna2Shapes4.Rotate = 0F;
            this.guna2Shapes4.Shape = Guna.UI2.WinForms.Enums.ShapeType.Ellipse;
            this.guna2Shapes4.Size = new System.Drawing.Size(99, 103);
            this.guna2Shapes4.TabIndex = 52;
            this.guna2Shapes4.Text = "guna2Shapes4";
            this.guna2Shapes4.Zoom = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Agency FB", 30F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(226, -6);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(274, 50);
            this.label9.TabIndex = 53;
            this.label9.Text = "Register New Staff";
            // 
            // Add_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(943, 399);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Shapes2);
            this.Controls.Add(this.guna2Shapes1);
            this.Controls.Add(this.guna2Shapes3);
            this.Controls.Add(this.guna2Shapes4);
            this.Controls.Add(this.label9);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Staff";
            this.Text = "Add_Staff";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Table_SAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ConfirmPass;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button EXIT_BUTTON;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes2;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes3;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView Table_SAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox desg;
    }
}