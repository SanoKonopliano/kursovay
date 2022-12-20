namespace KursovaDBFinal
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отдел1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Post = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label_length = new System.Windows.Forms.Label();
            this.label_countBridge = new System.Windows.Forms.Label();
            this.label_speed = new System.Windows.Forms.Label();
            this.label_typeTrack = new System.Windows.Forms.Label();
            this.textBox_length = new System.Windows.Forms.TextBox();
            this.textBox_countBridge = new System.Windows.Forms.TextBox();
            this.textBox_speed = new System.Windows.Forms.TextBox();
            this.textBox_typeTrack = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_Post = new System.Windows.Forms.Label();
            this.panel_Ctrl = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_NewPost = new System.Windows.Forms.Button();
            this.label_ctrlPost = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelTrack = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.btn_eareser = new System.Windows.Forms.PictureBox();
            this.btn_refresh = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.городаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_numTrack = new System.Windows.Forms.Label();
            this.textBox_Cities = new System.Windows.Forms.TextBox();
            this.textBox_numTrack = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_countPop = new System.Windows.Forms.TextBox();
            this.label_Pop = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel_Post.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel_Ctrl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_eareser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отдел1ToolStripMenuItem,
            this.городаToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // отдел1ToolStripMenuItem
            // 
            this.отдел1ToolStripMenuItem.Name = "отдел1ToolStripMenuItem";
            this.отдел1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.отдел1ToolStripMenuItem.Text = "Отдел №1";
            this.отдел1ToolStripMenuItem.Click += new System.EventHandler(this.отдел1ToolStripMenuItem_Click);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // panel_Post
            // 
            this.panel_Post.Controls.Add(this.label_Pop);
            this.panel_Post.Controls.Add(this.textBox_countPop);
            this.panel_Post.Controls.Add(this.label2);
            this.panel_Post.Controls.Add(this.textBox_numTrack);
            this.panel_Post.Controls.Add(this.textBox_Cities);
            this.panel_Post.Controls.Add(this.label_numTrack);
            this.panel_Post.Controls.Add(this.pictureBox4);
            this.panel_Post.Controls.Add(this.label_length);
            this.panel_Post.Controls.Add(this.label_countBridge);
            this.panel_Post.Controls.Add(this.label_speed);
            this.panel_Post.Controls.Add(this.label_typeTrack);
            this.panel_Post.Controls.Add(this.textBox_length);
            this.panel_Post.Controls.Add(this.textBox_countBridge);
            this.panel_Post.Controls.Add(this.textBox_speed);
            this.panel_Post.Controls.Add(this.textBox_typeTrack);
            this.panel_Post.Controls.Add(this.textBox_ID);
            this.panel_Post.Controls.Add(this.label_ID);
            this.panel_Post.Controls.Add(this.label_Post);
            this.panel_Post.Location = new System.Drawing.Point(43, 434);
            this.panel_Post.Name = "panel_Post";
            this.panel_Post.Size = new System.Drawing.Size(462, 308);
            this.panel_Post.TabIndex = 2;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::KursovaDBFinal.Properties.Resources.notebook;
            this.pictureBox4.Location = new System.Drawing.Point(4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 56);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label_length
            // 
            this.label_length.AutoSize = true;
            this.label_length.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label_length.Location = new System.Drawing.Point(101, 198);
            this.label_length.Name = "label_length";
            this.label_length.Size = new System.Drawing.Size(107, 22);
            this.label_length.TabIndex = 10;
            this.label_length.Text = "Дистанция:";
            // 
            // label_countBridge
            // 
            this.label_countBridge.AutoSize = true;
            this.label_countBridge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label_countBridge.Location = new System.Drawing.Point(36, 166);
            this.label_countBridge.Name = "label_countBridge";
            this.label_countBridge.Size = new System.Drawing.Size(173, 22);
            this.label_countBridge.TabIndex = 9;
            this.label_countBridge.Text = "Места для стоянки:";
            this.label_countBridge.Click += new System.EventHandler(this.label6_Click);
            // 
            // label_speed
            // 
            this.label_speed.AutoSize = true;
            this.label_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label_speed.Location = new System.Drawing.Point(83, 134);
            this.label_speed.Name = "label_speed";
            this.label_speed.Size = new System.Drawing.Size(126, 22);
            this.label_speed.TabIndex = 8;
            this.label_speed.Text = "Ограничение:";
            // 
            // label_typeTrack
            // 
            this.label_typeTrack.AutoSize = true;
            this.label_typeTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label_typeTrack.Location = new System.Drawing.Point(111, 228);
            this.label_typeTrack.Name = "label_typeTrack";
            this.label_typeTrack.Size = new System.Drawing.Size(98, 22);
            this.label_typeTrack.TabIndex = 7;
            this.label_typeTrack.Text = "Покрытие:";
            // 
            // textBox_length
            // 
            this.textBox_length.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_length.Location = new System.Drawing.Point(214, 198);
            this.textBox_length.Name = "textBox_length";
            this.textBox_length.Size = new System.Drawing.Size(185, 26);
            this.textBox_length.TabIndex = 6;
            // 
            // textBox_countBridge
            // 
            this.textBox_countBridge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_countBridge.Location = new System.Drawing.Point(214, 166);
            this.textBox_countBridge.Name = "textBox_countBridge";
            this.textBox_countBridge.Size = new System.Drawing.Size(185, 26);
            this.textBox_countBridge.TabIndex = 5;
            // 
            // textBox_speed
            // 
            this.textBox_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_speed.Location = new System.Drawing.Point(214, 134);
            this.textBox_speed.Name = "textBox_speed";
            this.textBox_speed.Size = new System.Drawing.Size(185, 26);
            this.textBox_speed.TabIndex = 4;
            // 
            // textBox_typeTrack
            // 
            this.textBox_typeTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_typeTrack.Location = new System.Drawing.Point(214, 230);
            this.textBox_typeTrack.Name = "textBox_typeTrack";
            this.textBox_typeTrack.Size = new System.Drawing.Size(185, 26);
            this.textBox_typeTrack.TabIndex = 3;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_ID.Location = new System.Drawing.Point(214, 38);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(185, 26);
            this.textBox_ID.TabIndex = 2;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label_ID.Location = new System.Drawing.Point(176, 38);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(32, 22);
            this.label_ID.TabIndex = 1;
            this.label_ID.Text = "ID:";
            // 
            // label_Post
            // 
            this.label_Post.AutoSize = true;
            this.label_Post.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_Post.Location = new System.Drawing.Point(70, 17);
            this.label_Post.Name = "label_Post";
            this.label_Post.Size = new System.Drawing.Size(91, 26);
            this.label_Post.TabIndex = 0;
            this.label_Post.Text = "Запись:";
            // 
            // panel_Ctrl
            // 
            this.panel_Ctrl.Controls.Add(this.btn_Save);
            this.panel_Ctrl.Controls.Add(this.btn_Edit);
            this.panel_Ctrl.Controls.Add(this.btn_Delete);
            this.panel_Ctrl.Controls.Add(this.btn_NewPost);
            this.panel_Ctrl.Location = new System.Drawing.Point(546, 491);
            this.panel_Ctrl.Name = "panel_Ctrl";
            this.panel_Ctrl.Size = new System.Drawing.Size(208, 251);
            this.panel_Ctrl.TabIndex = 3;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(25, 171);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(160, 41);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Сохранить";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(25, 126);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(160, 39);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "Изменить";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(25, 77);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(160, 43);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "Удалить";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_NewPost
            // 
            this.btn_NewPost.Location = new System.Drawing.Point(25, 32);
            this.btn_NewPost.Name = "btn_NewPost";
            this.btn_NewPost.Size = new System.Drawing.Size(160, 39);
            this.btn_NewPost.TabIndex = 0;
            this.btn_NewPost.Text = "Новая запись";
            this.btn_NewPost.UseVisualStyleBackColor = true;
            this.btn_NewPost.Click += new System.EventHandler(this.btn_NewPost_Click);
            // 
            // label_ctrlPost
            // 
            this.label_ctrlPost.AutoSize = true;
            this.label_ctrlPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_ctrlPost.Location = new System.Drawing.Point(550, 468);
            this.label_ctrlPost.Name = "label_ctrlPost";
            this.label_ctrlPost.Size = new System.Drawing.Size(181, 20);
            this.label_ctrlPost.TabIndex = 4;
            this.label_ctrlPost.Text = "Управление записями:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.btn_refresh);
            this.tabPage2.Controls.Add(this.btn_eareser);
            this.tabPage2.Controls.Add(this.textBox_Search);
            this.tabPage2.Controls.Add(this.dataGridView);
            this.tabPage2.Controls.Add(this.labelTrack);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(830, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelTrack
            // 
            this.labelTrack.BackColor = System.Drawing.Color.LightGray;
            this.labelTrack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTrack.Location = new System.Drawing.Point(3, 3);
            this.labelTrack.Name = "labelTrack";
            this.labelTrack.Size = new System.Drawing.Size(827, 36);
            this.labelTrack.TabIndex = 0;
            this.labelTrack.Text = "Автомобильные дороги";
            this.labelTrack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(3, 42);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(824, 317);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(681, 6);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(141, 20);
            this.textBox_Search.TabIndex = 2;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // btn_eareser
            // 
            this.btn_eareser.Image = global::KursovaDBFinal.Properties.Resources.eraser_;
            this.btn_eareser.Location = new System.Drawing.Point(567, 6);
            this.btn_eareser.Name = "btn_eareser";
            this.btn_eareser.Size = new System.Drawing.Size(34, 30);
            this.btn_eareser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_eareser.TabIndex = 5;
            this.btn_eareser.TabStop = false;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Image = global::KursovaDBFinal.Properties.Resources.refresh;
            this.btn_refresh.Location = new System.Drawing.Point(607, 6);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(29, 30);
            this.btn_refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_refresh.TabIndex = 6;
            this.btn_refresh.TabStop = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KursovaDBFinal.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(642, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(838, 391);
            this.tabControl.TabIndex = 1;
            // 
            // городаToolStripMenuItem
            // 
            this.городаToolStripMenuItem.Name = "городаToolStripMenuItem";
            this.городаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.городаToolStripMenuItem.Text = "Города";
            this.городаToolStripMenuItem.Click += new System.EventHandler(this.городаToolStripMenuItem_Click);
            // 
            // label_numTrack
            // 
            this.label_numTrack.AutoSize = true;
            this.label_numTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label_numTrack.Location = new System.Drawing.Point(71, 262);
            this.label_numTrack.Name = "label_numTrack";
            this.label_numTrack.Size = new System.Drawing.Size(134, 22);
            this.label_numTrack.TabIndex = 12;
            this.label_numTrack.Text = "Номер дороги:";
            // 
            // textBox_Cities
            // 
            this.textBox_Cities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_Cities.Location = new System.Drawing.Point(215, 70);
            this.textBox_Cities.Name = "textBox_Cities";
            this.textBox_Cities.Size = new System.Drawing.Size(185, 26);
            this.textBox_Cities.TabIndex = 13;
            // 
            // textBox_numTrack
            // 
            this.textBox_numTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_numTrack.Location = new System.Drawing.Point(215, 262);
            this.textBox_numTrack.Name = "textBox_numTrack";
            this.textBox_numTrack.Size = new System.Drawing.Size(185, 26);
            this.textBox_numTrack.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(14, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cоединенные города:";
            // 
            // textBox_countPop
            // 
            this.textBox_countPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_countPop.Location = new System.Drawing.Point(214, 102);
            this.textBox_countPop.Name = "textBox_countPop";
            this.textBox_countPop.Size = new System.Drawing.Size(185, 26);
            this.textBox_countPop.TabIndex = 16;
            // 
            // label_Pop
            // 
            this.label_Pop.AutoSize = true;
            this.label_Pop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label_Pop.Location = new System.Drawing.Point(98, 102);
            this.label_Pop.Name = "label_Pop";
            this.label_Pop.Size = new System.Drawing.Size(107, 22);
            this.label_Pop.TabIndex = 17;
            this.label_Pop.Text = "Население:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 754);
            this.Controls.Add(this.label_ctrlPost);
            this.Controls.Add(this.panel_Ctrl);
            this.Controls.Add(this.panel_Post);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_Post.ResumeLayout(false);
            this.panel_Post.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel_Ctrl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_eareser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отдел1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.Panel panel_Post;
        private System.Windows.Forms.Panel panel_Ctrl;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_NewPost;
        private System.Windows.Forms.Label label_length;
        private System.Windows.Forms.Label label_countBridge;
        private System.Windows.Forms.Label label_speed;
        private System.Windows.Forms.Label label_typeTrack;
        private System.Windows.Forms.TextBox textBox_length;
        private System.Windows.Forms.TextBox textBox_countBridge;
        private System.Windows.Forms.TextBox textBox_speed;
        private System.Windows.Forms.TextBox textBox_typeTrack;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_Post;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label_ctrlPost;
        private System.Windows.Forms.ToolStripMenuItem городаToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btn_refresh;
        private System.Windows.Forms.PictureBox btn_eareser;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelTrack;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TextBox textBox_Cities;
        private System.Windows.Forms.Label label_numTrack;
        private System.Windows.Forms.Label label_Pop;
        private System.Windows.Forms.TextBox textBox_countPop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_numTrack;
    }
}

