using DE.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace DE
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        public static Models.User User { get; set; }
        public Form1()
        {
            InitializeComponent();
            Instance = this;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            using (De17BdContext db = new De17BdContext())
            {
                Models.User user = db.Users.FirstOrDefault(p => p.Login == textBoxLogin.Text && p.Password == textBoxPassword.Text)!;

                if (user != null)
                {
                    User = user;
                    Main mainForm = new Main();
                    mainForm.Show();
                    this.Hide();
                }
                else MessageBox.Show("Не правильный логин или пароль");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Models.User user=new Models.User();
            user.Role = "Авторизированный клиент";
            user.SurName = "";
            user.LastName = "";
            user.FirstName = "";
            user.Password = "";
            User = user;
            Main mainForm = new Main();
            mainForm.Show();
            this.Hide();
        }
    }
}
