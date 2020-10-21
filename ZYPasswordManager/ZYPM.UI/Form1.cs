using System;
using System.Windows.Forms;

namespace ZYPasswordManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ////关闭会话对象
            //session.Close();
            //A01Repository a01Repository = new A01Repository();
            //A01 a01temp=a01Repository.GetA01Info(new Guid("C99FB661-1172-4509-A5C3-A246EE8F6D3F"));
            //dataGridView1.Rows[0].Cells[0].Value = a01temp.A00.ToString();
            //dataGridView1.Rows[0].Cells[1].Value = a01temp.A0101.ToString();
            //dataGridView1.Rows[0].Cells[2].Value = a01temp.A0104.ToString();

            //获取多个对象
            //ACC01Repository repository = new ACC01Repository();
            //dgv_zhlb.DataSource = repository.GetACC01Infos();
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

        private void button1_Click(object sender, EventArgs e)
        {
            A01 a01 = new A01(a00: Guid.NewGuid(), a0101: "5678", a0104: "1");
            A01Repository a01Repository = new A01Repository();
            a01Repository.Add(a01);
        }

        private void button1_Click_1(object sender, EventArgs e)
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
    }
}
