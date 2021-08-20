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
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(570, 578);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Resize",
            "XXX"});
            this.comboBox1.Location = new System.Drawing.Point(604, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 20);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropOpen);
            this.comboBox1.DropDownClosed += new System.EventHandler(this.comboBox1_Dropclosed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "実行する処理";
            // 
            // excutetion_button
            // 
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
            this.resize_height_label.Text = "高さ";
            // 
            // resize_width_label
            // 
            this.resize_width_label.AutoSize = true;
            this.resize_width_label.Location = new System.Drawing.Point(714, 159);
            this.resize_width_label.Name = "resize_width_label";
            this.resize_width_label.Size = new System.Drawing.Size(27, 12);
            this.resize_width_label.TabIndex = 8;
            this.resize_width_label.Text = "x 幅";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(874, 606);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
    }
}

