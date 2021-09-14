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

namespace WpfAppGUIDataGridAndObjects
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Student> students = new List<Student>();

            students.Add(new Student() { ID = 1, name = "Rezzag lobza Nadjah", age = 29, mail = "rezzaglobza7@gmail.com", BirthDay = new DateTime(1991, 10, 14) });
            students.Add(new Student() { ID = 2, name = "Hadjer moussaoui", age = 26, mail = "rezzaglobza7@gmail.com", BirthDay = new DateTime(1991, 3, 15)});
            students.Add(new Student() { ID = 3, name = "khaled essa", age = 24, mail = "rezzaglobza7@gmail.com" , BirthDay = new DateTime(1991, 1, 16) });
            students.Add(new Student() { ID = 4, name = "amine ali", age = 30, mail = "rezzaglobza7@gmail.com" , BirthDay = new DateTime(1991, 2, 20) });
            students.Add(new Student() { ID = 5, name = "Yosr rezzag lobza", age = 18, mail = "rezzaglobza7@gmail.com" , BirthDay = new DateTime(1991, 9, 30) });
            students.Add(new Student() { ID = 6, name = "manal khlif", age = 16, mail = "rezzaglobza7@gmail.com" , BirthDay = new DateTime(1991, 7, 01) });
            students.Add(new Student() { ID = 7, name = "najat bella", age = 46, mail = "rezzaglobza7@gmail.com" , BirthDay = new DateTime(1991, 5, 12) });
            students.Add(new Student() { ID = 8, name = "tahar bia", age = 49, mail = "rezzaglobza7@gmail.com" , BirthDay = new DateTime(1991, 1, 06) });
            dataGridStudent.ItemsSource = students;


        }
    }

    public class Student {
        public int ID { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public DateTime BirthDay { get; set; }
        public string mail { get; set; }


    }
}
