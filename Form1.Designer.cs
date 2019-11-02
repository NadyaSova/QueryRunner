namespace QuerySaver
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabRunQuery = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLocations = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtJobTitles = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtExcludeCompany = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPostFrom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPostTo = new System.Windows.Forms.TextBox();
            this.btn6hours = new System.Windows.Forms.Button();
            this.btn12hours = new System.Windows.Forms.Button();
            this.btn24hours = new System.Windows.Forms.Button();
            this.btn36hours = new System.Windows.Forms.Button();
            this.btn48hours = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRunQuery = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabRunQuery.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabSettings);
            this.tabMain.Controls.Add(this.tabRunQuery);
            this.tabMain.Location = new System.Drawing.Point(2, 2);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1066, 760);
            this.tabMain.TabIndex = 0;
            this.tabMain.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabMain_Selecting);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.btnSaveSettings);
            this.tabSettings.Controls.Add(this.txtPassword);
            this.tabSettings.Controls.Add(this.label4);
            this.tabSettings.Controls.Add(this.txtUser);
            this.tabSettings.Controls.Add(this.label3);
            this.tabSettings.Controls.Add(this.txtDatabase);
            this.tabSettings.Controls.Add(this.label2);
            this.tabSettings.Controls.Add(this.txtServer);
            this.tabSettings.Controls.Add(this.label1);
            this.tabSettings.Location = new System.Drawing.Point(4, 25);
            this.tabSettings.Margin = new System.Windows.Forms.Padding(4);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(4);
            this.tabSettings.Size = new System.Drawing.Size(1058, 523);
            this.tabSettings.TabIndex = 0;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(96, 159);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(120, 31);
            this.btnSaveSettings.TabIndex = 8;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(96, 116);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(203, 23);
            this.txtPassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(96, 85);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(203, 23);
            this.txtUser.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "User";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(96, 54);
            this.txtDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(203, 23);
            this.txtDatabase.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(96, 23);
            this.txtServer.Margin = new System.Windows.Forms.Padding(4);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(203, 23);
            this.txtServer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // tabRunQuery
            // 
            this.tabRunQuery.Controls.Add(this.btnRunQuery);
            this.tabRunQuery.Controls.Add(this.btnReset);
            this.tabRunQuery.Controls.Add(this.btn48hours);
            this.tabRunQuery.Controls.Add(this.btn36hours);
            this.tabRunQuery.Controls.Add(this.btn24hours);
            this.tabRunQuery.Controls.Add(this.btn12hours);
            this.tabRunQuery.Controls.Add(this.btn6hours);
            this.tabRunQuery.Controls.Add(this.txtPostTo);
            this.tabRunQuery.Controls.Add(this.label10);
            this.tabRunQuery.Controls.Add(this.txtPostFrom);
            this.tabRunQuery.Controls.Add(this.label9);
            this.tabRunQuery.Controls.Add(this.txtExcludeCompany);
            this.tabRunQuery.Controls.Add(this.label8);
            this.tabRunQuery.Controls.Add(this.label7);
            this.tabRunQuery.Controls.Add(this.txtJobTitles);
            this.tabRunQuery.Controls.Add(this.label6);
            this.tabRunQuery.Controls.Add(this.txtLocations);
            this.tabRunQuery.Controls.Add(this.label5);
            this.tabRunQuery.Location = new System.Drawing.Point(4, 25);
            this.tabRunQuery.Margin = new System.Windows.Forms.Padding(4);
            this.tabRunQuery.Name = "tabRunQuery";
            this.tabRunQuery.Padding = new System.Windows.Forms.Padding(4);
            this.tabRunQuery.Size = new System.Drawing.Size(1058, 731);
            this.tabRunQuery.TabIndex = 1;
            this.tabRunQuery.Text = "Run Query";
            this.tabRunQuery.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Locations";
            // 
            // txtLocations
            // 
            this.txtLocations.Location = new System.Drawing.Point(11, 28);
            this.txtLocations.Multiline = true;
            this.txtLocations.Name = "txtLocations";
            this.txtLocations.Size = new System.Drawing.Size(1040, 136);
            this.txtLocations.TabIndex = 1;
            this.txtLocations.Text = resources.GetString("txtLocations.Text");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Job Titles";
            // 
            // txtJobTitles
            // 
            this.txtJobTitles.Location = new System.Drawing.Point(11, 206);
            this.txtJobTitles.Multiline = true;
            this.txtJobTitles.Name = "txtJobTitles";
            this.txtJobTitles.Size = new System.Drawing.Size(1035, 160);
            this.txtJobTitles.TabIndex = 3;
            this.txtJobTitles.Text = resources.GetString("txtJobTitles.Text");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Exclude Company";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 587);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Post Date Range";
            // 
            // txtExcludeCompany
            // 
            this.txtExcludeCompany.Location = new System.Drawing.Point(11, 406);
            this.txtExcludeCompany.Multiline = true;
            this.txtExcludeCompany.Name = "txtExcludeCompany";
            this.txtExcludeCompany.Size = new System.Drawing.Size(1035, 160);
            this.txtExcludeCompany.TabIndex = 6;
            this.txtExcludeCompany.Text = "Apple Inc.; Samsung Electronics\t; Amazon; Foxconn; Alphabet Inc.; Microsoft; Huaw" +
    "ei; Hitachi; IBM; Dell Technologies; Sony; Panasonic; Intel; LG Electronics; JD." +
    "com; HP Inc.; ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 610);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "from";
            // 
            // txtPostFrom
            // 
            this.txtPostFrom.Location = new System.Drawing.Point(56, 607);
            this.txtPostFrom.Name = "txtPostFrom";
            this.txtPostFrom.Size = new System.Drawing.Size(125, 23);
            this.txtPostFrom.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(190, 607);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "to";
            // 
            // txtPostTo
            // 
            this.txtPostTo.Location = new System.Drawing.Point(216, 607);
            this.txtPostTo.Name = "txtPostTo";
            this.txtPostTo.Size = new System.Drawing.Size(125, 23);
            this.txtPostTo.TabIndex = 10;
            // 
            // btn6hours
            // 
            this.btn6hours.Location = new System.Drawing.Point(363, 604);
            this.btn6hours.Name = "btn6hours";
            this.btn6hours.Size = new System.Drawing.Size(110, 29);
            this.btn6hours.TabIndex = 11;
            this.btn6hours.Text = "Last 6 hours";
            this.btn6hours.UseVisualStyleBackColor = true;
            this.btn6hours.Click += new System.EventHandler(this.btn6hours_Click);
            // 
            // btn12hours
            // 
            this.btn12hours.Location = new System.Drawing.Point(479, 604);
            this.btn12hours.Name = "btn12hours";
            this.btn12hours.Size = new System.Drawing.Size(110, 29);
            this.btn12hours.TabIndex = 12;
            this.btn12hours.Text = "Last 12 hours";
            this.btn12hours.UseVisualStyleBackColor = true;
            this.btn12hours.Click += new System.EventHandler(this.btn12hours_Click);
            // 
            // btn24hours
            // 
            this.btn24hours.Location = new System.Drawing.Point(595, 604);
            this.btn24hours.Name = "btn24hours";
            this.btn24hours.Size = new System.Drawing.Size(110, 29);
            this.btn24hours.TabIndex = 13;
            this.btn24hours.Text = "Last 24 hours";
            this.btn24hours.UseVisualStyleBackColor = true;
            this.btn24hours.Click += new System.EventHandler(this.btn24hours_Click);
            // 
            // btn36hours
            // 
            this.btn36hours.Location = new System.Drawing.Point(711, 604);
            this.btn36hours.Name = "btn36hours";
            this.btn36hours.Size = new System.Drawing.Size(110, 29);
            this.btn36hours.TabIndex = 14;
            this.btn36hours.Text = "Last 36 hours";
            this.btn36hours.UseVisualStyleBackColor = true;
            this.btn36hours.Click += new System.EventHandler(this.btn36hours_Click);
            // 
            // btn48hours
            // 
            this.btn48hours.Location = new System.Drawing.Point(826, 604);
            this.btn48hours.Name = "btn48hours";
            this.btn48hours.Size = new System.Drawing.Size(110, 29);
            this.btn48hours.TabIndex = 15;
            this.btn48hours.Text = "Last 48 hours";
            this.btn48hours.UseVisualStyleBackColor = true;
            this.btn48hours.Click += new System.EventHandler(this.btn48hours_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(151, 659);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRunQuery
            // 
            this.btnRunQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRunQuery.Location = new System.Drawing.Point(17, 659);
            this.btnRunQuery.Name = "btnRunQuery";
            this.btnRunQuery.Size = new System.Drawing.Size(100, 28);
            this.btnRunQuery.TabIndex = 17;
            this.btnRunQuery.Text = "Run query";
            this.btnRunQuery.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 762);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Save Query";
            this.tabMain.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.tabRunQuery.ResumeLayout(false);
            this.tabRunQuery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabRunQuery;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.TextBox txtExcludeCompany;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtJobTitles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLocations;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPostTo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPostFrom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn48hours;
        private System.Windows.Forms.Button btn36hours;
        private System.Windows.Forms.Button btn24hours;
        private System.Windows.Forms.Button btn12hours;
        private System.Windows.Forms.Button btn6hours;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRunQuery;
    }
}

