using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZYPasswordManager.ZYPM.UI;

namespace ZYPasswordManager
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init_dgv_zhlb();

            Init_treeview_pingtai();
            //Init_lv_zhlb();
        }

        private void 添加账号信息ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_AddAccount frm = new Frm_AddAccount();
            frm.ShowDialog();
        }

        //private void Init_lv_zhlb()
        //{
        //    this.lv_zhlb.Items.Clear();  //先移除所有的项，避免重复添加
        //    this.lv_zhlb.View = View.Details;

        //    ACC01Repository repository = new ACC01Repository();
        //    IList<ACC01> list = repository.GetACC01Infos();
        //    foreach (ACC01 acc01 in list)
        //    {
        //        //创建项
        //        ListViewItem item = new ListViewItem(acc01.PingTai);

        //        //给每一项里面添加信息
        //        item.SubItems.Add(acc01.PingTai_BuChong);
        //        item.SubItems.Add(acc01.LogonName);
        //        item.SubItems.Add(acc01.Password);
        //        item.SubItems.Add(acc01.Telephone);
        //        item.SubItems.Add(acc01.Url);
        //        item.SubItems.Add(acc01.Email);
        //        item.SubItems.Add(acc01.IsLock.ToString());
        //        lv_zhlb.Items.Add(item);
        //    }
        //}

        #region datagridview初始化
        private void Init_dgv_zhlb()
        {
            InitData_dgv_zhlb();

            InitDisplay_dgv_zhlb();
        }

        private void InitData_dgv_zhlb()
        {
            //获取多个对象
            ACC01Repository repository = new ACC01Repository();
            dgv_zhlb.DataSource = repository.GetACC01Infos();

            dgv_zhlb.ReadOnly = true;
        }

        private void InitDisplay_dgv_zhlb()
        {
            // 禁止用户改变DataGridView1的所有列的列宽
            dgv_zhlb.AllowUserToResizeColumns = false;
            //禁止用户改变DataGridView1d的所有行的行高
            dgv_zhlb.AllowUserToResizeRows = false;

            // 列头隐藏
            //dgv_zhlb.ColumnHeadersVisible = false;
            // 行头隐藏
            dgv_zhlb.RowHeadersVisible = false;

            // DataGridView1的第一列隐藏
            //dgv_zhlb.Columns[0].Visible = false;
            // DataGridView1的第一行隐藏
            //dgv_zhlb.Rows[0].Visible = false;

            // 设置用户不能手动给 DataGridView1 添加新行
            dgv_zhlb.AllowUserToAddRows = false;
        }

        #endregion

        #region treeview初始化
        private void Init_treeview_pingtai()
        {
            InitData_treeview_pingtai();

            InitDisplay_treeview_pingtai();
        }

        private void InitDisplay_treeview_pingtai()
        {
            //设置树形组件的基础属性
            treeview_pingtai.CheckBoxes = true;
            treeview_pingtai.FullRowSelect = true;
            treeview_pingtai.Indent = 30;
            treeview_pingtai.ItemHeight = 20;
            treeview_pingtai.LabelEdit = false;//不可编辑
            treeview_pingtai.Scrollable = true;
            treeview_pingtai.ShowPlusMinus = true;
            treeview_pingtai.ShowRootLines = true;
            treeview_pingtai.ImageList = imageList_pingtai;
        }

        private void InitData_treeview_pingtai()
        {
            //添加根节点
            TreeNode root = new TreeNode();
            root.Text = "全部";
            root.ImageIndex = 0;

            try
            {
                PingTaiRepository ptrepository = new PingTaiRepository();
                IList<PingTai> list=ptrepository.GetPingTaiInfos();
                foreach (PingTai pt in list)
                {
                    TreeNode tempnode = new TreeNode();
                    tempnode.Text = pt.Dmcpt;
                    tempnode.Tag = pt.Dmcod;
                    tempnode.ImageIndex =int.Parse(pt.Dmcod);
                    root.Nodes.Add(tempnode);
                    treeview_pingtai.Nodes.Add(root);
                }
            }
            catch (Exception ex)
            { }
        }


        #endregion

        private void dgv_zhlb_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }
    }
}
