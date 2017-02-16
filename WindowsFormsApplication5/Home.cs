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
    public partial class Home : Form
    {
       private List<User> userList = new List<User>();

        public Home()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User currentUser = new User();
            try
            {
              currentUser = new User(textUsername.Text, int.Parse(textPwd.Text));
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error Text: " + exc.Message);
            }
            
            try {
                /*
                 ul => ist wie eine Methode die als Parameter einen User übergibt (Inhalt der List) nach => werden alle user verglichen mit
                 current user
                 */
                if (userList.Any(ul => (ul.name == currentUser.name && ul.pwd == currentUser.pwd)))
                {
                    PersonalSite per = new PersonalSite(currentUser.name, currentUser.pwd);
                    per.Show();
                }
                else {
                    MessageBox.Show("User nicht vorhanden");
                }
            } catch(Exception exc){
                MessageBox.Show(exc.Message);
            }
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textPwd_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            try
            {
                User currentUser = new User(textUsername.Text, int.Parse(textPwd.Text));
                bool reg = false;
                foreach (User u in userList) { 
                    if (u.name.Equals(currentUser.name) && u.pwd.Equals(currentUser.pwd))
                    {
                        MessageBox.Show("Bereits registriert");
                        reg = true;
                        break;
                    }
                }
                if (reg == false)
                {
                     MessageBox.Show("Danke für die Registrierung");
                     userList.Add(new User(textUsername.Text, int.Parse(textPwd.Text)));
                    
                }
            }
            catch (Exception exc) {
                MessageBox.Show("Fehler beim registrieren", exc.Message);
            }
        }
    }
}
