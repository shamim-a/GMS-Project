
namespace Gym_Management_System
{
    partial class ViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdlClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.memView = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.signOutBtn = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signOutBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(403, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 21);
            this.label3.TabIndex = 65;
            this.label3.Text = "View Members List";
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
            this.UpdlClose.Location = new System.Drawing.Point(951, -1);
            this.UpdlClose.Name = "UpdlClose";
            this.UpdlClose.Size = new System.Drawing.Size(35, 32);
            this.UpdlClose.TabIndex = 64;
            this.UpdlClose.Text = "X";
            this.UpdlClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdlClose.Click += new System.EventHandler(this.UpdlClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(393, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 28);
            this.label1.TabIndex = 63;
            this.label1.Text = "FITNESS CENTER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchTxt
            // 
            this.searchTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.searchTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.searchTxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTxt.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.searchTxt.ForeColor = System.Drawing.Color.Black;
            this.searchTxt.HintForeColor = System.Drawing.SystemColors.GrayText;
            this.searchTxt.HintText = "Search by name or mobile number.....";
            this.searchTxt.isPassword = false;
            this.searchTxt.LineFocusedColor = System.Drawing.Color.SlateBlue;
            this.searchTxt.LineIdleColor = System.Drawing.Color.DarkBlue;
            this.searchTxt.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.searchTxt.LineThickness = 4;
            this.searchTxt.Location = new System.Drawing.Point(288, 64);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(4);
            this.searchTxt.MaxLength = 32767;
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(291, 37);
            this.searchTxt.TabIndex = 82;
            this.searchTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.Crimson;
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.refreshBtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.refreshBtn.Location = new System.Drawing.Point(655, 64);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(79, 38);
            this.refreshBtn.TabIndex = 81;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Crimson;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.searchBtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.searchBtn.Location = new System.Drawing.Point(578, 64);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 38);
            this.searchBtn.TabIndex = 80;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.GhostWhite;
            this.button2.Location = new System.Drawing.Point(440, 512);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 39);
            this.button2.TabIndex = 83;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Firebrick;
            this.label10.Location = new System.Drawing.Point(390, 554);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 18);
            this.label10.TabIndex = 84;
            this.label10.Text = "DevelopdByShamimAhammad";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(55, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 86;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.memView);
            this.groupBox1.Location = new System.Drawing.Point(24, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 377);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Details View";
            // 
            // memView
            // 
            this.memView.AllowCustomTheming = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.memView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.memView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.memView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.memView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.memView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.memView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.memView.ColumnHeadersHeight = 40;
            this.memView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.memView.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.memView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.memView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.memView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.memView.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.memView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.memView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.memView.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.memView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.memView.CurrentTheme.Name = null;
            this.memView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.memView.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.memView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.memView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.memView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.memView.DefaultCellStyle = dataGridViewCellStyle8;
            this.memView.EnableHeadersVisualStyles = false;
            this.memView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.memView.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            /*this.memView.HeaderBgColor = System.Drawing.Color.Empty;*/
            this.memView.HeaderForeColor = System.Drawing.Color.White;
            this.memView.Location = new System.Drawing.Point(6, 19);
            this.memView.Name = "memView";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.memView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.memView.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.memView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.memView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info;
            this.memView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.memView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Pink;
            this.memView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.memView.RowTemplate.Height = 40;
            this.memView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.memView.Size = new System.Drawing.Size(926, 352);
            this.memView.TabIndex = 90;
            this.memView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
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
            this.signOutBtn.TabIndex = 95;
            this.signOutBtn.TabStop = false;
            this.signOutBtn.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.signOutBtn.Click += new System.EventHandler(this.signOutBtn_Click);
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(985, 580);
            this.Controls.Add(this.signOutBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UpdlClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signOutBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label UpdlClose;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchTxt;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.UI.WinForms.BunifuDataGridView memView;
        private Bunifu.UI.WinForms.BunifuPictureBox signOutBtn;
    }
}