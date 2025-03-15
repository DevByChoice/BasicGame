namespace BasicGame
{
    partial class Armoury
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
            this.lbl_Class = new System.Windows.Forms.Label();
            this.drp_Class = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Class
            // 
            this.lbl_Class.AutoSize = true;
            this.lbl_Class.Location = new System.Drawing.Point(144, 173);
            this.lbl_Class.Name = "lbl_Class";
            this.lbl_Class.Size = new System.Drawing.Size(52, 20);
            this.lbl_Class.TabIndex = 0;
            this.lbl_Class.Text = "Class:";
            // 
            // drp_Class
            // 
            this.drp_Class.FormattingEnabled = true;
            this.drp_Class.Location = new System.Drawing.Point(319, 173);
            this.drp_Class.Name = "drp_Class";
            this.drp_Class.Size = new System.Drawing.Size(121, 28);
            this.drp_Class.TabIndex = 1;
            this.drp_Class.SelectedIndexChanged += new System.EventHandler(this.drp_Class_SelectedIndexChanged);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(302, 324);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(138, 35);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save Choice";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Armoury
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.drp_Class);
            this.Controls.Add(this.lbl_Class);
            this.Name = "Armoury";
            this.Text = "Armoury";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Class;
        private System.Windows.Forms.ComboBox drp_Class;
        private System.Windows.Forms.Button btn_save;
    }
}