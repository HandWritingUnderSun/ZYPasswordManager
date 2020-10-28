namespace ZYPM.UI
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加账号信息ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.添加账号信息ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeview_pingtai = new System.Windows.Forms.TreeView();
            this.dgv_zhlb = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.imageList_pingtai = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_zhlb)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 开始ToolStripMenuItem
            // 
            this.开始ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.添加账号信息ToolStripMenuItem,
            this.添加账号信息ToolStripMenuItem1});
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            this.开始ToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.开始ToolStripMenuItem.Text = "开始";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.新建ToolStripMenuItem.Text = "新建";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.打开ToolStripMenuItem.Text = "打开";
            // 
            // 添加账号信息ToolStripMenuItem
            // 
            this.添加账号信息ToolStripMenuItem.Name = "添加账号信息ToolStripMenuItem";
            this.添加账号信息ToolStripMenuItem.Size = new System.Drawing.Size(159, 6);
            // 
            // 添加账号信息ToolStripMenuItem1
            // 
            this.添加账号信息ToolStripMenuItem1.Name = "添加账号信息ToolStripMenuItem1";
            this.添加账号信息ToolStripMenuItem1.Size = new System.Drawing.Size(162, 24);
            this.添加账号信息ToolStripMenuItem1.Text = "添加账号信息";
            this.添加账号信息ToolStripMenuItem1.Click += new System.EventHandler(this.添加账号信息ToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 30);
            this.panel1.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 30);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.statusStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 552);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 30);
            this.panel3.TabIndex = 8;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeview_pingtai);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_zhlb);
            this.splitContainer1.Size = new System.Drawing.Size(984, 522);
            this.splitContainer1.SplitterDistance = 218;
            this.splitContainer1.TabIndex = 4;
            // 
            // treeview_pingtai
            // 
            this.treeview_pingtai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeview_pingtai.Location = new System.Drawing.Point(0, 0);
            this.treeview_pingtai.Name = "treeview_pingtai";
            this.treeview_pingtai.Size = new System.Drawing.Size(218, 522);
            this.treeview_pingtai.TabIndex = 0;
            // 
            // dgv_zhlb
            // 
            this.dgv_zhlb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_zhlb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_zhlb.Location = new System.Drawing.Point(0, 0);
            this.dgv_zhlb.Name = "dgv_zhlb";
            this.dgv_zhlb.RowTemplate.Height = 23;
            this.dgv_zhlb.Size = new System.Drawing.Size(762, 522);
            this.dgv_zhlb.TabIndex = 3;
            this.dgv_zhlb.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgv_zhlb_RowStateChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.splitContainer1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(984, 522);
            this.panel4.TabIndex = 9;
            // 
            // imageList_pingtai
            // 
            this.imageList_pingtai.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_pingtai.ImageStream")));
            this.imageList_pingtai.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_pingtai.Images.SetKeyName(0, "全部.png");
            this.imageList_pingtai.Images.SetKeyName(1, "QQ.png");
            this.imageList_pingtai.Images.SetKeyName(2, "微信.png");
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 582);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_zhlb)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator 添加账号信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加账号信息ToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgv_zhlb;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TreeView treeview_pingtai;
        private System.Windows.Forms.ImageList imageList_pingtai;
    }
}

