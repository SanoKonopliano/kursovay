namespace KursovaDBFinal
{
    partial class Add_Form
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
            this.label_create = new System.Windows.Forms.Label();
            this.textBox_typeTrack = new System.Windows.Forms.TextBox();
            this.textBox_speed = new System.Windows.Forms.TextBox();
            this.textBox_stops = new System.Windows.Forms.TextBox();
            this.textBox_length = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_numTrack = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_population = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_create
            // 
            this.label_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_create.Location = new System.Drawing.Point(118, 22);
            this.label_create.Name = "label_create";
            this.label_create.Size = new System.Drawing.Size(546, 74);
            this.label_create.TabIndex = 0;
            this.label_create.Text = "Создание записи:\r\nОтдел №1";
            this.label_create.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_typeTrack
            // 
            this.textBox_typeTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_typeTrack.Location = new System.Drawing.Point(206, 129);
            this.textBox_typeTrack.Name = "textBox_typeTrack";
            this.textBox_typeTrack.Size = new System.Drawing.Size(232, 26);
            this.textBox_typeTrack.TabIndex = 2;
            // 
            // textBox_speed
            // 
            this.textBox_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_speed.Location = new System.Drawing.Point(206, 161);
            this.textBox_speed.Name = "textBox_speed";
            this.textBox_speed.Size = new System.Drawing.Size(232, 26);
            this.textBox_speed.TabIndex = 3;
            // 
            // textBox_stops
            // 
            this.textBox_stops.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_stops.Location = new System.Drawing.Point(206, 193);
            this.textBox_stops.Name = "textBox_stops";
            this.textBox_stops.Size = new System.Drawing.Size(232, 26);
            this.textBox_stops.TabIndex = 4;
            // 
            // textBox_length
            // 
            this.textBox_length.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_length.Location = new System.Drawing.Point(206, 225);
            this.textBox_length.Name = "textBox_length";
            this.textBox_length.Size = new System.Drawing.Size(232, 26);
            this.textBox_length.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(122, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Покрытие:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(100, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ограничение:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(51, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Кол-во мест стоянки:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(85, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Протяженность:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KursovaDBFinal.Properties.Resources.AddPOST;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(264, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(100, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Номер дороги:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_numTrack
            // 
            this.textBox_numTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_numTrack.Location = new System.Drawing.Point(206, 97);
            this.textBox_numTrack.Name = "textBox_numTrack";
            this.textBox_numTrack.Size = new System.Drawing.Size(232, 26);
            this.textBox_numTrack.TabIndex = 12;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label.Location = new System.Drawing.Point(148, 263);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(52, 17);
            this.label.TabIndex = 13;
            this.label.Text = "Город:";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_city
            // 
            this.textBox_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_city.Location = new System.Drawing.Point(206, 257);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(232, 26);
            this.textBox_city.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(115, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Население:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox_population
            // 
            this.textBox_population.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_population.Location = new System.Drawing.Point(206, 291);
            this.textBox_population.Name = "textBox_population";
            this.textBox_population.Size = new System.Drawing.Size(232, 26);
            this.textBox_population.TabIndex = 16;
            // 
            // Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 397);
            this.Controls.Add(this.textBox_population);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_city);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBox_numTrack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_length);
            this.Controls.Add(this.textBox_stops);
            this.Controls.Add(this.textBox_speed);
            this.Controls.Add(this.textBox_typeTrack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_create);
            this.Name = "Add_Form";
            this.Text = "Add_Form";
            this.Load += new System.EventHandler(this.Add_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_create;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_typeTrack;
        private System.Windows.Forms.TextBox textBox_speed;
        private System.Windows.Forms.TextBox textBox_stops;
        private System.Windows.Forms.TextBox textBox_length;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_numTrack;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox_city;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_population;
    }
}