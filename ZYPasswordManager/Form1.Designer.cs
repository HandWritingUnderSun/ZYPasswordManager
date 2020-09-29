namespace ZYPasswordManager
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_Accountlist = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Abstract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Accountlist)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 开始ToolStripMenuItem
            // 
            this.开始ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.打开ToolStripMenuItem});
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            this.开始ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.开始ToolStripMenuItem.Text = "开始";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.新建ToolStripMenuItem.Text = "新建";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            // 
            // dgv_Accountlist
            // 
            this.dgv_Accountlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Accountlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.名称,
            this.C_Account,
            this.C_Password,
            this.C_Abstract});
            this.dgv_Accountlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Accountlist.Location = new System.Drawing.Point(0, 25);
            this.dgv_Accountlist.Name = "dgv_Accountlist";
            this.dgv_Accountlist.RowTemplate.Height = 23;
            this.dgv_Accountlist.Size = new System.Drawing.Size(800, 425);
            this.dgv_Accountlist.TabIndex = 1;
            // 
            // 序号
            // 
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            // 
            // 名称
            // 
            this.名称.HeaderText = "名称";
            this.名称.Name = "名称";
            // 
            // C_Account
            // 
            this.C_Account.HeaderText = "账号";
            this.C_Account.Name = "C_Account";
            // 
            // C_Password
            // 
            this.C_Password.HeaderText = "密码";
            this.C_Password.Name = "C_Password";
            // 
            // C_Abstract
            // 
            this.C_Abstract.HeaderText = "备注";
            this.C_Abstract.Name = "C_Abstract";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Accountlist);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Accountlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_Accountlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Abstract;
    }
}

