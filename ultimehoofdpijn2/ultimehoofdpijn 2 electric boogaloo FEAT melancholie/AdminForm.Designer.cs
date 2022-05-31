
namespace ultimehoofdpijn_2_electric_boogaloo_FEAT_melancholie
{
    partial class AdminForm
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
            this.btnLogoff = new System.Windows.Forms.Button();
            this.BtnGelijkAdmin = new System.Windows.Forms.Button();
            this.lblOfAdmin = new System.Windows.Forms.Label();
            this.BtnTeam2Admin = new System.Windows.Forms.Button();
            this.BtnTeam1Admin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogoff
            // 
            this.btnLogoff.Location = new System.Drawing.Point(15, 12);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(100, 34);
            this.btnLogoff.TabIndex = 10;
            this.btnLogoff.Text = "Close";
            this.btnLogoff.UseVisualStyleBackColor = true;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // BtnGelijkAdmin
            // 
            this.BtnGelijkAdmin.Location = new System.Drawing.Point(166, 151);
            this.BtnGelijkAdmin.Name = "BtnGelijkAdmin";
            this.BtnGelijkAdmin.Size = new System.Drawing.Size(100, 34);
            this.BtnGelijkAdmin.TabIndex = 31;
            this.BtnGelijkAdmin.Text = "Gelijkspel";
            this.BtnGelijkAdmin.UseVisualStyleBackColor = true;
            this.BtnGelijkAdmin.Click += new System.EventHandler(this.BtnGelijkAdmin_Click);
            // 
            // lblOfAdmin
            // 
            this.lblOfAdmin.AutoSize = true;
            this.lblOfAdmin.Location = new System.Drawing.Point(205, 120);
            this.lblOfAdmin.Name = "lblOfAdmin";
            this.lblOfAdmin.Size = new System.Drawing.Size(27, 17);
            this.lblOfAdmin.TabIndex = 30;
            this.lblOfAdmin.Text = "OF";
            // 
            // BtnTeam2Admin
            // 
            this.BtnTeam2Admin.Location = new System.Drawing.Point(238, 111);
            this.BtnTeam2Admin.Name = "BtnTeam2Admin";
            this.BtnTeam2Admin.Size = new System.Drawing.Size(100, 34);
            this.BtnTeam2Admin.TabIndex = 29;
            this.BtnTeam2Admin.Text = "Team2";
            this.BtnTeam2Admin.UseVisualStyleBackColor = true;
            this.BtnTeam2Admin.Click += new System.EventHandler(this.BtnTeam2Admin_Click);
            // 
            // BtnTeam1Admin
            // 
            this.BtnTeam1Admin.Location = new System.Drawing.Point(99, 111);
            this.BtnTeam1Admin.Name = "BtnTeam1Admin";
            this.BtnTeam1Admin.Size = new System.Drawing.Size(100, 34);
            this.BtnTeam1Admin.TabIndex = 28;
            this.BtnTeam1Admin.Text = "Team1";
            this.BtnTeam1Admin.UseVisualStyleBackColor = true;
            this.BtnTeam1Admin.Click += new System.EventHandler(this.BtnTeam1Admin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Wie wint er:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(15, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 33;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 409);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGelijkAdmin);
            this.Controls.Add(this.lblOfAdmin);
            this.Controls.Add(this.BtnTeam2Admin);
            this.Controls.Add(this.BtnTeam1Admin);
            this.Controls.Add(this.btnLogoff);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.Button BtnGelijkAdmin;
        private System.Windows.Forms.Label lblOfAdmin;
        private System.Windows.Forms.Button BtnTeam2Admin;
        private System.Windows.Forms.Button BtnTeam1Admin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}