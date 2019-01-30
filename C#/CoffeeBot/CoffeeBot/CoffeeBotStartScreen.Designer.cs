namespace CoffeeBot
{
    partial class CoffeeBotStartScreen
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAccounts = new System.Windows.Forms.Button();
            this.btnBot = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panelBotSelection = new System.Windows.Forms.Panel();
            this.lblbotGameSelect = new System.Windows.Forms.Label();
            this.ddlbotGameSelect = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblSceneTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnAccountsBack = new System.Windows.Forms.Button();
            this.lblaccAccountName = new System.Windows.Forms.Label();
            this.ddlaccAccountSelect = new System.Windows.Forms.ComboBox();
            this.lblaccGameSelect = new System.Windows.Forms.Label();
            this.ddlaccGameSelect = new System.Windows.Forms.ComboBox();
            this.lblaccNewAccount = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.lblaccPassword = new System.Windows.Forms.Label();
            this.txtaccPassword = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblaccNewPass = new System.Windows.Forms.Label();
            this.lblaccConfirmPass = new System.Windows.Forms.Label();
            this.txtaccNewPass = new System.Windows.Forms.TextBox();
            this.txtaccConfirmPass = new System.Windows.Forms.TextBox();
            this.lblbotAccountSelect = new System.Windows.Forms.Label();
            this.ddlbotAccountSelect = new System.Windows.Forms.ComboBox();
            this.lblbotRunFunction = new System.Windows.Forms.Label();
            this.checkboxCont = new System.Windows.Forms.CheckBox();
            this.checkboxRotate = new System.Windows.Forms.CheckBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelBotSelection.SuspendLayout();
            this.panelAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnAccounts);
            this.panelMenu.Controls.Add(this.btnBot);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 617);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(3, 392);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(174, 115);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnAccounts
            // 
            this.btnAccounts.FlatAppearance.BorderSize = 0;
            this.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccounts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccounts.ForeColor = System.Drawing.Color.White;
            this.btnAccounts.Location = new System.Drawing.Point(3, 271);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(174, 115);
            this.btnAccounts.TabIndex = 2;
            this.btnAccounts.Text = "Accounts";
            this.btnAccounts.UseVisualStyleBackColor = true;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // btnBot
            // 
            this.btnBot.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.btnBot.FlatAppearance.BorderSize = 0;
            this.btnBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBot.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBot.ForeColor = System.Drawing.Color.White;
            this.btnBot.Location = new System.Drawing.Point(3, 150);
            this.btnBot.Name = "btnBot";
            this.btnBot.Size = new System.Drawing.Size(174, 115);
            this.btnBot.TabIndex = 1;
            this.btnBot.Text = "Bot Selection";
            this.btnBot.UseVisualStyleBackColor = true;
            this.btnBot.Click += new System.EventHandler(this.btnBot_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(51)))));
            this.panelLogo.Controls.Add(this.pbLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(180, 144);
            this.panelLogo.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::CoffeeBot.Properties.Resources.CoffeeBotLogo;
            this.pbLogo.Location = new System.Drawing.Point(28, -43);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(136, 199);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // panelBotSelection
            // 
            this.panelBotSelection.Controls.Add(this.checkboxRotate);
            this.panelBotSelection.Controls.Add(this.checkboxCont);
            this.panelBotSelection.Controls.Add(this.lblbotRunFunction);
            this.panelBotSelection.Controls.Add(this.ddlbotAccountSelect);
            this.panelBotSelection.Controls.Add(this.lblbotAccountSelect);
            this.panelBotSelection.Controls.Add(this.lblbotGameSelect);
            this.panelBotSelection.Controls.Add(this.ddlbotGameSelect);
            this.panelBotSelection.Controls.Add(this.btnStart);
            this.panelBotSelection.Location = new System.Drawing.Point(183, 47);
            this.panelBotSelection.Name = "panelBotSelection";
            this.panelBotSelection.Size = new System.Drawing.Size(830, 570);
            this.panelBotSelection.TabIndex = 1;
            // 
            // lblbotGameSelect
            // 
            this.lblbotGameSelect.AutoSize = true;
            this.lblbotGameSelect.Location = new System.Drawing.Point(260, 154);
            this.lblbotGameSelect.Name = "lblbotGameSelect";
            this.lblbotGameSelect.Size = new System.Drawing.Size(60, 21);
            this.lblbotGameSelect.TabIndex = 6;
            this.lblbotGameSelect.Text = "Game";
            // 
            // ddlbotGameSelect
            // 
            this.ddlbotGameSelect.FormattingEnabled = true;
            this.ddlbotGameSelect.Location = new System.Drawing.Point(424, 152);
            this.ddlbotGameSelect.Name = "ddlbotGameSelect";
            this.ddlbotGameSelect.Size = new System.Drawing.Size(207, 29);
            this.ddlbotGameSelect.TabIndex = 5;
            this.ddlbotGameSelect.Text = "Select Game...";
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(269, 488);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(254, 52);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Launch";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // lblSceneTitle
            // 
            this.lblSceneTitle.AutoSize = true;
            this.lblSceneTitle.Location = new System.Drawing.Point(186, 9);
            this.lblSceneTitle.Name = "lblSceneTitle";
            this.lblSceneTitle.Size = new System.Drawing.Size(198, 21);
            this.lblSceneTitle.TabIndex = 2;
            this.lblSceneTitle.Text = "CoffeeBot: Bot Selection";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(959, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 41);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelAccount
            // 
            this.panelAccount.Controls.Add(this.txtaccConfirmPass);
            this.panelAccount.Controls.Add(this.txtaccNewPass);
            this.panelAccount.Controls.Add(this.lblaccConfirmPass);
            this.panelAccount.Controls.Add(this.lblaccNewPass);
            this.panelAccount.Controls.Add(this.btnClear);
            this.panelAccount.Controls.Add(this.btnSubmit);
            this.panelAccount.Controls.Add(this.txtaccPassword);
            this.panelAccount.Controls.Add(this.lblaccPassword);
            this.panelAccount.Controls.Add(this.txtAccountName);
            this.panelAccount.Controls.Add(this.lblaccNewAccount);
            this.panelAccount.Controls.Add(this.ddlaccGameSelect);
            this.panelAccount.Controls.Add(this.lblaccGameSelect);
            this.panelAccount.Controls.Add(this.ddlaccAccountSelect);
            this.panelAccount.Controls.Add(this.lblaccAccountName);
            this.panelAccount.Controls.Add(this.btnAccountsBack);
            this.panelAccount.Controls.Add(this.btnManage);
            this.panelAccount.Controls.Add(this.btnAddAccount);
            this.panelAccount.Location = new System.Drawing.Point(180, 47);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(830, 570);
            this.panelAccount.TabIndex = 4;
            this.panelAccount.Visible = false;
            // 
            // btnManage
            // 
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.Location = new System.Drawing.Point(166, 21);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(97, 43);
            this.btnManage.TabIndex = 1;
            this.btnManage.Text = "Manage";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccount.Location = new System.Drawing.Point(41, 21);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(97, 43);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "Add";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnAccountsBack
            // 
            this.btnAccountsBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountsBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnAccountsBack.Location = new System.Drawing.Point(721, 21);
            this.btnAccountsBack.Name = "btnAccountsBack";
            this.btnAccountsBack.Size = new System.Drawing.Size(97, 43);
            this.btnAccountsBack.TabIndex = 2;
            this.btnAccountsBack.Text = "Back";
            this.btnAccountsBack.UseVisualStyleBackColor = true;
            this.btnAccountsBack.Visible = false;
            this.btnAccountsBack.Click += new System.EventHandler(this.btnAccountsBack_Click);
            // 
            // lblaccAccountName
            // 
            this.lblaccAccountName.AutoSize = true;
            this.lblaccAccountName.Location = new System.Drawing.Point(37, 224);
            this.lblaccAccountName.Name = "lblaccAccountName";
            this.lblaccAccountName.Size = new System.Drawing.Size(80, 21);
            this.lblaccAccountName.TabIndex = 3;
            this.lblaccAccountName.Text = "Account";
            this.lblaccAccountName.Visible = false;
            // 
            // ddlaccAccountSelect
            // 
            this.ddlaccAccountSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ddlaccAccountSelect.FormattingEnabled = true;
            this.ddlaccAccountSelect.Location = new System.Drawing.Point(162, 216);
            this.ddlaccAccountSelect.Name = "ddlaccAccountSelect";
            this.ddlaccAccountSelect.Size = new System.Drawing.Size(121, 29);
            this.ddlaccAccountSelect.TabIndex = 4;
            this.ddlaccAccountSelect.Visible = false;
            // 
            // lblaccGameSelect
            // 
            this.lblaccGameSelect.AutoSize = true;
            this.lblaccGameSelect.Location = new System.Drawing.Point(37, 149);
            this.lblaccGameSelect.Name = "lblaccGameSelect";
            this.lblaccGameSelect.Size = new System.Drawing.Size(60, 21);
            this.lblaccGameSelect.TabIndex = 5;
            this.lblaccGameSelect.Text = "Game";
            this.lblaccGameSelect.Visible = false;
            // 
            // ddlaccGameSelect
            // 
            this.ddlaccGameSelect.FormattingEnabled = true;
            this.ddlaccGameSelect.Location = new System.Drawing.Point(162, 148);
            this.ddlaccGameSelect.Name = "ddlaccGameSelect";
            this.ddlaccGameSelect.Size = new System.Drawing.Size(121, 29);
            this.ddlaccGameSelect.TabIndex = 6;
            this.ddlaccGameSelect.Visible = false;
            // 
            // lblaccNewAccount
            // 
            this.lblaccNewAccount.AutoSize = true;
            this.lblaccNewAccount.Location = new System.Drawing.Point(37, 224);
            this.lblaccNewAccount.Name = "lblaccNewAccount";
            this.lblaccNewAccount.Size = new System.Drawing.Size(132, 21);
            this.lblaccNewAccount.TabIndex = 7;
            this.lblaccNewAccount.Text = "Account Name";
            this.lblaccNewAccount.Visible = false;
            // 
            // txtAccountName
            // 
            this.txtAccountName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtAccountName.Location = new System.Drawing.Point(183, 218);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(100, 27);
            this.txtAccountName.TabIndex = 8;
            this.txtAccountName.Visible = false;
            // 
            // lblaccPassword
            // 
            this.lblaccPassword.AutoSize = true;
            this.lblaccPassword.Location = new System.Drawing.Point(41, 284);
            this.lblaccPassword.Name = "lblaccPassword";
            this.lblaccPassword.Size = new System.Drawing.Size(82, 21);
            this.lblaccPassword.TabIndex = 9;
            this.lblaccPassword.Text = "Password";
            this.lblaccPassword.Visible = false;
            // 
            // txtaccPassword
            // 
            this.txtaccPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtaccPassword.Location = new System.Drawing.Point(182, 284);
            this.txtaccPassword.Name = "txtaccPassword";
            this.txtaccPassword.Size = new System.Drawing.Size(100, 27);
            this.txtaccPassword.TabIndex = 10;
            this.txtaccPassword.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(41, 400);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(97, 43);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(166, 400);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 43);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            // 
            // lblaccNewPass
            // 
            this.lblaccNewPass.AutoSize = true;
            this.lblaccNewPass.Location = new System.Drawing.Point(37, 284);
            this.lblaccNewPass.Name = "lblaccNewPass";
            this.lblaccNewPass.Size = new System.Drawing.Size(122, 21);
            this.lblaccNewPass.TabIndex = 13;
            this.lblaccNewPass.Text = "New Password";
            this.lblaccNewPass.Visible = false;
            // 
            // lblaccConfirmPass
            // 
            this.lblaccConfirmPass.AutoSize = true;
            this.lblaccConfirmPass.Location = new System.Drawing.Point(37, 345);
            this.lblaccConfirmPass.Name = "lblaccConfirmPass";
            this.lblaccConfirmPass.Size = new System.Drawing.Size(147, 21);
            this.lblaccConfirmPass.TabIndex = 14;
            this.lblaccConfirmPass.Text = "Confirm Password";
            this.lblaccConfirmPass.Visible = false;
            // 
            // txtaccNewPass
            // 
            this.txtaccNewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtaccNewPass.Location = new System.Drawing.Point(183, 284);
            this.txtaccNewPass.Name = "txtaccNewPass";
            this.txtaccNewPass.Size = new System.Drawing.Size(100, 27);
            this.txtaccNewPass.TabIndex = 15;
            this.txtaccNewPass.Visible = false;
            // 
            // txtaccConfirmPass
            // 
            this.txtaccConfirmPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtaccConfirmPass.Location = new System.Drawing.Point(182, 339);
            this.txtaccConfirmPass.Name = "txtaccConfirmPass";
            this.txtaccConfirmPass.Size = new System.Drawing.Size(100, 27);
            this.txtaccConfirmPass.TabIndex = 16;
            this.txtaccConfirmPass.Visible = false;
            // 
            // lblbotAccountSelect
            // 
            this.lblbotAccountSelect.AutoSize = true;
            this.lblbotAccountSelect.Location = new System.Drawing.Point(260, 251);
            this.lblbotAccountSelect.Name = "lblbotAccountSelect";
            this.lblbotAccountSelect.Size = new System.Drawing.Size(80, 21);
            this.lblbotAccountSelect.TabIndex = 9;
            this.lblbotAccountSelect.Text = "Account";
            this.lblbotAccountSelect.Visible = false;
            // 
            // ddlbotAccountSelect
            // 
            this.ddlbotAccountSelect.FormattingEnabled = true;
            this.ddlbotAccountSelect.Location = new System.Drawing.Point(424, 248);
            this.ddlbotAccountSelect.Name = "ddlbotAccountSelect";
            this.ddlbotAccountSelect.Size = new System.Drawing.Size(121, 29);
            this.ddlbotAccountSelect.TabIndex = 10;
            this.ddlbotAccountSelect.Visible = false;
            // 
            // lblbotRunFunction
            // 
            this.lblbotRunFunction.AutoSize = true;
            this.lblbotRunFunction.Location = new System.Drawing.Point(260, 345);
            this.lblbotRunFunction.Name = "lblbotRunFunction";
            this.lblbotRunFunction.Size = new System.Drawing.Size(112, 21);
            this.lblbotRunFunction.TabIndex = 11;
            this.lblbotRunFunction.Text = "Run Function";
            this.lblbotRunFunction.Visible = false;
            // 
            // checkboxCont
            // 
            this.checkboxCont.AutoSize = true;
            this.checkboxCont.Location = new System.Drawing.Point(424, 323);
            this.checkboxCont.Name = "checkboxCont";
            this.checkboxCont.Size = new System.Drawing.Size(129, 25);
            this.checkboxCont.TabIndex = 12;
            this.checkboxCont.Text = "Continuously";
            this.checkboxCont.UseVisualStyleBackColor = true;
            this.checkboxCont.Visible = false;
            // 
            // checkboxRotate
            // 
            this.checkboxRotate.AutoSize = true;
            this.checkboxRotate.Location = new System.Drawing.Point(424, 360);
            this.checkboxRotate.Name = "checkboxRotate";
            this.checkboxRotate.Size = new System.Drawing.Size(73, 25);
            this.checkboxRotate.TabIndex = 13;
            this.checkboxRotate.Text = "Cycle";
            this.checkboxRotate.UseVisualStyleBackColor = true;
            this.checkboxRotate.Visible = false;
            // 
            // CoffeeBotStartScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1010, 617);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelBotSelection);
            this.Controls.Add(this.panelAccount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblSceneTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CoffeeBotStartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelBotSelection.ResumeLayout(false);
            this.panelBotSelection.PerformLayout();
            this.panelAccount.ResumeLayout(false);
            this.panelAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnBot;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panelBotSelection;
        private System.Windows.Forms.Label lblSceneTitle;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnAccounts;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblbotGameSelect;
        private System.Windows.Forms.ComboBox ddlbotGameSelect;
        private System.Windows.Forms.Panel panelAccount;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnAccountsBack;
        private System.Windows.Forms.ComboBox ddlaccGameSelect;
        private System.Windows.Forms.Label lblaccGameSelect;
        private System.Windows.Forms.ComboBox ddlaccAccountSelect;
        private System.Windows.Forms.Label lblaccAccountName;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label lblaccNewAccount;
        private System.Windows.Forms.Label lblaccPassword;
        private System.Windows.Forms.TextBox txtaccPassword;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtaccConfirmPass;
        private System.Windows.Forms.TextBox txtaccNewPass;
        private System.Windows.Forms.Label lblaccConfirmPass;
        private System.Windows.Forms.Label lblaccNewPass;
        private System.Windows.Forms.Label lblbotAccountSelect;
        private System.Windows.Forms.CheckBox checkboxRotate;
        private System.Windows.Forms.CheckBox checkboxCont;
        private System.Windows.Forms.Label lblbotRunFunction;
        private System.Windows.Forms.ComboBox ddlbotAccountSelect;
    }
}

