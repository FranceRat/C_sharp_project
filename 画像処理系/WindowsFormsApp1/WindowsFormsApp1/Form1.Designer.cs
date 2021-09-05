namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード
        
        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenImgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.excutetion_button = new System.Windows.Forms.Button();
            this.resize_height = new System.Windows.Forms.TextBox();
            this.resize_width = new System.Windows.Forms.TextBox();
            this.resize_height_label = new System.Windows.Forms.Label();
            this.resize_width_label = new System.Windows.Forms.Label();
            this.CropStartPoints_y = new System.Windows.Forms.TextBox();
            this.CropStartPoints_x = new System.Windows.Forms.TextBox();
            this.CropEndPomints_x = new System.Windows.Forms.TextBox();
            this.CropEndPoints_y = new System.Windows.Forms.TextBox();
            this.CropResize_w = new System.Windows.Forms.TextBox();
            this.CropResize_h = new System.Windows.Forms.TextBox();
            this.Cropstart_label = new System.Windows.Forms.Label();
            this.Cropend_label = new System.Windows.Forms.Label();
            this.Crop_resize_label = new System.Windows.Forms.Label();
            this.CropStartPoints_x_label = new System.Windows.Forms.Label();
            this.CropStartPoints_y_label = new System.Windows.Forms.Label();
            this.CropEndPoints_y_label = new System.Windows.Forms.Label();
            this.CropEndPoints_x_label = new System.Windows.Forms.Label();
            this.CropResize_h_label = new System.Windows.Forms.Label();
            this.CropResize_w_label = new System.Windows.Forms.Label();
            this.filter_pos_x = new System.Windows.Forms.TextBox();
            this.filter_pos_y = new System.Windows.Forms.TextBox();
            this.filter_scale_w = new System.Windows.Forms.TextBox();
            this.filter_scale_h = new System.Windows.Forms.TextBox();
            this.filter_proc_list = new System.Windows.Forms.ComboBox();
            this.filetr_proc_strength = new System.Windows.Forms.TrackBar();
            this.filter_proc_label = new System.Windows.Forms.Label();
            this.filter_position_label = new System.Windows.Forms.Label();
            this.filter_position_x_label = new System.Windows.Forms.Label();
            this.filter_position_y_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filter_size_label = new System.Windows.Forms.Label();
            this.filter_size_width_label = new System.Windows.Forms.Label();
            this.filter_size_h_label = new System.Windows.Forms.Label();
            this.filter_strength_label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filetr_proc_strength)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenImgToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.FileToolStripMenuItem.Text = "ファイル";
            // 
            // OpenImgToolStripMenuItem
            // 
            this.OpenImgToolStripMenuItem.Name = "OpenImgToolStripMenuItem";
            this.OpenImgToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.OpenImgToolStripMenuItem.Text = "画像を開く";
            this.OpenImgToolStripMenuItem.Click += new System.EventHandler(this.OpenFolderToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.SaveToolStripMenuItem.Text = "新しく保存";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Location = new System.Drawing.Point(0, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(570, 450);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Resize",
            "Crop"});
            this.comboBox1.Location = new System.Drawing.Point(604, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 20);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropOpen);
            this.comboBox1.DropDownClosed += new System.EventHandler(this.comboBox1_Dropclosed);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "実行する処理";
            // 
            // excutetion_button
            // 
            this.excutetion_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.excutetion_button.Location = new System.Drawing.Point(604, 425);
            this.excutetion_button.Name = "excutetion_button";
            this.excutetion_button.Size = new System.Drawing.Size(214, 23);
            this.excutetion_button.TabIndex = 4;
            this.excutetion_button.Text = "実行";
            this.excutetion_button.UseVisualStyleBackColor = true;
            this.excutetion_button.Click += new System.EventHandler(this.excutetion_button_Click);
            // 
            // resize_height
            // 
            this.resize_height.Location = new System.Drawing.Point(747, 156);
            this.resize_height.Name = "resize_height";
            this.resize_height.Size = new System.Drawing.Size(71, 19);
            this.resize_height.TabIndex = 5;
            // 
            // resize_width
            // 
            this.resize_width.Location = new System.Drawing.Point(631, 156);
            this.resize_width.Name = "resize_width";
            this.resize_width.Size = new System.Drawing.Size(72, 19);
            this.resize_width.TabIndex = 6;
            // 
            // resize_height_label
            // 
            this.resize_height_label.AutoSize = true;
            this.resize_height_label.Location = new System.Drawing.Point(602, 159);
            this.resize_height_label.Name = "resize_height_label";
            this.resize_height_label.Size = new System.Drawing.Size(17, 12);
            this.resize_height_label.TabIndex = 7;
            this.resize_height_label.Text = "幅";
            // 
            // resize_width_label
            // 
            this.resize_width_label.AutoSize = true;
            this.resize_width_label.Location = new System.Drawing.Point(714, 159);
            this.resize_width_label.Name = "resize_width_label";
            this.resize_width_label.Size = new System.Drawing.Size(27, 12);
            this.resize_width_label.TabIndex = 8;
            this.resize_width_label.Text = "x 高さ";
            // 
            // CropStartPoints_y
            // 
            this.CropStartPoints_y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CropStartPoints_y.Location = new System.Drawing.Point(754, 134);
            this.CropStartPoints_y.Name = "CropStartPoints_y";
            this.CropStartPoints_y.Size = new System.Drawing.Size(63, 19);
            this.CropStartPoints_y.TabIndex = 5;
            this.CropStartPoints_y.TextChanged += new System.EventHandler(this.CropStartPoints_y_TextChanged);
            // 
            // CropStartPoints_x
            // 
            this.CropStartPoints_x.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CropStartPoints_x.Location = new System.Drawing.Point(636, 134);
            this.CropStartPoints_x.Name = "CropStartPoints_x";
            this.CropStartPoints_x.Size = new System.Drawing.Size(63, 19);
            this.CropStartPoints_x.TabIndex = 6;
            this.CropStartPoints_x.TextChanged += new System.EventHandler(this.CropStartPoints_x_TextChanged);
            // 
            // CropEndPomints_x
            // 
            this.CropEndPomints_x.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CropEndPomints_x.Location = new System.Drawing.Point(637, 210);
            this.CropEndPomints_x.Name = "CropEndPomints_x";
            this.CropEndPomints_x.Size = new System.Drawing.Size(63, 19);
            this.CropEndPomints_x.TabIndex = 8;
            this.CropEndPomints_x.TextChanged += new System.EventHandler(this.CropEndPomints_x_TextChanged);
            // 
            // CropEndPoints_y
            // 
            this.CropEndPoints_y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CropEndPoints_y.Location = new System.Drawing.Point(755, 210);
            this.CropEndPoints_y.Name = "CropEndPoints_y";
            this.CropEndPoints_y.Size = new System.Drawing.Size(63, 19);
            this.CropEndPoints_y.TabIndex = 7;
            this.CropEndPoints_y.TextChanged += new System.EventHandler(this.CropEndPoints_y_TextChanged);
            // 
            // CropResize_w
            // 
            this.CropResize_w.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CropResize_w.Location = new System.Drawing.Point(637, 288);
            this.CropResize_w.Name = "CropResize_w";
            this.CropResize_w.ReadOnly = true;
            this.CropResize_w.Size = new System.Drawing.Size(63, 19);
            this.CropResize_w.TabIndex = 10;
            // 
            // CropResize_h
            // 
            this.CropResize_h.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CropResize_h.Location = new System.Drawing.Point(755, 288);
            this.CropResize_h.Name = "CropResize_h";
            this.CropResize_h.ReadOnly = true;
            this.CropResize_h.Size = new System.Drawing.Size(63, 19);
            this.CropResize_h.TabIndex = 9;
            // 
            // Cropstart_label
            // 
            this.Cropstart_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cropstart_label.AutoSize = true;
            this.Cropstart_label.Location = new System.Drawing.Point(604, 108);
            this.Cropstart_label.Name = "Cropstart_label";
            this.Cropstart_label.Size = new System.Drawing.Size(139, 12);
            this.Cropstart_label.TabIndex = 11;
            this.Cropstart_label.Text = "切り取り開始点（左上の点）";
            // 
            // Cropend_label
            // 
            this.Cropend_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cropend_label.AutoSize = true;
            this.Cropend_label.Location = new System.Drawing.Point(604, 186);
            this.Cropend_label.Name = "Cropend_label";
            this.Cropend_label.Size = new System.Drawing.Size(139, 12);
            this.Cropend_label.TabIndex = 12;
            this.Cropend_label.Text = "切り取り終了点（右下の点）";
            // 
            // Crop_resize_label
            // 
            this.Crop_resize_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Crop_resize_label.AutoSize = true;
            this.Crop_resize_label.Location = new System.Drawing.Point(602, 261);
            this.Crop_resize_label.Name = "Crop_resize_label";
            this.Crop_resize_label.Size = new System.Drawing.Size(80, 12);
            this.Crop_resize_label.TabIndex = 13;
            this.Crop_resize_label.Text = "Crop後のサイズ";
            // 
            // CropStartPoints_x_label
            // 
            this.CropStartPoints_x_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CropStartPoints_x_label.AutoSize = true;
            this.CropStartPoints_x_label.Location = new System.Drawing.Point(604, 137);
            this.CropStartPoints_x_label.Name = "CropStartPoints_x_label";
            this.CropStartPoints_x_label.Size = new System.Drawing.Size(17, 12);
            this.CropStartPoints_x_label.TabIndex = 14;
            this.CropStartPoints_x_label.Text = "x1";
            // 
            // CropStartPoints_y_label
            // 
            this.CropStartPoints_y_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CropStartPoints_y_label.AutoSize = true;
            this.CropStartPoints_y_label.Location = new System.Drawing.Point(726, 137);
            this.CropStartPoints_y_label.Name = "CropStartPoints_y_label";
            this.CropStartPoints_y_label.Size = new System.Drawing.Size(17, 12);
            this.CropStartPoints_y_label.TabIndex = 15;
            this.CropStartPoints_y_label.Text = "y1";
            // 
            // CropEndPoints_y_label
            // 
            this.CropEndPoints_y_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CropEndPoints_y_label.AutoSize = true;
            this.CropEndPoints_y_label.Location = new System.Drawing.Point(726, 217);
            this.CropEndPoints_y_label.Name = "CropEndPoints_y_label";
            this.CropEndPoints_y_label.Size = new System.Drawing.Size(17, 12);
            this.CropEndPoints_y_label.TabIndex = 17;
            this.CropEndPoints_y_label.Text = "y2";
            // 
            // CropEndPoints_x_label
            // 
            this.CropEndPoints_x_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CropEndPoints_x_label.AutoSize = true;
            this.CropEndPoints_x_label.Location = new System.Drawing.Point(604, 217);
            this.CropEndPoints_x_label.Name = "CropEndPoints_x_label";
            this.CropEndPoints_x_label.Size = new System.Drawing.Size(17, 12);
            this.CropEndPoints_x_label.TabIndex = 16;
            this.CropEndPoints_x_label.Text = "x2";
            // 
            // CropResize_h_label
            // 
            this.CropResize_h_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CropResize_h_label.AutoSize = true;
            this.CropResize_h_label.Location = new System.Drawing.Point(726, 295);
            this.CropResize_h_label.Name = "CropResize_h_label";
            this.CropResize_h_label.Size = new System.Drawing.Size(11, 12);
            this.CropResize_h_label.TabIndex = 19;
            this.CropResize_h_label.Text = "h";
            // 
            // CropResize_w_label
            // 
            this.CropResize_w_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CropResize_w_label.AutoSize = true;
            this.CropResize_w_label.Location = new System.Drawing.Point(604, 295);
            this.CropResize_w_label.Name = "CropResize_w_label";
            this.CropResize_w_label.Size = new System.Drawing.Size(13, 12);
            this.CropResize_w_label.TabIndex = 18;
            this.CropResize_w_label.Text = "w";
            // 
            // filter_pos_x
            // 
            this.filter_pos_x.Location = new System.Drawing.Point(631, 193);
            this.filter_pos_x.Name = "filter_pos_x";
            this.filter_pos_x.Size = new System.Drawing.Size(70, 19);
            this.filter_pos_x.TabIndex = 5;
            // 
            // filter_pos_y
            // 
            this.filter_pos_y.Location = new System.Drawing.Point(748, 193);
            this.filter_pos_y.Name = "filter_pos_y";
            this.filter_pos_y.Size = new System.Drawing.Size(70, 19);
            this.filter_pos_y.TabIndex = 6;
            // 
            // filter_scale_w
            // 
            this.filter_scale_w.Location = new System.Drawing.Point(631, 283);
            this.filter_scale_w.Name = "filter_scale_w";
            this.filter_scale_w.Size = new System.Drawing.Size(70, 19);
            this.filter_scale_w.TabIndex = 7;
            // 
            // filter_scale_h
            // 
            this.filter_scale_h.Location = new System.Drawing.Point(748, 283);
            this.filter_scale_h.Name = "filter_scale_h";
            this.filter_scale_h.Size = new System.Drawing.Size(70, 19);
            this.filter_scale_h.TabIndex = 8;
            // 
            // filter_proc_list
            // 
            this.filter_proc_list.FormattingEnabled = true;
            this.filter_proc_list.Location = new System.Drawing.Point(665, 116);
            this.filter_proc_list.Name = "filter_proc_list";
            this.filter_proc_list.Size = new System.Drawing.Size(153, 20);
            this.filter_proc_list.TabIndex = 9;
            // 
            // filetr_proc_strength
            // 
            this.filetr_proc_strength.Location = new System.Drawing.Point(593, 353);
            this.filetr_proc_strength.Maximum = 100;
            this.filetr_proc_strength.Name = "filetr_proc_strength";
            this.filetr_proc_strength.Size = new System.Drawing.Size(225, 45);
            this.filetr_proc_strength.TabIndex = 10;
            // 
            // filter_proc_label
            // 
            this.filter_proc_label.AutoSize = true;
            this.filter_proc_label.Location = new System.Drawing.Point(591, 119);
            this.filter_proc_label.Name = "filter_proc_label";
            this.filter_proc_label.Size = new System.Drawing.Size(68, 12);
            this.filter_proc_label.TabIndex = 11;
            this.filter_proc_label.Text = "フィルタ処理：";
            // 
            // filter_position_label
            // 
            this.filter_position_label.AutoSize = true;
            this.filter_position_label.Location = new System.Drawing.Point(591, 176);
            this.filter_position_label.Name = "filter_position_label";
            this.filter_position_label.Size = new System.Drawing.Size(62, 12);
            this.filter_position_label.TabIndex = 12;
            this.filter_position_label.Text = "フィルタ位置";
            // 
            // filter_position_x_label
            // 
            this.filter_position_x_label.AutoSize = true;
            this.filter_position_x_label.Location = new System.Drawing.Point(602, 196);
            this.filter_position_x_label.Name = "filter_position_x_label";
            this.filter_position_x_label.Size = new System.Drawing.Size(21, 12);
            this.filter_position_x_label.TabIndex = 13;
            this.filter_position_x_label.Text = "x : ";
            // 
            // filter_position_y_label
            // 
            this.filter_position_y_label.AutoSize = true;
            this.filter_position_y_label.Location = new System.Drawing.Point(721, 196);
            this.filter_position_y_label.Name = "filter_position_y_label";
            this.filter_position_y_label.Size = new System.Drawing.Size(21, 12);
            this.filter_position_y_label.TabIndex = 14;
            this.filter_position_y_label.Text = "y : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 15;
            // 
            // filter_size_label
            // 
            this.filter_size_label.AutoSize = true;
            this.filter_size_label.Location = new System.Drawing.Point(591, 268);
            this.filter_size_label.Name = "filter_size_label";
            this.filter_size_label.Size = new System.Drawing.Size(67, 12);
            this.filter_size_label.TabIndex = 16;
            this.filter_size_label.Text = "フィルタサイズ";
            // 
            // filter_size_width_label
            // 
            this.filter_size_width_label.AutoSize = true;
            this.filter_size_width_label.Location = new System.Drawing.Point(602, 286);
            this.filter_size_width_label.Name = "filter_size_width_label";
            this.filter_size_width_label.Size = new System.Drawing.Size(23, 12);
            this.filter_size_width_label.TabIndex = 17;
            this.filter_size_width_label.Text = "w : ";
            // 
            // filter_size_h_label
            // 
            this.filter_size_h_label.AutoSize = true;
            this.filter_size_h_label.Location = new System.Drawing.Point(719, 286);
            this.filter_size_h_label.Name = "filter_size_h_label";
            this.filter_size_h_label.Size = new System.Drawing.Size(21, 12);
            this.filter_size_h_label.TabIndex = 18;
            this.filter_size_h_label.Text = "h : ";
            // 
            // filter_strength_label
            // 
            this.filter_strength_label.AutoSize = true;
            this.filter_strength_label.Location = new System.Drawing.Point(591, 338);
            this.filter_strength_label.Name = "filter_strength_label";
            this.filter_strength_label.Size = new System.Drawing.Size(25, 12);
            this.filter_strength_label.TabIndex = 19;
            this.filter_strength_label.Text = "強さ";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(874, 477);
            this.Controls.Add(this.filter_strength_label);
            this.Controls.Add(this.filter_size_h_label);
            this.Controls.Add(this.filter_size_width_label);
            this.Controls.Add(this.filter_size_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filter_position_y_label);
            this.Controls.Add(this.filter_position_x_label);
            this.Controls.Add(this.filter_position_label);
            this.Controls.Add(this.filter_proc_label);
            this.Controls.Add(this.filetr_proc_strength);
            this.Controls.Add(this.filter_proc_list);
            this.Controls.Add(this.filter_scale_h);
            this.Controls.Add(this.filter_scale_w);
            this.Controls.Add(this.filter_pos_y);
            this.Controls.Add(this.filter_pos_x);
            this.Controls.Add(this.excutetion_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filetr_proc_strength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer paintingupdatetimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenImgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button excutetion_button;
        private System.Windows.Forms.TextBox resize_height;
        private System.Windows.Forms.TextBox resize_width;
        private System.Windows.Forms.Label resize_height_label;
        private System.Windows.Forms.Label resize_width_label;
        private System.Windows.Forms.TextBox CropStartPoints_y;
        private System.Windows.Forms.TextBox CropStartPoints_x;
        private System.Windows.Forms.TextBox CropEndPomints_x;
        private System.Windows.Forms.TextBox CropEndPoints_y;
        private System.Windows.Forms.TextBox CropResize_w;
        private System.Windows.Forms.TextBox CropResize_h;
        private System.Windows.Forms.Label Cropstart_label;
        private System.Windows.Forms.Label Cropend_label;
        private System.Windows.Forms.Label Crop_resize_label;
        private System.Windows.Forms.Label CropStartPoints_x_label;
        private System.Windows.Forms.Label CropStartPoints_y_label;
        private System.Windows.Forms.Label CropEndPoints_y_label;
        private System.Windows.Forms.Label CropEndPoints_x_label;
        private System.Windows.Forms.Label CropResize_h_label;
        private System.Windows.Forms.Label CropResize_w_label;
        private System.Windows.Forms.TextBox filter_pos_x;
        private System.Windows.Forms.TextBox filter_pos_y;
        private System.Windows.Forms.TextBox filter_scale_w;
        private System.Windows.Forms.TextBox filter_scale_h;
        private System.Windows.Forms.ComboBox filter_proc_list;
        private System.Windows.Forms.TrackBar filetr_proc_strength;
        private System.Windows.Forms.Label filter_proc_label;
        private System.Windows.Forms.Label filter_position_label;
        private System.Windows.Forms.Label filter_position_x_label;
        private System.Windows.Forms.Label filter_position_y_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label filter_size_label;
        private System.Windows.Forms.Label filter_size_width_label;
        private System.Windows.Forms.Label filter_size_h_label;
        private System.Windows.Forms.Label filter_strength_label;
    }
}

