using _1pract.Pages;
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
using System.IO; //для осуществления чтения/записи в файл
using System.Diagnostics; //для запуска Блокнота
using Microsoft.Win32;

namespace _1pract
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

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoBack) MainFrame.GoBack();
        }

        private void MainFrame_OnNavigated(object sender, NavigationEventArgs e)
        {
            if (!(e.Content is Page page)) return;
            this.Title = $"LESSON - {page.Title}";

            if (page is AuthPage)
            {
                ButtonBack.Visibility = Visibility.Hidden;
            }
            else
            {
                ButtonBack.Visibility = Visibility.Visible;
            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Export();


        }
        void Export()
        {
            string path = "export.txt";
            StreamWriter sw = new StreamWriter(path);
            using (var db = new Entities())
            {
                var user = db.User
                      .AsNoTracking()
                      .FirstOrDefault();


                string IDline = String.Join(":", db.User.Select(x => x.ID));
                sw.WriteLine(IDline);
                string FIOline = String.Join(":", db.User.Select(x => x.FIO));
                sw.WriteLine(FIOline);
                string Roleline = String.Join(":", db.User.Select(x => x.Role));
                sw.WriteLine(Roleline);
                string Passline = String.Join(":", db.User.Select(x => x.Password));
                sw.WriteLine(Passline);
                string Logline = String.Join(":", db.User.Select(x => x.Login));
                sw.WriteLine(Logline);

                Process.Start("notepad.exe", path);
                StreamWriter SW;
                SaveFileDialog SFD = new SaveFileDialog();
                SFD.FileName = "MyTXT";
                SFD.Filter = "TXT (*.txt)|*.txt|RTF (*.rtf)|*.rtf";
                sw.Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Import();




        }
        void Import()
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName != "") // проверка на выбор файла
            {
            }
            else MessageBox.Show("Файл для импорта не выбран!");

            StreamReader sr = new StreamReader(ofd.FileName); // открываем файл
            while (!sr.EndOfStream) // перебираем строки, пока они не закончены
            {
                string[] lines = new string[5];// массив данных 
                for (int i = 0; i < 5; i++) // читаем 5 строк 
                {
                    string line = sr.ReadLine(); // читаем строку  
                    string[] data = line.Split(':');
                    line = ""; // обнуляем переменную    
                    if (data.Length >= 2) // проверяем на целостность данных  
                    {
                        for (int j = 1; j < data.Length; j++) // складываем данные      
                        {
                            line += data[j]; // собираем строку  
                        }
                    }
                    lines[i] = line; // записываем значения в массив 
                }
                // выводим данные 
                MessageBox.Show("Данные в файле: \nID: " + lines[0] + "\nФИО: " + lines[1] + "\nЛогин: " + lines[2] + "\nПароль: " + lines[3] + "\nРоль: " + lines[4]);
            }

        }
    }
}
