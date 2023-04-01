using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

namespace demopr30
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
                try
                {
                    var user = BD.db.Пользователи.FirstOrDefault(q => q.Логин.Equals(login.Text) && q.Пароль.Equals(password.Password)); //проверка логина и пароля
                if (user != null)
                {
                    Window newwindow = new tovar();
                    this.Close();
                    newwindow.Show(); //переход между формами
                }
                else
                    MessageBox.Show("Неверно введен логин или пароль"); //всплывающие окно с ошибкой
                }
                catch (Exception ex)
                {
                }
        }
    }
}
