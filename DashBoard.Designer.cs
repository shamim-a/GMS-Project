
namespace Gym_Management_System
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.signOutBtn = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ViewBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EditProfileBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PayBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.logClose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signOutBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MintCream;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(704, 441);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.logClose);
            this.bunifuGradientPanel1.Controls.Add(this.ViewBtn);
            this.bunifuGradientPanel1.Controls.Add(this.PayBtn);
            this.bunifuGradientPanel1.Controls.Add(this.EditProfileBtn);
            this.bunifuGradientPanel1.Controls.Add(this.signOutBtn);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(1, 1);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(703, 73);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // signOutBtn
            // 
            this.signOutBtn.AllowFocused = false;
            this.signOutBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signOutBtn.BorderRadius = 0;
            this.signOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("signOutBtn.Image")));
            this.signOutBtn.IsCircle = false;
            this.signOutBtn.Location = new System.Drawing.Point(666, 36);
            this.signOutBtn.Margin = new System.Windows.Forms.Padding(0);
            this.signOutBtn.Name = "signOutBtn";
            this.signOutBtn.Size = new System.Drawing.Size(37, 37);
            this.signOutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.signOutBtn.TabIndex = 98;
            this.signOutBtn.TabStop = false;
            this.signOutBtn.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.signOutBtn.Click += new System.EventHandler(this.signOutBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 97;
            this.pictureBox2.TabStop = false;
            // 
            // ViewBtn
            // 
            this.ViewBtn.ActiveBorderThickness = 1;
            this.ViewBtn.ActiveCornerRadius = 25;
            this.ViewBtn.ActiveFillColor = System.Drawing.Color.MediumVioletRed;
            this.ViewBtn.ActiveForecolor = System.Drawing.Color.White;
            this.ViewBtn.ActiveLineColor = System.Drawing.Color.MidnightBlue;
            this.ViewBtn.BackColor = System.Drawing.Color.MintCream;
            this.ViewBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ViewBtn.BackgroundImage")));
            this.ViewBtn.ButtonText = "View";
            this.ViewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewBtn.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.ViewBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.ViewBtn.IdleBorderThickness = 1;
            this.ViewBtn.IdleCornerRadius = 26;
            this.ViewBtn.IdleFillColor = System.Drawing.Color.White;
            this.ViewBtn.IdleForecolor = System.Drawing.Color.Crimson;
            this.ViewBtn.IdleLineColor = System.Drawing.Color.Crimson;
            this.ViewBtn.Location = new System.Drawing.Point(360, 9);
            this.ViewBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(121, 55);
            this.ViewBtn.TabIndex = 3;
            this.ViewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditProfileBtn
            // 
            this.EditProfileBtn.ActiveBorderThickness = 1;
            this.EditProfileBtn.ActiveCornerRadius = 25;
            this.EditProfileBtn.ActiveFillColor = System.Drawing.Color.MediumVioletRed;
            this.EditProfileBtn.ActiveForecolor = System.Drawing.Color.White;
            this.EditProfileBtn.ActiveLineColor = System.Drawing.Color.MidnightBlue;
            this.EditProfileBtn.BackColor = System.Drawing.Color.MintCream;
            this.EditProfileBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditProfileBtn.BackgroundImage")));
            this.EditProfileBtn.ButtonText = "Edit Profile";
            this.EditProfileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditProfileBtn.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.EditProfileBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.EditProfileBtn.IdleBorderThickness = 1;
            this.EditProfileBtn.IdleCornerRadius = 26;
            this.EditProfileBtn.IdleFillColor = System.Drawing.Color.White;
            this.EditProfileBtn.IdleForecolor = System.Drawing.Color.Crimson;
            this.EditProfileBtn.IdleLineColor = System.Drawing.Color.Crimson;
            this.EditProfileBtn.Location = new System.Drawing.Point(225, 9);
            this.EditProfileBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditProfileBtn.Name = "EditProfileBtn";
            this.EditProfileBtn.Size = new System.Drawing.Size(127, 55);
            this.EditProfileBtn.TabIndex = 4;
            this.EditProfileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditProfileBtn.Click += new System.EventHandler(this.EditProfileBtn_Click);
            // 
            // PayBtn
            // 
            this.PayBtn.ActiveBorderThickness = 1;
            this.PayBtn.ActiveCornerRadius = 25;
            this.PayBtn.ActiveFillColor = System.Drawing.Color.MediumVioletRed;
            this.PayBtn.ActiveForecolor = System.Drawing.Color.White;
            this.PayBtn.ActiveLineColor = System.Drawing.Color.MidnightBlue;
            this.PayBtn.BackColor = System.Drawing.Color.MintCream;
            this.PayBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PayBtn.BackgroundImage")));
            this.PayBtn.ButtonText = "Payment";
            this.PayBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PayBtn.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.PayBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.PayBtn.IdleBorderThickness = 1;
            this.PayBtn.IdleCornerRadius = 26;
            this.PayBtn.IdleFillColor = System.Drawing.Color.White;
            this.PayBtn.IdleForecolor = System.Drawing.Color.Crimson;
            this.PayBtn.IdleLineColor = System.Drawing.Color.Crimson;
            this.PayBtn.Location = new System.Drawing.Point(489, 9);
            this.PayBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(127, 55);
            this.PayBtn.TabIndex = 4;
            this.PayBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logClose
            // 
            this.logClose.AutoSize = true;
            this.logClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logClose.Font = new System.Drawing.Font("Copperplate Gothic Bold", 16F);
            this.logClose.ForeColor = System.Drawing.Color.Crimson;
            this.logClose.Location = new System.Drawing.Point(675, -1);
            this.logClose.Name = "logClose";
            this.logClose.Size = new System.Drawing.Size(29, 26);
            this.logClose.TabIndex = 9;
            this.logClose.Text = "X";
            this.logClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logClose.Click += new System.EventHandler(this.logClose_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signOutBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.UI.WinForms.BunifuPictureBox signOutBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 ViewBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 PayBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 EditProfileBtn;
        private System.Windows.Forms.Label logClose;
    }
}