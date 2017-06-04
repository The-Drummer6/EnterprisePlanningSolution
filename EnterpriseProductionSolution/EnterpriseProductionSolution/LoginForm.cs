
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterprisePlanningSolution
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
            usernameTextBox.Text = "";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.MaxLength = 14;
            usernameTextBox.Text = "";
            this.Disposed += new System.EventHandler(this.LoginForm_Disposed);
        }

        DashoardForm dashboardForm;

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void LoginForm_Disposed(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            string hashpw;
            string benutzer = usernameTextBox.Text;
            hashpw = GetMD5Hash(passwordTextBox.Text);

            //Recordset
            ADODB.Connection cn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();
            string cnStr;
            try
            {
                //Connection string.
                cnStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=PPS-Datenbank.mdb";
                cn.Open(cnStr);

                rs.Open("Select * From Login where benutzer ='" + usernameTextBox.Text + "';", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                if (rs.Fields["passwort"].Value == hashpw)
                {
                    dashboardForm = new DashoardForm();
                    dashboardForm.Show();
                    this.Hide();
                }
                else { MessageBox.Show("Falsches Passwort!"); }
            }
            catch (Exception fehler)
            {
                MessageBox.Show("Logindaten sind nicht korrekt" + fehler);
            }
            finally
            {
                cn.Close();
            }
        }
        public static string GetMD5Hash(string value)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                // ANSI (varchar)
                var valueBytes = Encoding.Default.GetBytes(value);
                var md5HashBytes = md5.ComputeHash(valueBytes);
                var builder = new StringBuilder(md5HashBytes.Length * 2);
                foreach (var md5Byte in md5HashBytes)
                    builder.Append(md5Byte.ToString("X2"));
                return builder.ToString();
            }
        }
    }
}
