namespace KursovaDBFinal
{
    partial class sign_up
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
            this.label_auth1 = new System.Windows.Forms.Label();
            this.label_log1 = new System.Windows.Forms.Label();
            this.label_pass2 = new System.Windows.Forms.Label();
            this.textBox_log1 = new System.Windows.Forms.TextBox();
            this.textBox_pass1 = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pictureBox_eye11 = new System.Windows.Forms.PictureBox();
            this.pictureBox_eye12 = new System.Windows.Forms.PictureBox();
            this.pictureBox_auth1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_eye11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_eye12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_auth1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_auth1
            // 
            this.label_auth1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_auth1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_auth1.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_auth1.Location = new System.Drawing.Point(92, 12);
            this.label_auth1.Name = "label_auth1";
            this.label_auth1.Size = new System.Drawing.Size(458, 74);
            this.label_auth1.TabIndex = 1;
            this.label_auth1.Text = "Регистрация";
            this.label_auth1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_log1
            // 
            this.label_log1.AutoSize = true;
            this.label_log1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_log1.Location = new System.Drawing.Point(117, 145);
            this.label_log1.Name = "label_log1";
            this.label_log1.Size = new System.Drawing.Size(61, 21);
            this.label_log1.TabIndex = 2;
            this.label_log1.Text = "Логин:";
            // 
            // label_pass2
            // 
            this.label_pass2.AutoSize = true;
            this.label_pass2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label_pass2.Location = new System.Drawing.Point(104, 194);
            this.label_pass2.Name = "label_pass2";
            this.label_pass2.Size = new System.Drawing.Size(74, 21);
            this.label_pass2.TabIndex = 3;
            this.label_pass2.Text = "Пароль:";
            // 
            // textBox_log1
            // 
            this.textBox_log1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_log1.Location = new System.Drawing.Point(184, 135);
            this.textBox_log1.Name = "textBox_log1";
            this.textBox_log1.Size = new System.Drawing.Size(194, 31);
            this.textBox_log1.TabIndex = 4;
            // 
            // textBox_pass1
            // 
            this.textBox_pass1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_pass1.Location = new System.Drawing.Point(184, 184);
            this.textBox_pass1.Name = "textBox_pass1";
            this.textBox_pass1.Size = new System.Drawing.Size(194, 31);
            this.textBox_pass1.TabIndex = 5;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnCreate.Location = new System.Drawing.Point(208, 237);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(138, 58);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Создать аккаунт";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // pictureBox_eye11
            // 
            this.pictureBox_eye11.Image = global::KursovaDBFinal.Properties.Resources.eyecl;
            this.pictureBox_eye11.Location = new System.Drawing.Point(384, 184);
            this.pictureBox_eye11.Name = "pictureBox_eye11";
            this.pictureBox_eye11.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_eye11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_eye11.TabIndex = 8;
            this.pictureBox_eye11.TabStop = false;
            // 
            // pictureBox_eye12
            // 
            this.pictureBox_eye12.Image = global::KursovaDBFinal.Properties.Resources.eyeop;
            this.pictureBox_eye12.Location = new System.Drawing.Point(384, 184);
            this.pictureBox_eye12.Name = "pictureBox_eye12";
            this.pictureBox_eye12.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_eye12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_eye12.TabIndex = 7;
            this.pictureBox_eye12.TabStop = false;
            // 
            // pictureBox_auth1
            // 
            this.pictureBox_auth1.Image = global::KursovaDBFinal.Properties.Resources.auth;
            this.pictureBox_auth1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_auth1.Name = "pictureBox_auth1";
            this.pictureBox_auth1.Size = new System.Drawing.Size(74, 74);
            this.pictureBox_auth1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_auth1.TabIndex = 0;
            this.pictureBox_auth1.TabStop = false;
            // 
            // sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 355);
            this.Controls.Add(this.pictureBox_eye11);
            this.Controls.Add(this.pictureBox_eye12);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.textBox_pass1);
            this.Controls.Add(this.textBox_log1);
            this.Controls.Add(this.label_pass2);
            this.Controls.Add(this.label_log1);
            this.Controls.Add(this.label_auth1);
            this.Controls.Add(this.pictureBox_auth1);
            this.Name = "sign_up";
            this.Text = "sign_up";
            this.Load += new System.EventHandler(this.sign_up_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_eye11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_eye12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_auth1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_auth1;
        private System.Windows.Forms.Label label_auth1;
        private System.Windows.Forms.Label label_log1;
        private System.Windows.Forms.Label label_pass2;
        private System.Windows.Forms.TextBox textBox_log1;
        private System.Windows.Forms.TextBox textBox_pass1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.PictureBox pictureBox_eye12;
        private System.Windows.Forms.PictureBox pictureBox_eye11;
    }
}