
namespace Gym_Management_System
{
    partial class Profile_Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile_Update));
            this.label3 = new System.Windows.Forms.Label();
            this.UpdlClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameErrorLbl = new System.Windows.Forms.Label();
            this.memEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.addressTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.memMobileNo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.memLastNameTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.memFirstNameTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.actErrorLbl = new System.Windows.Forms.Label();
            this.timeCombo = new System.Windows.Forms.ComboBox();
            this.genderCombo = new System.Windows.Forms.ComboBox();
            this.memAmountTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.memAgeTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.signOutBtn = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.signOutBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(279, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 23);
            this.label3.TabIndex = 43;
            this.label3.Text = "Profile Update";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdlClose
            // 
            this.UpdlClose.AutoSize = true;
            this.UpdlClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpdlClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdlClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdlClose.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20F);
            this.UpdlClose.ForeColor = System.Drawing.Color.Crimson;
            this.UpdlClose.Location = new System.Drawing.Point(686, -1);
            this.UpdlClose.Name = "UpdlClose";
            this.UpdlClose.Size = new System.Drawing.Size(35, 32);
            this.UpdlClose.TabIndex = 42;
            this.UpdlClose.Text = "X";
            this.UpdlClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(254, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 28);
            this.label1.TabIndex = 41;
            this.label1.Text = "FITNESS CENTER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Crimson;
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.updateBtn.Location = new System.Drawing.Point(261, 380);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(80, 35);
            this.updateBtn.TabIndex = 82;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(352, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 22);
            this.label2.TabIndex = 104;
            this.label2.Text = "*";
            this.label2.Visible = false;
            // 
            // nameErrorLbl
            // 
            this.nameErrorLbl.AutoSize = true;
            this.nameErrorLbl.Font = new System.Drawing.Font("Tahoma", 13F);
            this.nameErrorLbl.ForeColor = System.Drawing.Color.Firebrick;
            this.nameErrorLbl.Location = new System.Drawing.Point(149, 140);
            this.nameErrorLbl.Name = "nameErrorLbl";
            this.nameErrorLbl.Size = new System.Drawing.Size(20, 22);
            this.nameErrorLbl.TabIndex = 105;
            this.nameErrorLbl.Text = "*";
            this.nameErrorLbl.Visible = false;
            // 
            // memEmail
            // 
            this.memEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.memEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.memEmail.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.memEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.memEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memEmail.ForeColor = System.Drawing.Color.Black;
            this.memEmail.HintForeColor = System.Drawing.SystemColors.GrayText;
            this.memEmail.HintText = "";
            this.memEmail.isPassword = false;
            this.memEmail.LineFocusedColor = System.Drawing.Color.SlateBlue;
            this.memEmail.LineIdleColor = System.Drawing.Color.DarkBlue;
            this.memEmail.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.memEmail.LineThickness = 4;
            this.memEmail.Location = new System.Drawing.Point(257, 319);
            this.memEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memEmail.MaxLength = 32767;
            this.memEmail.Name = "memEmail";
            this.memEmail.Size = new System.Drawing.Size(172, 35);
            this.memEmail.TabIndex = 91;
            this.memEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // addressTxt
            // 
            this.addressTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.addressTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.addressTxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.addressTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTxt.ForeColor = System.Drawing.Color.Black;
            this.addressTxt.HintForeColor = System.Drawing.SystemColors.GrayText;
            this.addressTxt.HintText = "";
            this.addressTxt.isPassword = false;
            this.addressTxt.LineFocusedColor = System.Drawing.Color.SlateBlue;
            this.addressTxt.LineIdleColor = System.Drawing.Color.DarkBlue;
            this.addressTxt.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.addressTxt.LineThickness = 4;
            this.addressTxt.Location = new System.Drawing.Point(462, 319);
            this.addressTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addressTxt.MaxLength = 32767;
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(172, 35);
            this.addressTxt.TabIndex = 92;
            this.addressTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // memMobileNo
            // 
            this.memMobileNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.memMobileNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.memMobileNo.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.memMobileNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.memMobileNo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memMobileNo.ForeColor = System.Drawing.Color.Black;
            this.memMobileNo.HintForeColor = System.Drawing.Color.Gray;
            this.memMobileNo.HintText = "+880";
            this.memMobileNo.isPassword = false;
            this.memMobileNo.LineFocusedColor = System.Drawing.Color.SlateBlue;
            this.memMobileNo.LineIdleColor = System.Drawing.Color.DarkBlue;
            this.memMobileNo.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.memMobileNo.LineThickness = 4;
            this.memMobileNo.Location = new System.Drawing.Point(462, 159);
            this.memMobileNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memMobileNo.MaxLength = 32767;
            this.memMobileNo.Name = "memMobileNo";
            this.memMobileNo.Size = new System.Drawing.Size(160, 35);
            this.memMobileNo.TabIndex = 86;
            this.memMobileNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // memLastNameTxt
            // 
            this.memLastNameTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.memLastNameTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.memLastNameTxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.memLastNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.memLastNameTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memLastNameTxt.ForeColor = System.Drawing.Color.Black;
            this.memLastNameTxt.HintForeColor = System.Drawing.SystemColors.GrayText;
            this.memLastNameTxt.HintText = "Last Name";
            this.memLastNameTxt.isPassword = false;
            this.memLastNameTxt.LineFocusedColor = System.Drawing.Color.SlateBlue;
            this.memLastNameTxt.LineIdleColor = System.Drawing.Color.DarkBlue;
            this.memLastNameTxt.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.memLastNameTxt.LineThickness = 4;
            this.memLastNameTxt.Location = new System.Drawing.Point(259, 159);
            this.memLastNameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memLastNameTxt.MaxLength = 32767;
            this.memLastNameTxt.Name = "memLastNameTxt";
            this.memLastNameTxt.Size = new System.Drawing.Size(161, 35);
            this.memLastNameTxt.TabIndex = 85;
            this.memLastNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label14.Location = new System.Drawing.Point(257, 293);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 21);
            this.label14.TabIndex = 99;
            this.label14.Text = "Email";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label13.Location = new System.Drawing.Point(462, 293);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 21);
            this.label13.TabIndex = 100;
            this.label13.Text = "Address";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // memFirstNameTxt
            // 
            this.memFirstNameTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.memFirstNameTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.memFirstNameTxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.memFirstNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.memFirstNameTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memFirstNameTxt.ForeColor = System.Drawing.Color.Black;
            this.memFirstNameTxt.HintForeColor = System.Drawing.SystemColors.GrayText;
            this.memFirstNameTxt.HintText = "First Name";
            this.memFirstNameTxt.isPassword = false;
            this.memFirstNameTxt.LineFocusedColor = System.Drawing.Color.SlateBlue;
            this.memFirstNameTxt.LineIdleColor = System.Drawing.Color.DarkBlue;
            this.memFirstNameTxt.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.memFirstNameTxt.LineThickness = 4;
            this.memFirstNameTxt.Location = new System.Drawing.Point(70, 159);
            this.memFirstNameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memFirstNameTxt.MaxLength = 32767;
            this.memFirstNameTxt.Name = "memFirstNameTxt";
            this.memFirstNameTxt.Size = new System.Drawing.Size(155, 35);
            this.memFirstNameTxt.TabIndex = 84;
            this.memFirstNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(462, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 101;
            this.label5.Text = "Mobile No.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(259, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 102;
            this.label4.Text = "Last Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(70, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 21);
            this.label9.TabIndex = 103;
            this.label9.Text = "First Name";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label12.ForeColor = System.Drawing.Color.Firebrick;
            this.label12.Location = new System.Drawing.Point(118, 293);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 22);
            this.label12.TabIndex = 97;
            this.label12.Text = "*";
            this.label12.Visible = false;
            // 
            // actErrorLbl
            // 
            this.actErrorLbl.AutoSize = true;
            this.actErrorLbl.Font = new System.Drawing.Font("Tahoma", 13F);
            this.actErrorLbl.ForeColor = System.Drawing.Color.Firebrick;
            this.actErrorLbl.Location = new System.Drawing.Point(319, 209);
            this.actErrorLbl.Name = "actErrorLbl";
            this.actErrorLbl.Size = new System.Drawing.Size(20, 22);
            this.actErrorLbl.TabIndex = 98;
            this.actErrorLbl.Text = "*";
            this.actErrorLbl.Visible = false;
            // 
            // timeCombo
            // 
            this.timeCombo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.timeCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.timeCombo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCombo.FormattingEnabled = true;
            this.timeCombo.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.timeCombo.Items.AddRange(new object[] {
            "--Select--",
            "6AM-8AM",
            "8AM-10AM",
            "6PM-8PM",
            "8PM-10PM"});
            this.timeCombo.Location = new System.Drawing.Point(66, 329);
            this.timeCombo.MaxDropDownItems = 5;
            this.timeCombo.Name = "timeCombo";
            this.timeCombo.Size = new System.Drawing.Size(161, 25);
            this.timeCombo.TabIndex = 90;
            // 
            // genderCombo
            // 
            this.genderCombo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.genderCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genderCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.genderCombo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderCombo.FormattingEnabled = true;
            this.genderCombo.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.genderCombo.Items.AddRange(new object[] {
            "--Select--",
            "Male",
            "Female",
            "Others"});
            this.genderCombo.Location = new System.Drawing.Point(257, 246);
            this.genderCombo.MaxDropDownItems = 5;
            this.genderCombo.Name = "genderCombo";
            this.genderCombo.Size = new System.Drawing.Size(161, 25);
            this.genderCombo.TabIndex = 88;
            // 
            // memAmountTxt
            // 
            this.memAmountTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.memAmountTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.memAmountTxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.memAmountTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.memAmountTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memAmountTxt.ForeColor = System.Drawing.Color.Black;
            this.memAmountTxt.HintForeColor = System.Drawing.Color.Gray;
            this.memAmountTxt.HintText = "";
            this.memAmountTxt.isPassword = false;
            this.memAmountTxt.LineFocusedColor = System.Drawing.Color.SlateBlue;
            this.memAmountTxt.LineIdleColor = System.Drawing.Color.DarkBlue;
            this.memAmountTxt.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.memAmountTxt.LineThickness = 4;
            this.memAmountTxt.Location = new System.Drawing.Point(458, 236);
            this.memAmountTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memAmountTxt.MaxLength = 32767;
            this.memAmountTxt.Name = "memAmountTxt";
            this.memAmountTxt.Size = new System.Drawing.Size(164, 35);
            this.memAmountTxt.TabIndex = 89;
            this.memAmountTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // memAgeTxt
            // 
            this.memAgeTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.memAgeTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.memAgeTxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.memAgeTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.memAgeTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memAgeTxt.ForeColor = System.Drawing.Color.Black;
            this.memAgeTxt.HintForeColor = System.Drawing.Color.Gray;
            this.memAgeTxt.HintText = "";
            this.memAgeTxt.isPassword = false;
            this.memAgeTxt.LineFocusedColor = System.Drawing.Color.SlateBlue;
            this.memAgeTxt.LineIdleColor = System.Drawing.Color.DarkBlue;
            this.memAgeTxt.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.memAgeTxt.LineThickness = 4;
            this.memAgeTxt.Location = new System.Drawing.Point(71, 236);
            this.memAgeTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memAgeTxt.MaxLength = 32767;
            this.memAgeTxt.Name = "memAgeTxt";
            this.memAgeTxt.Size = new System.Drawing.Size(160, 35);
            this.memAgeTxt.TabIndex = 87;
            this.memAgeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(458, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 21);
            this.label7.TabIndex = 96;
            this.label7.Text = "Monthly Amount";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(71, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 21);
            this.label10.TabIndex = 95;
            this.label10.Text = "Age";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(66, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 21);
            this.label11.TabIndex = 93;
            this.label11.Text = "Time";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(257, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 21);
            this.label6.TabIndex = 94;
            this.label6.Text = "Gender";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Crimson;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.backBtn.Location = new System.Drawing.Point(351, 380);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(80, 35);
            this.backBtn.TabIndex = 83;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Firebrick;
            this.label8.Location = new System.Drawing.Point(237, 453);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 18);
            this.label8.TabIndex = 106;
            this.label8.Text = "DevelopdByShamimAhammad";
            // 
            // signOutBtn
            // 
            this.signOutBtn.AllowFocused = false;
            this.signOutBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signOutBtn.BorderRadius = 0;
            this.signOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("signOutBtn.Image")));
            this.signOutBtn.IsCircle = false;
            this.signOutBtn.Location = new System.Drawing.Point(-1, -1);
            this.signOutBtn.Margin = new System.Windows.Forms.Padding(0);
            this.signOutBtn.Name = "signOutBtn";
            this.signOutBtn.Size = new System.Drawing.Size(37, 37);
            this.signOutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.signOutBtn.TabIndex = 107;
            this.signOutBtn.TabStop = false;
            this.signOutBtn.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.signOutBtn.Click += new System.EventHandler(this.signOutBtn_Click);
            // 
            // Profile_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.signOutBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameErrorLbl);
            this.Controls.Add(this.memEmail);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.memMobileNo);
            this.Controls.Add(this.memLastNameTxt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.memFirstNameTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.actErrorLbl);
            this.Controls.Add(this.timeCombo);
            this.Controls.Add(this.genderCombo);
            this.Controls.Add(this.memAmountTxt);
            this.Controls.Add(this.memAgeTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UpdlClose);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile_Update";
            ((System.ComponentModel.ISupportInitialize)(this.signOutBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label UpdlClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameErrorLbl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox memEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox addressTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox memMobileNo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox memLastNameTxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuMaterialTextbox memFirstNameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label actErrorLbl;
        private System.Windows.Forms.ComboBox timeCombo;
        private System.Windows.Forms.ComboBox genderCombo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox memAmountTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox memAgeTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label8;
        private Bunifu.UI.WinForms.BunifuPictureBox signOutBtn;
    }
}