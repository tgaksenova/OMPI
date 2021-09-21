﻿using System;
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
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

       private void ButtonRegistration_OnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxLogin.Text) || string.IsNullOrEmpty(PasswordBox.Password))
            {
                MessageBox.Show("Введите логин и пароль!");
                return;
            }
            var db = new Entities();
                var user = db.User
                    .AsNoTracking()
                    .FirstOrDefault(u => u.Login == TextBoxLogin.Text && u.Password == PasswordBox.Password);

                if (user == null)
                {
                    MessageBox.Show("Пользователь с такими данными не найден!");
                    return;

                }

                MessageBox.Show("Пользователь успешной найден!");

                switch (user.Role)
                {
                    case "Заказчик":
                        NavigationService?.Navigate(new Menu());
                    break;
                case "Директор":
                    NavigationService?.Navigate(new Menu());
                    break;
            }

            db.Dispose();
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Page2());
        }
    }
}
