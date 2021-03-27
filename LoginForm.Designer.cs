
namespace Gym_Management_System
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.forgotPassLinkLabel = new System.Windows.Forms.LinkLabel();
            this.loginBtn = new System.Windows.Forms.Button();
            this.userNameTxt = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.passwordTxt = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.logClose = new System.Windows.Forms.Label();
            this.showPassCheckBox = new System.Windows.Forms.CheckBox();
            this.signUpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.roleCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 347);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(314, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "FITNESS CENTER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(493, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(493, 123);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // forgotPassLinkLabel
            // 
            this.forgotPassLinkLabel.AutoSize = true;
            this.forgotPassLinkLabel.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.forgotPassLinkLabel.Location = new System.Drawing.Point(348, 260);
            this.forgotPassLinkLabel.Name = "forgotPassLinkLabel";
            this.forgotPassLinkLabel.Size = new System.Drawing.Size(127, 19);
            this.forgotPassLinkLabel.TabIndex = 6;
            this.forgotPassLinkLabel.TabStop = true;
            this.forgotPassLinkLabel.Text = "Forgot Password?";
            this.forgotPassLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPassLinkLabel_LinkClicked);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Crimson;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.loginBtn.Location = new System.Drawing.Point(301, 217);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(80, 30);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // userNameTxt
            // 
            this.userNameTxt.AcceptsReturn = false;
            this.userNameTxt.AcceptsTab = false;
            this.userNameTxt.AnimationSpeed = 200;
            this.userNameTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.userNameTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.userNameTxt.BackColor = System.Drawing.Color.Transparent;
            this.userNameTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userNameTxt.BackgroundImage")));
            this.userNameTxt.BorderColorActive = System.Drawing.Color.MediumVioletRed;
            this.userNameTxt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.userNameTxt.BorderColorHover = System.Drawing.Color.Fuchsia;
            this.userNameTxt.BorderColorIdle = System.Drawing.Color.Silver;
            this.userNameTxt.BorderRadius = 1;
            this.userNameTxt.BorderThickness = 1;
            this.userNameTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.userNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameTxt.DefaultFont = new System.Drawing.Font("Segoe UI", 11F);
            this.userNameTxt.DefaultText = "";
            this.userNameTxt.FillColor = System.Drawing.Color.White;
            this.userNameTxt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userNameTxt.HideSelection = true;
            this.userNameTxt.IconLeft = null;
            this.userNameTxt.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameTxt.IconPadding = 10;
            this.userNameTxt.IconRight = null;
            this.userNameTxt.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameTxt.Lines = new string[0];
            this.userNameTxt.Location = new System.Drawing.Point(301, 70);
            this.userNameTxt.MaxLength = 32767;
            this.userNameTxt.MinimumSize = new System.Drawing.Size(100, 35);
            this.userNameTxt.Modified = false;
            this.userNameTxt.Multiline = false;
            this.userNameTxt.Name = "userNameTxt";
            stateProperties1.BorderColor = System.Drawing.Color.MediumVioletRed;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.userNameTxt.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.userNameTxt.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.Fuchsia;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.userNameTxt.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.SystemColors.ControlText;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.userNameTxt.OnIdleState = stateProperties4;
            this.userNameTxt.PasswordChar = '\0';
            this.userNameTxt.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.userNameTxt.PlaceholderText = "Username";
            this.userNameTxt.ReadOnly = false;
            this.userNameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userNameTxt.SelectedText = "";
            this.userNameTxt.SelectionLength = 0;
            this.userNameTxt.SelectionStart = 0;
            this.userNameTxt.ShortcutsEnabled = true;
            this.userNameTxt.Size = new System.Drawing.Size(192, 35);
            this.userNameTxt.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.userNameTxt.TabIndex = 1;
            this.userNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userNameTxt.TextMarginBottom = 0;
            this.userNameTxt.TextMarginLeft = 5;
            this.userNameTxt.TextMarginTop = 0;
            this.userNameTxt.TextPlaceholder = "Username";
            this.userNameTxt.UseSystemPasswordChar = false;
            this.userNameTxt.WordWrap = true;
            this.userNameTxt.DoubleClick += new System.EventHandler(this.userNameTxt_DoubleClick);
            // 
            // passwordTxt
            // 
            this.passwordTxt.AcceptsReturn = false;
            this.passwordTxt.AcceptsTab = false;
            this.passwordTxt.AnimationSpeed = 200;
            this.passwordTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passwordTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passwordTxt.BackColor = System.Drawing.Color.Transparent;
            this.passwordTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passwordTxt.BackgroundImage")));
            this.passwordTxt.BorderColorActive = System.Drawing.Color.MediumVioletRed;
            this.passwordTxt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.passwordTxt.BorderColorHover = System.Drawing.Color.Fuchsia;
            this.passwordTxt.BorderColorIdle = System.Drawing.Color.Silver;
            this.passwordTxt.BorderRadius = 1;
            this.passwordTxt.BorderThickness = 1;
            this.passwordTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTxt.DefaultFont = new System.Drawing.Font("Segoe UI", 11F);
            this.passwordTxt.DefaultText = "";
            this.passwordTxt.FillColor = System.Drawing.Color.White;
            this.passwordTxt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.passwordTxt.HideSelection = true;
            this.passwordTxt.IconLeft = null;
            this.passwordTxt.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTxt.IconPadding = 10;
            this.passwordTxt.IconRight = null;
            this.passwordTxt.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTxt.Lines = new string[0];
            this.passwordTxt.Location = new System.Drawing.Point(301, 122);
            this.passwordTxt.MaxLength = 32767;
            this.passwordTxt.MinimumSize = new System.Drawing.Size(100, 35);
            this.passwordTxt.Modified = false;
            this.passwordTxt.Multiline = false;
            this.passwordTxt.Name = "passwordTxt";
            stateProperties5.BorderColor = System.Drawing.Color.MediumVioletRed;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordTxt.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.passwordTxt.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.Fuchsia;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordTxt.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.SystemColors.ControlText;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordTxt.OnIdleState = stateProperties8;
            this.passwordTxt.PasswordChar = '\0';
            this.passwordTxt.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.passwordTxt.PlaceholderText = "password";
            this.passwordTxt.ReadOnly = false;
            this.passwordTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTxt.SelectedText = "";
            this.passwordTxt.SelectionLength = 0;
            this.passwordTxt.SelectionStart = 0;
            this.passwordTxt.ShortcutsEnabled = true;
            this.passwordTxt.Size = new System.Drawing.Size(192, 35);
            this.passwordTxt.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.passwordTxt.TabIndex = 2;
            this.passwordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTxt.TextMarginBottom = 0;
            this.passwordTxt.TextMarginLeft = 5;
            this.passwordTxt.TextMarginTop = 0;
            this.passwordTxt.TextPlaceholder = "password";
            this.passwordTxt.UseSystemPasswordChar = false;
            this.passwordTxt.WordWrap = true;
            this.passwordTxt.DoubleClick += new System.EventHandler(this.userNameTxt_DoubleClick);
            // 
            // logClose
            // 
            this.logClose.AutoSize = true;
            this.logClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logClose.Font = new System.Drawing.Font("Copperplate Gothic Bold", 16F);
            this.logClose.ForeColor = System.Drawing.Color.Crimson;
            this.logClose.Location = new System.Drawing.Point(532, -1);
            this.logClose.Name = "logClose";
            this.logClose.Size = new System.Drawing.Size(29, 26);
            this.logClose.TabIndex = 7;
            this.logClose.Text = "X";
            this.logClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logClose.Click += new System.EventHandler(this.logClose_Click);
            // 
            // showPassCheckBox
            // 
            this.showPassCheckBox.AutoSize = true;
            this.showPassCheckBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPassCheckBox.Location = new System.Drawing.Point(301, 172);
            this.showPassCheckBox.Name = "showPassCheckBox";
            this.showPassCheckBox.Size = new System.Drawing.Size(127, 21);
            this.showPassCheckBox.TabIndex = 3;
            this.showPassCheckBox.Text = "Show Password";
            this.showPassCheckBox.UseVisualStyleBackColor = true;
            this.showPassCheckBox.CheckedChanged += new System.EventHandler(this.showPassCheckBox_CheckedChanged);
            // 
            // signUpLinkLabel
            // 
            this.signUpLinkLabel.AutoSize = true;
            this.signUpLinkLabel.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.signUpLinkLabel.Location = new System.Drawing.Point(300, 287);
            this.signUpLinkLabel.Name = "signUpLinkLabel";
            this.signUpLinkLabel.Size = new System.Drawing.Size(247, 19);
            this.signUpLinkLabel.TabIndex = 7;
            this.signUpLinkLabel.TabStop = true;
            this.signUpLinkLabel.Text = "don\'t have any account! Sign Up?";
            this.signUpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUpLinkLabel_LinkClicked);
            // 
            // roleCombo
            // 
            this.roleCombo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.roleCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roleCombo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleCombo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.roleCombo.FormattingEnabled = true;
            this.roleCombo.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.roleCombo.Items.AddRange(new object[] {
            "--Role Type--",
            "Admin",
            "Member"});
            this.roleCombo.Location = new System.Drawing.Point(424, 170);
            this.roleCombo.MaxDropDownItems = 5;
            this.roleCombo.Name = "roleCombo";
            this.roleCombo.Size = new System.Drawing.Size(103, 25);
            this.roleCombo.TabIndex = 4;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(560, 347);
            this.Controls.Add(this.roleCombo);
            this.Controls.Add(this.signUpLinkLabel);
            this.Controls.Add(this.showPassCheckBox);
            this.Controls.Add(this.logClose);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.forgotPassLinkLabel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login From";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel forgotPassLinkLabel;
        private System.Windows.Forms.Button loginBtn;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox userNameTxt;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox passwordTxt;
        private System.Windows.Forms.Label logClose;
        private System.Windows.Forms.CheckBox showPassCheckBox;
        private System.Windows.Forms.LinkLabel signUpLinkLabel;
        private System.Windows.Forms.ComboBox roleCombo;
    }
}

