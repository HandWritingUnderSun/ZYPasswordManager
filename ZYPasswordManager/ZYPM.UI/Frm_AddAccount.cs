using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZYPasswordManager.ZYPM.UI
{
    public partial class Frm_AddAccount : Form
    {
        public Frm_AddAccount()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ACC01 aCC01 = new ACC01();
            aCC01.PingTai = cb_pingtai.SelectedValue.ToString();
            aCC01.PingTai_BuChong = tb_pingtaibuchong.Text.ToString();
            aCC01.Rid = Guid.NewGuid();
            aCC01.Password = tb_password.Text.ToString();
            aCC01.LogonName = tb_logonname.Text.ToString();
            aCC01.Telephone = tb_telephone.Text.ToString();
            aCC01.Email = tb_email.Text.ToString();
            aCC01.Url = tb_url.Text.ToString();

            ACC01Repository aCC01Repository = new ACC01Repository();
            aCC01Repository.Add(aCC01);
        }

        private void Frm_AddAccount_Load(object sender, EventArgs e)
        {

        }

        private void Init_cb_pingtai()
        {
            try
            {
                PingTaiRepository ptrepository = new PingTaiRepository();
                cb_pingtai.DataSource = ptrepository.GetPingTaiInfos();
                cb_pingtai.DisplayMember = "dmcpt";
                cb_pingtai.ValueMember = "dmcod";
            }
            catch (Exception ex)
            { }
        }

        private void Init_cb_islock()
        {
            try
            {
                JBC01Repository jbc01repository = new JBC01Repository();
                cb_islock.DataSource = jbc01repository.GetJBC01Infos();
                cb_islock.DisplayMember = "dmcpt";
                cb_islock.ValueMember = "dmcod";
            }
            catch (Exception ex)
            { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MD5Algorithm mD5Algorithm = new MD5Algorithm();
            textBox1.Text = mD5Algorithm.ToMD5(tb_password.Text);
        }
    }
}
