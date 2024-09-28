namespace MyTanslator
{
    partial class ConfigForm
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer_vertical = new System.Windows.Forms.SplitContainer();
            this.splitContainer1_horizontal = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox_main = new System.Windows.Forms.GroupBox();
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_quit = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_vertical)).BeginInit();
            this.splitContainer_vertical.Panel1.SuspendLayout();
            this.splitContainer_vertical.Panel2.SuspendLayout();
            this.splitContainer_vertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1_horizontal)).BeginInit();
            this.splitContainer1_horizontal.Panel1.SuspendLayout();
            this.splitContainer1_horizontal.Panel2.SuspendLayout();
            this.splitContainer1_horizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer_vertical
            // 
            this.splitContainer_vertical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer_vertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_vertical.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer_vertical.IsSplitterFixed = true;
            this.splitContainer_vertical.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_vertical.Name = "splitContainer_vertical";
            this.splitContainer_vertical.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_vertical.Panel1
            // 
            this.splitContainer_vertical.Panel1.Controls.Add(this.splitContainer1_horizontal);
            this.splitContainer_vertical.Panel1MinSize = 100;
            // 
            // splitContainer_vertical.Panel2
            // 
            this.splitContainer_vertical.Panel2.Controls.Add(this.button_confirm);
            this.splitContainer_vertical.Panel2.Controls.Add(this.button_quit);
            this.splitContainer_vertical.Size = new System.Drawing.Size(1054, 658);
            this.splitContainer_vertical.SplitterDistance = 588;
            this.splitContainer_vertical.TabIndex = 0;
            // 
            // splitContainer1_horizontal
            // 
            this.splitContainer1_horizontal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1_horizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1_horizontal.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1_horizontal.IsSplitterFixed = true;
            this.splitContainer1_horizontal.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1_horizontal.Name = "splitContainer1_horizontal";
            // 
            // splitContainer1_horizontal.Panel1
            // 
            this.splitContainer1_horizontal.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer1_horizontal.Panel2
            // 
            this.splitContainer1_horizontal.Panel2.Controls.Add(this.groupBox_main);
            this.splitContainer1_horizontal.Panel2MinSize = 100;
            this.splitContainer1_horizontal.Size = new System.Drawing.Size(1054, 588);
            this.splitContainer1_horizontal.SplitterDistance = 200;
            this.splitContainer1_horizontal.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("宋体", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 37;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(198, 586);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // groupBox_main
            // 
            this.groupBox_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_main.Location = new System.Drawing.Point(0, 0);
            this.groupBox_main.Name = "groupBox_main";
            this.groupBox_main.Size = new System.Drawing.Size(848, 586);
            this.groupBox_main.TabIndex = 0;
            this.groupBox_main.TabStop = false;
            this.groupBox_main.Text = "groupBox1";
            // 
            // button_confirm
            // 
            this.button_confirm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_confirm.Location = new System.Drawing.Point(755, 4);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.button_confirm.Size = new System.Drawing.Size(106, 57);
            this.button_confirm.TabIndex = 1;
            this.button_confirm.Text = "Confirm";
            this.button_confirm.UseVisualStyleBackColor = true;
            // 
            // button_quit
            // 
            this.button_quit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_quit.Location = new System.Drawing.Point(911, 4);
            this.button_quit.Name = "button_quit";
            this.button_quit.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.button_quit.Size = new System.Drawing.Size(106, 57);
            this.button_quit.TabIndex = 0;
            this.button_quit.Text = "Cancel";
            this.button_quit.UseVisualStyleBackColor = true;
            this.button_quit.Click += new System.EventHandler(this.button_quit_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 658);
            this.Controls.Add(this.splitContainer_vertical);
            this.Name = "ConfigForm";
            this.Text = "ConfigForm";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.splitContainer_vertical.Panel1.ResumeLayout(false);
            this.splitContainer_vertical.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_vertical)).EndInit();
            this.splitContainer_vertical.ResumeLayout(false);
            this.splitContainer1_horizontal.Panel1.ResumeLayout(false);
            this.splitContainer1_horizontal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1_horizontal)).EndInit();
            this.splitContainer1_horizontal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_vertical;
        private System.Windows.Forms.SplitContainer splitContainer1_horizontal;
        private System.Windows.Forms.GroupBox groupBox_main;
        private System.Windows.Forms.Button button_quit;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ListBox listBox1;
    }
}