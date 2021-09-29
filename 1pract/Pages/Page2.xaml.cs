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

namespace _1pract.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new AuthPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Login.Text) || string.IsNullOrEmpty(Passwords.Password) || string.IsNullOrEmpty(RepPass.Password) || string.IsNullOrEmpty(FIO.Text))
            {
                MessageBox.Show("Заполните все поля");
            }

            else if (Passwords.Password.Length >= 6)
            {
                bool en = true; // английская раскладка
                bool number = false; // цифра

                for (int i = 0; i < Passwords.Password.Length; i++) // перебираем символы
                {
                    if (Passwords.Password[i] >= 'А' && Passwords.Password[i] <= 'Я') en = false; // если русская раскладка
                    if (Passwords.Password[i] >= '0' && Passwords.Password[i] <= '9') number = true; // если цифры
                }

                if (!en)
                    MessageBox.Show("Доступна только английская раскладка"); // выводим сообщение
                else if (!number)
                    MessageBox.Show("Добавьте хотя бы одну цифру"); // выводим сообщение
                else if (Passwords.Password == RepPass.Password) // проверка на совпадение паролей
                {
                    MessageBox.Show("Пользователь зарегистрирован");

                    Entities db = new Entities();
                    User userObject = new User
                    {
                        FIO = FIO.Text,
                        Login = Login.Text,
                        Password = Passwords.Password,
                        Role = Role.Text
                    };
                    db.User.Add(userObject);
                    db.SaveChanges();

                }
                else MessageBox.Show("Пароли не совподают");
            }
            else MessageBox.Show("пароль слишком короткий, минимум 6 символов");

        }
    }
}