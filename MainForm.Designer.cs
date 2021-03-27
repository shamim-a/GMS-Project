
namespace Gym_Management_System
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logClose = new System.Windows.Forms.Label();
            this.mainViewBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.mainUpdateBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.mainPayBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.mainAddMemberBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label10 = new System.Windows.Forms.Label();
            this.signOutBtn = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signOutBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MintCream;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(720, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.logClose);
            this.panel1.Controls.Add(this.mainViewBtn);
            this.panel1.Controls.Add(this.mainUpdateBtn);
            this.panel1.Controls.Add(this.mainPayBtn);
            this.panel1.Controls.Add(this.mainAddMemberBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 55);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(54, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // logClose
            // 
            this.logClose.AutoSize = true;
            this.logClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logClose.Font = new System.Drawing.Font("Copperplate Gothic Bold", 16F);
            this.logClose.ForeColor = System.Drawing.Color.Crimson;
            this.logClose.Location = new System.Drawing.Point(692, -1);
            this.logClose.Name = "logClose";
            this.logClose.Size = new System.Drawing.Size(29, 26);
            this.logClose.TabIndex = 8;
            this.logClose.Text = "X";
            this.logClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logClose.Click += new System.EventHandler(this.logClose_Click);
            // 
            // mainViewBtn
            // 
            this.mainViewBtn.ActiveBorderThickness = 1;
            this.mainViewBtn.ActiveCornerRadius = 25;
            this.mainViewBtn.ActiveFillColor = System.Drawing.Color.MediumVioletRed;
            this.mainViewBtn.ActiveForecolor = System.Drawing.Color.White;
            this.mainViewBtn.ActiveLineColor = System.Drawing.Color.MidnightBlue;
            this.mainViewBtn.BackColor = System.Drawing.Color.White;
            this.mainViewBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainViewBtn.BackgroundImage")));
            this.mainViewBtn.ButtonText = "View";
            this.mainViewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainViewBtn.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.mainViewBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.mainViewBtn.IdleBorderThickness = 1;
            this.mainViewBtn.IdleCornerRadius = 26;
            this.mainViewBtn.IdleFillColor = System.Drawing.Color.White;
            this.mainViewBtn.IdleForecolor = System.Drawing.Color.Crimson;
            this.mainViewBtn.IdleLineColor = System.Drawing.Color.Crimson;
            this.mainViewBtn.Location = new System.Drawing.Point(452, 5);
            this.mainViewBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainViewBtn.Name = "mainViewBtn";
            this.mainViewBtn.Size = new System.Drawing.Size(107, 38);
            this.mainViewBtn.TabIndex = 2;
            this.mainViewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainViewBtn.Click += new System.EventHandler(this.mainViewBtn_Click);
            // 
            // mainUpdateBtn
            // 
            this.mainUpdateBtn.ActiveBorderThickness = 1;
            this.mainUpdateBtn.ActiveCornerRadius = 25;
            this.mainUpdateBtn.ActiveFillColor = System.Drawing.Color.MediumVioletRed;
            this.mainUpdateBtn.ActiveForecolor = System.Drawing.Color.White;
            this.mainUpdateBtn.ActiveLineColor = System.Drawing.Color.MidnightBlue;
            this.mainUpdateBtn.BackColor = System.Drawing.Color.White;
            this.mainUpdateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainUpdateBtn.BackgroundImage")));
            this.mainUpdateBtn.ButtonText = "Update/Delete";
            this.mainUpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainUpdateBtn.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.mainUpdateBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.mainUpdateBtn.IdleBorderThickness = 1;
            this.mainUpdateBtn.IdleCornerRadius = 26;
            this.mainUpdateBtn.IdleFillColor = System.Drawing.Color.White;
            this.mainUpdateBtn.IdleForecolor = System.Drawing.Color.Crimson;
            this.mainUpdateBtn.IdleLineColor = System.Drawing.Color.Crimson;
            this.mainUpdateBtn.Location = new System.Drawing.Point(306, 5);
            this.mainUpdateBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainUpdateBtn.Name = "mainUpdateBtn";
            this.mainUpdateBtn.Size = new System.Drawing.Size(138, 38);
            this.mainUpdateBtn.TabIndex = 2;
            this.mainUpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainUpdateBtn.Click += new System.EventHandler(this.mainUpdateBtn_Click);
            // 
            // mainPayBtn
            // 
            this.mainPayBtn.ActiveBorderThickness = 1;
            this.mainPayBtn.ActiveCornerRadius = 25;
            this.mainPayBtn.ActiveFillColor = System.Drawing.Color.MediumVioletRed;
            this.mainPayBtn.ActiveForecolor = System.Drawing.Color.White;
            this.mainPayBtn.ActiveLineColor = System.Drawing.Color.MidnightBlue;
            this.mainPayBtn.BackColor = System.Drawing.Color.White;
            this.mainPayBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPayBtn.BackgroundImage")));
            this.mainPayBtn.ButtonText = "Payment";
            this.mainPayBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainPayBtn.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.mainPayBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.mainPayBtn.IdleBorderThickness = 1;
            this.mainPayBtn.IdleCornerRadius = 26;
            this.mainPayBtn.IdleFillColor = System.Drawing.Color.White;
            this.mainPayBtn.IdleForecolor = System.Drawing.Color.Crimson;
            this.mainPayBtn.IdleLineColor = System.Drawing.Color.Crimson;
            this.mainPayBtn.Location = new System.Drawing.Point(568, 5);
            this.mainPayBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPayBtn.Name = "mainPayBtn";
            this.mainPayBtn.Size = new System.Drawing.Size(107, 38);
            this.mainPayBtn.TabIndex = 2;
            this.mainPayBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainPayBtn.Click += new System.EventHandler(this.mainPayBtn_Click);
            // 
            // mainAddMemberBtn
            // 
            this.mainAddMemberBtn.ActiveBorderThickness = 1;
            this.mainAddMemberBtn.ActiveCornerRadius = 25;
            this.mainAddMemberBtn.ActiveFillColor = System.Drawing.Color.MediumVioletRed;
            this.mainAddMemberBtn.ActiveForecolor = System.Drawing.Color.White;
            this.mainAddMemberBtn.ActiveLineColor = System.Drawing.Color.MidnightBlue;
            this.mainAddMemberBtn.BackColor = System.Drawing.Color.White;
            this.mainAddMemberBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainAddMemberBtn.BackgroundImage")));
            this.mainAddMemberBtn.ButtonText = "Add Member";
            this.mainAddMemberBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainAddMemberBtn.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.mainAddMemberBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.mainAddMemberBtn.IdleBorderThickness = 1;
            this.mainAddMemberBtn.IdleCornerRadius = 26;
            this.mainAddMemberBtn.IdleFillColor = System.Drawing.Color.White;
            this.mainAddMemberBtn.IdleForecolor = System.Drawing.Color.Crimson;
            this.mainAddMemberBtn.IdleLineColor = System.Drawing.Color.Crimson;
            this.mainAddMemberBtn.Location = new System.Drawing.Point(191, 5);
            this.mainAddMemberBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainAddMemberBtn.Name = "mainAddMemberBtn";
            this.mainAddMemberBtn.Size = new System.Drawing.Size(107, 38);
            this.mainAddMemberBtn.TabIndex = 2;
            this.mainAddMemberBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainAddMemberBtn.Click += new System.EventHandler(this.mainAddMemberBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Firebrick;
            this.label10.Location = new System.Drawing.Point(285, 453);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 18);
            this.label10.TabIndex = 36;
            this.label10.Text = "DevelopdByShamimAhammad";
            // 
            // signOutBtn
            // 
            this.signOutBtn.AllowFocused = false;
            this.signOutBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signOutBtn.BorderRadius = 0;
            this.signOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("signOutBtn.Image")));
            this.signOutBtn.IsCircle = false;
            this.signOutBtn.Location = new System.Drawing.Point(1, 1);
            this.signOutBtn.Margin = new System.Windows.Forms.Padding(0);
            this.signOutBtn.Name = "signOutBtn";
            this.signOutBtn.Size = new System.Drawing.Size(37, 37);
            this.signOutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.signOutBtn.TabIndex = 96;
            this.signOutBtn.TabStop = false;
            this.signOutBtn.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.signOutBtn.Click += new System.EventHandler(this.signOutBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.signOutBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signOutBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 mainViewBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 mainUpdateBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 mainPayBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 mainAddMemberBtn;
        private System.Windows.Forms.Label logClose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private Bunifu.UI.WinForms.BunifuPictureBox signOutBtn;
    }
}