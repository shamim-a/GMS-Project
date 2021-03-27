
namespace Gym_Management_System
{
    partial class AddMemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMemberForm));
            this.actErrorLbl = new System.Windows.Forms.Label();
            this.addMemResBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.memGenderCombo = new System.Windows.Forms.ComboBox();
            this.monthlyAmnTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newMemClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.memberAgeTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.memTimeCombo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.memBackBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameErrorLbl = new System.Windows.Forms.Label();
            this.addressTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.memMobileNo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.memLastNameTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.memFirstNameTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.memEmailTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.signOutBtn = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signOutBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // actErrorLbl
            // 
            this.actErrorLbl.AutoSize = true;
            this.actErrorLbl.Font = new System.Drawing.Font("Tahoma", 13F);
            this.actErrorLbl.ForeColor = System.Drawing.Color.Firebrick;
            this.actErrorLbl.Location = new System.Drawing.Point(321, 199);
            this.actErrorLbl.Name = "actErrorLbl";
            this.actErrorLbl.Size = new System.Drawing.Size(20, 22);
            this.actErrorLbl.TabIndex = 35;
            this.actErrorLbl.Text = "*";
            this.actErrorLbl.Visible = false;
            // 
            // addMemResBtn
            // 
            this.addMemResBtn.BackColor = System.Drawing.Color.Crimson;
            this.addMemResBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMemResBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemResBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemResBtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.addMemResBtn.Location = new System.Drawing.Point(294, 393);
            this.addMemResBtn.Name = "addMemResBtn";
            this.addMemResBtn.Size = new System.Drawing.Size(80, 30);
            this.addMemResBtn.TabIndex = 10;
            this.addMemResBtn.Text = "RESET";
            this.addMemResBtn.UseVisualStyleBackColor = false;
            this.addMemResBtn.Click += new System.EventHandler(this.addMemResBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Crimson;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.saveBtn.Location = new System.Drawing.Point(204, 393);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(80, 30);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // memGenderCombo
            // 
            this.memGenderCombo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.memGenderCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.memGenderCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.memGenderCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.memGenderCombo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memGenderCombo.FormattingEnabled = true;
            this.memGenderCombo.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.memGenderCombo.Items.AddRange(new object[] {
            "--Select--",
            "Male",
            "Female",
            "Others"});
            this.memGenderCombo.Location = new System.Drawing.Point(259, 236);
            this.memGenderCombo.MaxDropDownItems = 5;
            this.memGenderCombo.Name = "memGenderCombo";
            this.memGenderCombo.Size = new System.Drawing.Size(161, 25);
            this.memGenderCombo.TabIndex = 5;
            // 
            // monthlyAmnTxt
            // 
            this.monthlyAmnTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.monthlyAmnTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.monthlyAmnTxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.monthlyAmnTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.monthlyAmnTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyAmnTxt.ForeColor = System.Drawing.Color.Black;
            this.monthlyAmnTxt.HintForeColor = System.Drawing.Color.Gray;
            this.monthlyAmnTxt.HintText = "";
            this.monthlyAmnTxt.isPassword = false;
            this.monthlyAmnTxt.LineFocusedColor = System.Drawing.Color.SlateBlue;
            this.monthlyAmnTxt.LineIdleColor = System.Drawing.Color.DarkBlue;
            this.monthlyAmnTxt.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.monthlyAmnTxt.LineThickness = 4;
            this.monthlyAmnTxt.Location = new System.Drawing.Point(464, 226);
            this.monthlyAmnTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.monthlyAmnTxt.MaxLength = 32767;
            this.monthlyAmnTxt.Name = "monthlyAmnTxt";
            this.monthlyAmnTxt.Size = new System.Drawing.Size(160, 35);
            this.monthlyAmnTxt.TabIndex = 6;
            this.monthlyAmnTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(460, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "Monthly Amount";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(261, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Gender";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(268, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "ADD NEW MEMBER";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newMemClose
            // 
            this.newMemClose.AutoSize = true;
            this.newMemClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newMemClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newMemClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newMemClose.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20F);
            this.newMemClose.ForeColor = System.Drawing.Color.Crimson;
            this.newMemClose.Location = new System.Drawing.Point(686, -1);
            this.newMemClose.Name = "newMemClose";
            this.newMemClose.Size = new System.Drawing.Size(35, 32);
            this.newMemClose.TabIndex = 16;
            this.newMemClose.Text = "X";
            this.newMemClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.newMemClose.Click += new System.EventHandler(this.newMemClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "FITNESS CENTER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(69, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "Age";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // memberAgeTxt
            // 
            this.memberAgeTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.memberAgeTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.memberAgeTxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.memberAgeTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.memberAgeTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberAgeTxt.ForeColor = System.Drawing.Color.Black;
            this.memberAgeTxt.HintForeColor = System.Drawing.Color.Gray;
            this.memberAgeTxt.HintText = "";
            this.memberAgeTxt.isPassword = false;
            this.memberAgeTxt.LineFocusedColor = System.Drawing.Color.SlateBlue;
            this.memberAgeTxt.LineIdleColor = System.Drawing.Color.DarkBlue;
            this.memberAgeTxt.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.memberAgeTxt.LineThickness = 4;
            this.memberAgeTxt.Location = new System.Drawing.Point(73, 226);
            this.memberAgeTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memberAgeTxt.MaxLength = 32767;
            this.memberAgeTxt.Name = "memberAgeTxt";
            this.memberAgeTxt.Size = new System.Drawing.Size(160, 35);
            this.memberAgeTxt.TabIndex = 4;
            this.memberAgeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(68, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 21);
            this.label11.TabIndex = 20;
            this.label11.Text = "Time";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // memTimeCombo
            // 
            this.memTimeCombo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.memTimeCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.memTimeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.memTimeCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.memTimeCombo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memTimeCombo.FormattingEnabled = true;
            this.memTimeCombo.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.memTimeCombo.Items.AddRange(new object[] {
            "--Select--",
            "6AM-8AM",
            "8AM-10AM",
            "6PM-8PM",
            "8PM-10PM"});
            this.memTimeCombo.Location = new System.Drawing.Point(72, 319);
            this.memTimeCombo.MaxDropDownItems = 5;
            this.memTimeCombo.Name = "memTimeCombo";
            this.memTimeCombo.Size = new System.Drawing.Size(161, 25);
            this.memTimeCombo.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label12.ForeColor = System.Drawing.Color.Firebrick;
            this.label12.Location = new System.Drawing.Point(120, 283);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 22);
            this.label12.TabIndex = 35;
            this.label12.Text = "*";
            this.label12.Visible = false;
            // 
            // memBackBtn
            // 
            this.memBackBtn.BackColor = System.Drawing.Color.Crimson;
            this.memBackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.memBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memBackBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memBackBtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.memBackBtn.Location = new System.Drawing.Point(384, 393);
            this.memBackBtn.Name = "memBackBtn";
            this.memBackBtn.Size = new System.Drawing.Size(80, 30);
            this.memBackBtn.TabIndex = 11;
            this.memBackBtn.Text = "BACK";
            this.memBackBtn.UseVisualStyleBackColor = false;
            this.memBackBtn.Click += new System.EventHandler(this.memBackBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Firebrick;
            this.label8.Location = new System.Drawing.Point(225, 453);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 18);
            this.label8.TabIndex = 37;
            this.label8.Text = "DevelopdByShamimAhammad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(354, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 22);
            this.label2.TabIndex = 46;
            this.label2.Text = "*";
            this.label2.Visible = false;
            // 
            // nameErrorLbl
            // 
            this.nameErrorLbl.AutoSize = true;
            this.nameErrorLbl.Font = new System.Drawing.Font("Tahoma", 13F);
            this.nameErrorLbl.ForeColor = System.Drawing.Color.Firebrick;
            this.nameErrorLbl.Location = new System.Drawing.Point(151, 130);
            this.nameErrorLbl.Name = "nameErrorLbl";
            this.nameErrorLbl.Size = new System.Drawing.Size(20, 22);
            this.nameErrorLbl.TabIndex = 47;
            this.nameErrorLbl.Text = "*";
            this.nameErrorLbl.Visible = false;
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
            this.addressTxt.Location = new System.Drawing.Point(464, 309);
            this.addressTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addressTxt.MaxLength = 32767;
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(172, 35);
            this.addressTxt.TabIndex = 8;
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
            this.memMobileNo.Location = new System.Drawing.Point(464, 149);
            this.memMobileNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memMobileNo.MaxLength = 32767;
            this.memMobileNo.Name = "memMobileNo";
            this.memMobileNo.Size = new System.Drawing.Size(160, 35);
            this.memMobileNo.TabIndex = 3;
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
            this.memLastNameTxt.Location = new System.Drawing.Point(259, 149);
            this.memLastNameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memLastNameTxt.MaxLength = 32767;
            this.memLastNameTxt.Name = "memLastNameTxt";
            this.memLastNameTxt.Size = new System.Drawing.Size(161, 35);
            this.memLastNameTxt.TabIndex = 2;
            this.memLastNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label13.Location = new System.Drawing.Point(460, 283);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 21);
            this.label13.TabIndex = 41;
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
            this.memFirstNameTxt.Location = new System.Drawing.Point(72, 149);
            this.memFirstNameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memFirstNameTxt.MaxLength = 32767;
            this.memFirstNameTxt.Name = "memFirstNameTxt";
            this.memFirstNameTxt.Size = new System.Drawing.Size(155, 35);
            this.memFirstNameTxt.TabIndex = 1;
            this.memFirstNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(460, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 42;
            this.label5.Text = "Mobile No.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(261, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 43;
            this.label4.Text = "Last Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(69, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 21);
            this.label9.TabIndex = 44;
            this.label9.Text = "First Name";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(76, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label14.Location = new System.Drawing.Point(255, 283);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 21);
            this.label14.TabIndex = 41;
            this.label14.Text = "Email";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // memEmailTxt
            // 
            this.memEmailTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.memEmailTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.memEmailTxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.memEmailTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.memEmailTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memEmailTxt.ForeColor = System.Drawing.Color.Black;
            this.memEmailTxt.HintForeColor = System.Drawing.SystemColors.GrayText;
            this.memEmailTxt.HintText = "";
            this.memEmailTxt.isPassword = false;
            this.memEmailTxt.LineFocusedColor = System.Drawing.Color.SlateBlue;
            this.memEmailTxt.LineIdleColor = System.Drawing.Color.DarkBlue;
            this.memEmailTxt.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.memEmailTxt.LineThickness = 4;
            this.memEmailTxt.Location = new System.Drawing.Point(259, 309);
            this.memEmailTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memEmailTxt.MaxLength = 32767;
            this.memEmailTxt.Name = "memEmailTxt";
            this.memEmailTxt.Size = new System.Drawing.Size(172, 35);
            this.memEmailTxt.TabIndex = 8;
            this.memEmailTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.memEmailTxt.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
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
            this.signOutBtn.TabIndex = 96;
            this.signOutBtn.TabStop = false;
            this.signOutBtn.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.signOutBtn.Click += new System.EventHandler(this.signOutBtn_Click);
            // 
            // AddMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.signOutBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameErrorLbl);
            this.Controls.Add(this.memEmailTxt);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.memMobileNo);
            this.Controls.Add(this.memLastNameTxt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.memFirstNameTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.actErrorLbl);
            this.Controls.Add(this.memBackBtn);
            this.Controls.Add(this.addMemResBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.memTimeCombo);
            this.Controls.Add(this.memGenderCombo);
            this.Controls.Add(this.monthlyAmnTxt);
            this.Controls.Add(this.memberAgeTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newMemClose);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMemberForm";
            this.Load += new System.EventHandler(this.AddMemberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signOutBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label actErrorLbl;
        private System.Windows.Forms.Button addMemResBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox memGenderCombo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox monthlyAmnTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label newMemClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox memberAgeTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox memTimeCombo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button memBackBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameErrorLbl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox addressTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox memMobileNo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox memLastNameTxt;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuMaterialTextbox memFirstNameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuMaterialTextbox memEmailTxt;
        private Bunifu.UI.WinForms.BunifuPictureBox signOutBtn;
    }
}