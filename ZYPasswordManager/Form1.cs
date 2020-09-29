using FirstNhibernateDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //A01 a01 = new A01(a00: Guid.NewGuid(), a0101: "1234", a0104: "1", a0107: DateTime.Now);
            //A01Repository a01Repository = new A01Repository();
            //a01Repository.Add(a01);

            AccountRepository ar = new AccountRepository();
            dgv_Accountlist.DataSource=ar.
        }
    }
}
