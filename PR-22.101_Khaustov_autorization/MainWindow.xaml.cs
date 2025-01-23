using PR_22._101_Khaustov_autorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PR_22._101_Khaustov_autorization
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void btnAutorization_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (AutorizationEntities db = new AutorizationEntities())
                {
                    var staff = db.Staffs.FirstOrDefault(x => x.username == tbLogin.Text && x.password == pswbPassword.Password);

                    if (staff != null)
                    {
                        var staffRole = db.Role.FirstOrDefault(x => x.id_role == staff.id_role);

                        MessageBox.Show($"Ваша роль: {staffRole.role_name}");
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
