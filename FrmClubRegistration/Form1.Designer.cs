namespace FrmClubRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ListOfClubMembersview = new System.Windows.Forms.DataGridView();
            this.aGETxtbx = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LastNameTxtbx = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstNameTxtbx = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MiddleNameTxtbx = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GenderCombobox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProgramCombobox = new System.Windows.Forms.ComboBox();
            this.StudentIdTxtbx = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfClubMembersview)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListOfClubMembersview
            // 
            this.ListOfClubMembersview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListOfClubMembersview.Location = new System.Drawing.Point(16, 354);
            this.ListOfClubMembersview.Margin = new System.Windows.Forms.Padding(4);
            this.ListOfClubMembersview.Name = "ListOfClubMembersview";
            this.ListOfClubMembersview.RowHeadersWidth = 51;
            this.ListOfClubMembersview.Size = new System.Drawing.Size(1018, 185);
            this.ListOfClubMembersview.TabIndex = 12;
            this.ListOfClubMembersview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListOfClubMembersview_CellContentClick);
            // 
            // aGETxtbx
            // 
            this.aGETxtbx.Location = new System.Drawing.Point(23, 219);
            this.aGETxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.aGETxtbx.Name = "aGETxtbx";
            this.aGETxtbx.Size = new System.Drawing.Size(184, 35);
            this.aGETxtbx.TabIndex = 11;
            this.aGETxtbx.Text = "";
            this.aGETxtbx.TextChanged += new System.EventHandler(this.aGETxtbx_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("SimSun-ExtB", 16.2F);
            this.label6.Location = new System.Drawing.Point(23, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Age:";
            // 
            // LastNameTxtbx
            // 
            this.LastNameTxtbx.Location = new System.Drawing.Point(23, 134);
            this.LastNameTxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.LastNameTxtbx.Name = "LastNameTxtbx";
            this.LastNameTxtbx.Size = new System.Drawing.Size(247, 35);
            this.LastNameTxtbx.TabIndex = 18;
            this.LastNameTxtbx.Text = "";
            this.LastNameTxtbx.TextChanged += new System.EventHandler(this.LastNameTxtbx_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("SimSun-ExtB", 16.2F);
            this.label3.Location = new System.Drawing.Point(23, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Last Name:";
            // 
            // FirstNameTxtbx
            // 
            this.FirstNameTxtbx.Location = new System.Drawing.Point(279, 134);
            this.FirstNameTxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.FirstNameTxtbx.Name = "FirstNameTxtbx";
            this.FirstNameTxtbx.Size = new System.Drawing.Size(247, 35);
            this.FirstNameTxtbx.TabIndex = 20;
            this.FirstNameTxtbx.Text = "";
            this.FirstNameTxtbx.TextChanged += new System.EventHandler(this.FirstNameTxtbx_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("SimSun-ExtB", 16.2F);
            this.label4.Location = new System.Drawing.Point(279, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "First Name:";
            // 
            // MiddleNameTxtbx
            // 
            this.MiddleNameTxtbx.Location = new System.Drawing.Point(544, 134);
            this.MiddleNameTxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.MiddleNameTxtbx.Name = "MiddleNameTxtbx";
            this.MiddleNameTxtbx.Size = new System.Drawing.Size(247, 35);
            this.MiddleNameTxtbx.TabIndex = 22;
            this.MiddleNameTxtbx.Text = "";
            this.MiddleNameTxtbx.TextChanged += new System.EventHandler(this.MiddleNameTxtbx_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("SimSun-ExtB", 16.2F);
            this.label5.Location = new System.Drawing.Point(544, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 28);
            this.label5.TabIndex = 21;
            this.label5.Text = "Middle Name:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("SimSun-ExtB", 16.2F);
            this.label7.Location = new System.Drawing.Point(235, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 28);
            this.label7.TabIndex = 23;
            this.label7.Text = "Gender:";
            // 
            // GenderCombobox
            // 
            this.GenderCombobox.FormattingEnabled = true;
            this.GenderCombobox.Items.AddRange(new object[] {
            "Sample"});
            this.GenderCombobox.Location = new System.Drawing.Point(241, 229);
            this.GenderCombobox.Margin = new System.Windows.Forms.Padding(4);
            this.GenderCombobox.Name = "GenderCombobox";
            this.GenderCombobox.Size = new System.Drawing.Size(336, 24);
            this.GenderCombobox.TabIndex = 25;
            this.GenderCombobox.SelectedIndexChanged += new System.EventHandler(this.GenderCombobox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("SimSun-ExtB", 16.2F);
            this.label8.Location = new System.Drawing.Point(53, 316);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(292, 28);
            this.label8.TabIndex = 27;
            this.label8.Text = "List Of Club Members";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Font = new System.Drawing.Font("SimSun-ExtB", 16.2F);
            this.RegisterBtn.Location = new System.Drawing.Point(907, 49);
            this.RegisterBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(127, 52);
            this.RegisterBtn.TabIndex = 28;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("SimSun-ExtB", 16.2F);
            this.UpdateBtn.Location = new System.Drawing.Point(907, 134);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(127, 52);
            this.UpdateBtn.TabIndex = 29;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("SimSun-ExtB", 16.2F);
            this.button1.Location = new System.Drawing.Point(907, 229);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 52);
            this.button1.TabIndex = 30;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("SimSun-ExtB", 16.2F);
            this.label2.Location = new System.Drawing.Point(433, -1);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Program:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Student ID:";
            // 
            // ProgramCombobox
            // 
            this.ProgramCombobox.FormattingEnabled = true;
            this.ProgramCombobox.Items.AddRange(new object[] {
            "Sample"});
            this.ProgramCombobox.Location = new System.Drawing.Point(439, 49);
            this.ProgramCombobox.Margin = new System.Windows.Forms.Padding(4);
            this.ProgramCombobox.Name = "ProgramCombobox";
            this.ProgramCombobox.Size = new System.Drawing.Size(336, 24);
            this.ProgramCombobox.TabIndex = 24;
            this.ProgramCombobox.SelectedIndexChanged += new System.EventHandler(this.ProgramCombobox_SelectedIndexChanged);
            // 
            // StudentIdTxtbx
            // 
            this.StudentIdTxtbx.Location = new System.Drawing.Point(7, 39);
            this.StudentIdTxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.StudentIdTxtbx.Name = "StudentIdTxtbx";
            this.StudentIdTxtbx.Size = new System.Drawing.Size(228, 35);
            this.StudentIdTxtbx.TabIndex = 14;
            this.StudentIdTxtbx.Text = "";
            this.StudentIdTxtbx.TextChanged += new System.EventHandler(this.StudentIdTxtbx_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.StudentIdTxtbx);
            this.panel1.Controls.Add(this.ProgramCombobox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 284);
            this.panel1.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GenderCombobox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MiddleNameTxtbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FirstNameTxtbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LastNameTxtbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListOfClubMembersview);
            this.Controls.Add(this.aGETxtbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ListOfClubMembersview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListOfClubMembersview;
        private System.Windows.Forms.RichTextBox aGETxtbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox LastNameTxtbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox FirstNameTxtbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox MiddleNameTxtbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox GenderCombobox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProgramCombobox;
        private System.Windows.Forms.RichTextBox StudentIdTxtbx;
        private System.Windows.Forms.Panel panel1;
    }
}

