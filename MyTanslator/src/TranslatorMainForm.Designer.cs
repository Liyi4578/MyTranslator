namespace MyTanslator
{
    partial class TranslatorMainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranslatorMainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBtn_merge = new System.Windows.Forms.ToolStripButton();
            this.toolBtn_translate = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox_sourceLang = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox_dstLang = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton_setting = new System.Windows.Forms.ToolStripButton();
            this.textBox_main = new System.Windows.Forms.TextBox();
            this.splitContainer_main = new System.Windows.Forms.SplitContainer();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.contextMenuStrip_result = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_foldResult = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_main)).BeginInit();
            this.splitContainer_main.Panel1.SuspendLayout();
            this.splitContainer_main.Panel2.SuspendLayout();
            this.splitContainer_main.SuspendLayout();
            this.contextMenuStrip_result.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowMerge = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtn_merge,
            this.toolBtn_translate,
            this.toolStripComboBox_sourceLang,
            this.toolStripLabel1,
            this.toolStripComboBox_dstLang,
            this.toolStripButton_setting});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(943, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolBtn_merge
            // 
            this.toolBtn_merge.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtn_merge.Image = ((System.Drawing.Image)(resources.GetObject("toolBtn_merge.Image")));
            this.toolBtn_merge.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtn_merge.Name = "toolBtn_merge";
            this.toolBtn_merge.Size = new System.Drawing.Size(82, 32);
            this.toolBtn_merge.Text = "Merge";
            this.toolBtn_merge.Click += new System.EventHandler(this.toolBtn_merge_Click);
            // 
            // toolBtn_translate
            // 
            this.toolBtn_translate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtn_translate.Image = ((System.Drawing.Image)(resources.GetObject("toolBtn_translate.Image")));
            this.toolBtn_translate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtn_translate.Name = "toolBtn_translate";
            this.toolBtn_translate.Size = new System.Drawing.Size(109, 32);
            this.toolBtn_translate.Text = "Translate";
            this.toolBtn_translate.Click += new System.EventHandler(this.toolBtn_translate_Click);
            // 
            // toolStripComboBox_sourceLang
            // 
            this.toolStripComboBox_sourceLang.Name = "toolStripComboBox_sourceLang";
            this.toolStripComboBox_sourceLang.Size = new System.Drawing.Size(121, 38);
            this.toolStripComboBox_sourceLang.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_SelectedIndexChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 32);
            this.toolStripLabel1.Text = "->";
            // 
            // toolStripComboBox_dstLang
            // 
            this.toolStripComboBox_dstLang.Name = "toolStripComboBox_dstLang";
            this.toolStripComboBox_dstLang.Size = new System.Drawing.Size(121, 38);
            this.toolStripComboBox_dstLang.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_SelectedIndexChanged);
            // 
            // toolStripButton_setting
            // 
            this.toolStripButton_setting.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_setting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_setting.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_setting.Image")));
            this.toolStripButton_setting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_setting.Name = "toolStripButton_setting";
            this.toolStripButton_setting.Size = new System.Drawing.Size(40, 32);
            this.toolStripButton_setting.Text = "setting";
            this.toolStripButton_setting.Click += new System.EventHandler(this.toolStripButton_setting_Click);
            // 
            // textBox_main
            // 
            this.textBox_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_main.Location = new System.Drawing.Point(0, 0);
            this.textBox_main.Multiline = true;
            this.textBox_main.Name = "textBox_main";
            this.textBox_main.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_main.Size = new System.Drawing.Size(943, 214);
            this.textBox_main.TabIndex = 1;
            // 
            // splitContainer_main
            // 
            this.splitContainer_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_main.Location = new System.Drawing.Point(0, 38);
            this.splitContainer_main.Name = "splitContainer_main";
            this.splitContainer_main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_main.Panel1
            // 
            this.splitContainer_main.Panel1.Controls.Add(this.textBox_main);
            this.splitContainer_main.Panel1MinSize = 100;
            // 
            // splitContainer_main.Panel2
            // 
            this.splitContainer_main.Panel2.Controls.Add(this.textBox_result);
            this.splitContainer_main.Panel2MinSize = 3;
            this.splitContainer_main.Size = new System.Drawing.Size(943, 505);
            this.splitContainer_main.SplitterDistance = 214;
            this.splitContainer_main.TabIndex = 2;
            // 
            // textBox_result
            // 
            this.textBox_result.ContextMenuStrip = this.contextMenuStrip_result;
            this.textBox_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_result.Location = new System.Drawing.Point(0, 0);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_result.Size = new System.Drawing.Size(943, 287);
            this.textBox_result.TabIndex = 0;
            // 
            // contextMenuStrip_result
            // 
            this.contextMenuStrip_result.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip_result.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_foldResult});
            this.contextMenuStrip_result.Name = "contextMenuStrip_result";
            this.contextMenuStrip_result.Size = new System.Drawing.Size(128, 38);
            // 
            // ToolStripMenuItem_foldResult
            // 
            this.ToolStripMenuItem_foldResult.Name = "ToolStripMenuItem_foldResult";
            this.ToolStripMenuItem_foldResult.Size = new System.Drawing.Size(127, 34);
            this.ToolStripMenuItem_foldResult.Text = "Fold";
            this.ToolStripMenuItem_foldResult.Click += new System.EventHandler(this.ToolStripMenuItem_foldResult_Click);
            // 
            // TranslatorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 543);
            this.Controls.Add(this.splitContainer_main);
            this.Controls.Add(this.toolStrip1);
            this.Name = "TranslatorMainForm";
            this.Text = "MyTranslator";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer_main.Panel1.ResumeLayout(false);
            this.splitContainer_main.Panel1.PerformLayout();
            this.splitContainer_main.Panel2.ResumeLayout(false);
            this.splitContainer_main.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_main)).EndInit();
            this.splitContainer_main.ResumeLayout(false);
            this.contextMenuStrip_result.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolBtn_merge;
        private System.Windows.Forms.TextBox textBox_main;
        private System.Windows.Forms.SplitContainer splitContainer_main;
        private System.Windows.Forms.ToolStripButton toolBtn_translate;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_result;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_foldResult;
        private System.Windows.Forms.ToolStripButton toolStripButton_setting;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_sourceLang;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_dstLang;
    }
}

