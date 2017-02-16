using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class PersonalSite : Form
    {
        private string username;
        private int pwd;
        public string uname { get; set; }
        public int pw {
            get { return this.pwd; }
            set { pwd = value + 1; }
        }
        public PersonalSite()
        {
            InitializeComponent();
        }
        public PersonalSite(string n, int pw)
        {
            this.pw = pw;
            this.uname = n;
            InitializeComponent();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void PersonalSite_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hallo User");
            lblUser.Text = uname + " " + pw.ToString();
        }
    }
}
