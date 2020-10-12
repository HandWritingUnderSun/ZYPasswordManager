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
            ////A01 a01 = new A01(a00: Guid.NewGuid(), a0101: "1234", a0104: "1", a0107: DateTime.Now);
            ////A01Repository a01Repository = new A01Repository();
            ////a01Repository.Add(a01);

            ////会话工厂
            //ISessionFactory factory = null;
            //Configuration cfg = new Configuration().Configure();
            ////构建配置文件的对象
            //factory = cfg.BuildSessionFactory();
            ////实例化会话工厂
            //ISession session = factory.OpenSession();
            ////设定HQL查询语句，HQL语句只能用于查询
            ////注意，这里的表名不是数据库的表名，是你的实体类的名称（User）
            ////IQuery query = session.CreateQuery("from A01");
            ////得到结果集
            ////IList<A01> list = query.List<A01>();

            //ICriteria criteria = session.CreateCriteria<A01>();
            //IList<A01> list = criteria.List<A01>().ToList();

            ////关闭会话对象
            //session.Close();
            A01Repository a01Repository = new A01Repository();
            A01 a01temp=a01Repository.GetA01Info(new Guid("C99FB661-1172-4509-A5C3-A246EE8F6D3F"));
            dataGridView1.Rows[0].Cells[0].Value = a01temp.A00.ToString();
            dataGridView1.Rows[0].Cells[1].Value = a01temp.A0101.ToString();
            dataGridView1.Rows[0].Cells[2].Value = a01temp.A0104.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            A01 a01 = new A01(a00: Guid.NewGuid(), a0101: "1234", a0104: "1");
            A01Repository a01Repository = new A01Repository();
            a01Repository.Add(a01);
        }
    }
}
