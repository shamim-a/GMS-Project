
namespace Gym_Management_System
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameErrorLbl = new System.Windows.Forms.Label();
            this.sendBtn = new System.Windows.Forms.Button();
            this.resEmailTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.resMobileNoTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.resFullNameTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emailErrorLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.rBackBtn = new System.Windows.Forms.Button();
            this.otpTxt = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.verifyCode = new System.Windows.Forms.GroupBox();
            this.VerifyBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.verifyCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20F);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(510, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "FITNESS CENTER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(169, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "RESET PASSWORD";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameErrorLbl
            // 
            this.nameErrorLbl.AutoSize = true;
            this.nameErrorLbl.Font = new System.Drawing.Font("Tahoma", 13F);
            this.nameErrorLbl.ForeColor = System.Drawing.Color.Firebrick;
            this.nameErrorLbl.Location = new System.Drawing.Point(126, 105);
            this.nameErrorLbl.Name = "nameErrorLbl";
            this.nameErrorLbl.Size = new System.Drawing.Size(20, 22);
            this.nameErrorLbl.TabIndex = 22;
            this.nameErrorLbl.Text = "*";
            this.nameErrorLbl.Visible = false;
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.Crimson;
            this.sendBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.sendBtn.Location = new System.Drawing.Point(51, 314);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(94, 30);
            this.sendBtn.TabIndex = 21;
            this.sendBtn.Text = "Send OTP";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // resEmailTxt
            // 
            this.resEmailTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.resEmailTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.resEmailTxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.resEmailTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resEmailTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resEmailTxt.ForeColor = System.Drawing.Color.Black;
            this.resEmailTxt.HintForeColor = System.Drawing.Color.Gray;
            this.resEmailTxt.HintText = "fit@info.com";
            this.resEmailTxt.isPassword = false;
            this.resEmailTxt.LineFocusedColor = System.Drawing.Color.SlateBlue;
            this.resEmailTxt.LineIdleColor = System.Drawing.Color.DarkBlue;
            this.resEmailTxt.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.resEmailTxt.LineThickness = 4;
            this.resEmailTxt.Location = new System.Drawing.Point(51, 265);
            this.resEmailTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resEmailTxt.MaxLength = 32767;
            this.resEmailTxt.Name = "resEmailTxt";
            this.resEmailTxt.Size = new System.Drawing.Size(203, 36);
            this.resEmailTxt.TabIndex = 20;
            this.resEmailTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // resMobileNoTxt
            // 
            this.resMobileNoTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.resMobileNoTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.resMobileNoTxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.resMobileNoTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resMobileNoTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resMobileNoTxt.ForeColor = System.Drawing.Color.Black;
            this.resMobileNoTxt.HintForeColor = System.Drawing.Color.Gray;
            this.resMobileNoTxt.HintText = "+880";
            this.resMobileNoTxt.isPassword = false;
            this.resMobileNoTxt.LineFocusedColor = System.Drawing.Color.SlateBlue;
            this.resMobileNoTxt.LineIdleColor = System.Drawing.Color.DarkBlue;
            this.resMobileNoTxt.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.resMobileNoTxt.LineThickness = 4;
            this.resMobileNoTxt.Location = new System.Drawing.Point(51, 194);
            this.resMobileNoTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resMobileNoTxt.MaxLength = 32767;
            this.resMobileNoTxt.Name = "resMobileNoTxt";
            this.resMobileNoTxt.Size = new System.Drawing.Size(203, 36);
            this.resMobileNoTxt.TabIndex = 16;
            this.resMobileNoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // resFullNameTxt
            // 
            this.resFullNameTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.resFullNameTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.resFullNameTxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.resFullNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resFullNameTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resFullNameTxt.ForeColor = System.Drawing.Color.Black;
            this.resFullNameTxt.HintForeColor = System.Drawing.Color.Gray;
            this.resFullNameTxt.HintText = "your name...";
            this.resFullNameTxt.isPassword = false;
            this.resFullNameTxt.LineFocusedColor = System.Drawing.Color.SlateBlue;
            this.resFullNameTxt.LineIdleColor = System.Drawing.Color.DarkBlue;
            this.resFullNameTxt.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.resFullNameTxt.LineThickness = 4;
            this.resFullNameTxt.Location = new System.Drawing.Point(51, 131);
            this.resFullNameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resFullNameTxt.MaxLength = 32767;
            this.resFullNameTxt.Name = "resFullNameTxt";
            this.resFullNameTxt.Size = new System.Drawing.Size(203, 36);
            this.resFullNameTxt.TabIndex = 15;
            this.resFullNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(51, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Email";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(51, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Mobile No.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(51, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Full Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailErrorLbl
            // 
            this.emailErrorLbl.AutoSize = true;
            this.emailErrorLbl.Font = new System.Drawing.Font("Tahoma", 13F);
            this.emailErrorLbl.ForeColor = System.Drawing.Color.Firebrick;
            this.emailErrorLbl.Location = new System.Drawing.Point(138, 174);
            this.emailErrorLbl.Name = "emailErrorLbl";
            this.emailErrorLbl.Size = new System.Drawing.Size(20, 22);
            this.emailErrorLbl.TabIndex = 23;
            this.emailErrorLbl.Text = "*";
            this.emailErrorLbl.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Firebrick;
            this.label10.Location = new System.Drawing.Point(134, 406);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 18);
            this.label10.TabIndex = 36;
            this.label10.Text = "DevelopdByShamimAhammad";
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Crimson;
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.clearBtn.Location = new System.Drawing.Point(160, 314);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(94, 30);
            this.clearBtn.TabIndex = 37;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(40, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(94, 77);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            // 
            // rBackBtn
            // 
            this.rBackBtn.BackColor = System.Drawing.Color.Crimson;
            this.rBackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBackBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBackBtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.rBackBtn.Location = new System.Drawing.Point(91, 134);
            this.rBackBtn.Name = "rBackBtn";
            this.rBackBtn.Size = new System.Drawing.Size(68, 28);
            this.rBackBtn.TabIndex = 50;
            this.rBackBtn.Text = "Back";
            this.rBackBtn.UseVisualStyleBackColor = false;
            this.rBackBtn.Click += new System.EventHandler(this.rBackBtn_Click);
            // 
            // otpTxt
            // 
            this.otpTxt.AcceptsReturn = false;
            this.otpTxt.AcceptsTab = false;
            this.otpTxt.AnimationSpeed = 200;
            this.otpTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.otpTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.otpTxt.BackColor = System.Drawing.Color.Transparent;
            this.otpTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("otpTxt.BackgroundImage")));
            this.otpTxt.BorderColorActive = System.Drawing.Color.MediumVioletRed;
            this.otpTxt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.otpTxt.BorderColorHover = System.Drawing.Color.Fuchsia;
            this.otpTxt.BorderColorIdle = System.Drawing.Color.Silver;
            this.otpTxt.BorderRadius = 1;
            this.otpTxt.BorderThickness = 1;
            this.otpTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.otpTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.otpTxt.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.otpTxt.DefaultText = "";
            this.otpTxt.FillColor = System.Drawing.Color.White;
            this.otpTxt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.otpTxt.HideSelection = true;
            this.otpTxt.IconLeft = null;
            this.otpTxt.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.otpTxt.IconPadding = 10;
            this.otpTxt.IconRight = null;
            this.otpTxt.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.otpTxt.Lines = new string[0];
            this.otpTxt.Location = new System.Drawing.Point(17, 90);
            this.otpTxt.MaxLength = 32767;
            this.otpTxt.MinimumSize = new System.Drawing.Size(100, 35);
            this.otpTxt.Modified = false;
            this.otpTxt.Multiline = false;
            this.otpTxt.Name = "otpTxt";
            stateProperties9.BorderColor = System.Drawing.Color.MediumVioletRed;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.otpTxt.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.Empty;
            stateProperties10.FillColor = System.Drawing.Color.White;
            stateProperties10.ForeColor = System.Drawing.Color.Empty;
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.otpTxt.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.Fuchsia;
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.otpTxt.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.SystemColors.ControlText;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.otpTxt.OnIdleState = stateProperties12;
            this.otpTxt.PasswordChar = '\0';
            this.otpTxt.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.otpTxt.PlaceholderText = "OTP Code";
            this.otpTxt.ReadOnly = false;
            this.otpTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.otpTxt.SelectedText = "";
            this.otpTxt.SelectionLength = 0;
            this.otpTxt.SelectionStart = 0;
            this.otpTxt.ShortcutsEnabled = true;
            this.otpTxt.Size = new System.Drawing.Size(205, 35);
            this.otpTxt.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.otpTxt.TabIndex = 53;
            this.otpTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.otpTxt.TextMarginBottom = 0;
            this.otpTxt.TextMarginLeft = 5;
            this.otpTxt.TextMarginTop = 0;
            this.otpTxt.TextPlaceholder = "OTP Code";
            this.otpTxt.UseSystemPasswordChar = false;
            this.otpTxt.WordWrap = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label9.ForeColor = System.Drawing.Color.Firebrick;
            this.label9.Location = new System.Drawing.Point(74, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 22);
            this.label9.TabIndex = 52;
            this.label9.Text = "*";
            this.label9.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(17, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 51;
            this.label6.Text = "CODE";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // verifyCode
            // 
            this.verifyCode.Controls.Add(this.label6);
            this.verifyCode.Controls.Add(this.VerifyBtn);
            this.verifyCode.Controls.Add(this.rBackBtn);
            this.verifyCode.Controls.Add(this.otpTxt);
            this.verifyCode.Controls.Add(this.label9);
            this.verifyCode.Location = new System.Drawing.Point(284, 105);
            this.verifyCode.Name = "verifyCode";
            this.verifyCode.Size = new System.Drawing.Size(248, 239);
            this.verifyCode.TabIndex = 54;
            this.verifyCode.TabStop = false;
            this.verifyCode.Text = "Verify Code";
            // 
            // VerifyBtn
            // 
            this.VerifyBtn.BackColor = System.Drawing.Color.Crimson;
            this.VerifyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VerifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerifyBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyBtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.VerifyBtn.Location = new System.Drawing.Point(17, 134);
            this.VerifyBtn.Name = "VerifyBtn";
            this.VerifyBtn.Size = new System.Drawing.Size(68, 28);
            this.VerifyBtn.TabIndex = 50;
            this.VerifyBtn.Text = "Verify";
            this.VerifyBtn.UseVisualStyleBackColor = false;
            this.VerifyBtn.Click += new System.EventHandler(this.VerifyBtn_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(544, 433);
            this.Controls.Add(this.verifyCode);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nameErrorLbl);
            this.Controls.Add(this.emailErrorLbl);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.resEmailTxt);
            this.Controls.Add(this.resMobileNoTxt);
            this.Controls.Add(this.resFullNameTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.verifyCode.ResumeLayout(false);
            this.verifyCode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nameErrorLbl;
        private System.Windows.Forms.Button sendBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox resEmailTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox resMobileNoTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox resFullNameTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label emailErrorLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button rBackBtn;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox otpTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox verifyCode;
        private System.Windows.Forms.Button VerifyBtn;
    }
}