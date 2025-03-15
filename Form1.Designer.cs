namespace BasicGame
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
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Setup = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.pb_Player = new System.Windows.Forms.PictureBox();
            this.pb_Health = new System.Windows.Forms.ProgressBar();
            this.lbl_Health = new System.Windows.Forms.Label();
            this.pb_Xp = new System.Windows.Forms.ProgressBar();
            this.lbl_xp = new System.Windows.Forms.Label();
            this.lbl_class = new System.Windows.Forms.Label();
            this.lbl_class1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Play
            // 
            this.btn_Play.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Play.Enabled = false;
            this.btn_Play.Location = new System.Drawing.Point(47, 129);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(156, 62);
            this.btn_Play.TabIndex = 0;
            this.btn_Play.Text = "Play";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_Setup
            // 
            this.btn_Setup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Setup.Location = new System.Drawing.Point(600, 129);
            this.btn_Setup.Name = "btn_Setup";
            this.btn_Setup.Size = new System.Drawing.Size(156, 62);
            this.btn_Setup.TabIndex = 1;
            this.btn_Setup.Text = "Setup-Character";
            this.btn_Setup.UseVisualStyleBackColor = true;
            this.btn_Setup.Click += new System.EventHandler(this.btn_Setup_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Pause.Enabled = false;
            this.btn_Pause.Location = new System.Drawing.Point(716, 384);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(80, 65);
            this.btn_Pause.TabIndex = 2;
            this.btn_Pause.Text = "||";
            this.btn_Pause.UseVisualStyleBackColor = true;
            // 
            // btn_Settings
            // 
            this.btn_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Settings.Enabled = false;
            this.btn_Settings.Location = new System.Drawing.Point(630, 384);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(80, 65);
            this.btn_Settings.TabIndex = 3;
            this.btn_Settings.Text = "@";
            this.btn_Settings.UseVisualStyleBackColor = true;
            // 
            // pb_Player
            // 
            this.pb_Player.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pb_Player.Location = new System.Drawing.Point(343, 399);
            this.pb_Player.Name = "pb_Player";
            this.pb_Player.Size = new System.Drawing.Size(100, 50);
            this.pb_Player.TabIndex = 4;
            this.pb_Player.TabStop = false;
            // 
            // pb_Health
            // 
            this.pb_Health.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pb_Health.Location = new System.Drawing.Point(18, 233);
            this.pb_Health.Name = "pb_Health";
            this.pb_Health.Size = new System.Drawing.Size(329, 23);
            this.pb_Health.TabIndex = 5;
            this.pb_Health.Visible = false;
            // 
            // lbl_Health
            // 
            this.lbl_Health.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Health.AutoSize = true;
            this.lbl_Health.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Health.ForeColor = System.Drawing.Color.Gold;
            this.lbl_Health.Location = new System.Drawing.Point(28, 212);
            this.lbl_Health.Name = "lbl_Health";
            this.lbl_Health.Size = new System.Drawing.Size(56, 20);
            this.lbl_Health.TabIndex = 6;
            this.lbl_Health.Text = "Health";
            this.lbl_Health.Visible = false;
            // 
            // pb_Xp
            // 
            this.pb_Xp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pb_Xp.Location = new System.Drawing.Point(18, 282);
            this.pb_Xp.Name = "pb_Xp";
            this.pb_Xp.Size = new System.Drawing.Size(329, 23);
            this.pb_Xp.TabIndex = 7;
            this.pb_Xp.Visible = false;
            // 
            // lbl_xp
            // 
            this.lbl_xp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_xp.AutoSize = true;
            this.lbl_xp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_xp.ForeColor = System.Drawing.Color.Gold;
            this.lbl_xp.Location = new System.Drawing.Point(28, 259);
            this.lbl_xp.Name = "lbl_xp";
            this.lbl_xp.Size = new System.Drawing.Size(30, 20);
            this.lbl_xp.TabIndex = 8;
            this.lbl_xp.Text = "XP";
            this.lbl_xp.Visible = false;
            // 
            // lbl_class
            // 
            this.lbl_class.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_class.AutoSize = true;
            this.lbl_class.BackColor = System.Drawing.Color.Transparent;
            this.lbl_class.ForeColor = System.Drawing.Color.Gold;
            this.lbl_class.Location = new System.Drawing.Point(28, 319);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(48, 20);
            this.lbl_class.TabIndex = 9;
            this.lbl_class.Text = "Class";
            this.lbl_class.Visible = false;
            // 
            // lbl_class1
            // 
            this.lbl_class1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_class1.AutoSize = true;
            this.lbl_class1.Location = new System.Drawing.Point(82, 319);
            this.lbl_class1.Name = "lbl_class1";
            this.lbl_class1.Size = new System.Drawing.Size(0, 20);
            this.lbl_class1.TabIndex = 10;
            this.lbl_class1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_class1);
            this.Controls.Add(this.lbl_class);
            this.Controls.Add(this.lbl_xp);
            this.Controls.Add(this.pb_Xp);
            this.Controls.Add(this.lbl_Health);
            this.Controls.Add(this.pb_Health);
            this.Controls.Add(this.pb_Player);
            this.Controls.Add(this.btn_Settings);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.btn_Setup);
            this.Controls.Add(this.btn_Play);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_Setup;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.PictureBox pb_Player;
        private System.Windows.Forms.ProgressBar pb_Health;
        private System.Windows.Forms.Label lbl_Health;
        private System.Windows.Forms.ProgressBar pb_Xp;
        private System.Windows.Forms.Label lbl_xp;
        private System.Windows.Forms.Label lbl_class;
        private System.Windows.Forms.Label lbl_class1;
    }
}

