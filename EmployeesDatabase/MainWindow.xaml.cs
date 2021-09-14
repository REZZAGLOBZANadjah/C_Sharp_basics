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
using System.Configuration;
namespace EmployeesDataBase
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DataBaseConnection dataBaseConn = new DataBaseConnection();
        public MainWindow()
        {
            InitializeComponent();
            DataGridAllEmp.ItemsSource = dataBaseConn.GetAllEmployees();
        }

        private void AddEmployeeBtn(object sender, RoutedEventArgs e)
        {

            if (!string.IsNullOrEmpty(firstNameTxt.Text)&&
                !string.IsNullOrEmpty(lastNameTxt.Text))
            {

            
                    dataBaseConn.AddEmployees(new Employee
                    {
                        firstName = firstNameTxt.Text,
                        lastName=lastNameTxt.Text,
                    });
                // clear first name and last name txtbox
                firstNameTxt.Text = "";
                lastNameTxt.Text = string.Empty;

                // update the data grid view 
                DataGridAllEmp.ItemsSource = dataBaseConn.GetAllEmployees();
                    }
        }

        private void SelectionEmp(object sender, SelectionChangedEventArgs e)
        {
            if (DataGridAllEmp.SelectedItems.Count>0)
            {
            var row = DataGridAllEmp.SelectedItems[0];
            var employee = (Employee)row;
            editID.Content = employee.id.ToString();
            editFirstNameTxt.Text = employee.firstName;
            editLastNameTxt.Text = employee.lastName;
            }
        }

        private void UpdateBtnclick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(editFirstNameTxt.Text)&&
               !string.IsNullOrEmpty(editLastNameTxt.Text))

            { 
                dataBaseConn.UpdateEmployees(new Employee
                {
                    id = int.Parse(editID.Content.ToString().Trim()),
                    firstName = editFirstNameTxt.Text.Trim(),
                    lastName = editLastNameTxt.Text.Trim(),
                }) ;
                // clear first name and last name txtbox
                editFirstNameTxt.Text = "";
                editLastNameTxt.Text = string.Empty;

                // update the data grid view 
                DataGridAllEmp.ItemsSource = dataBaseConn.GetAllEmployees();
            }

        }

        private void DeleteEmployee(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(editID.Content.ToString().Trim() ))

            {
                dataBaseConn.DeleteEmployees(int.Parse(editID.Content.ToString().Trim()));
               
                editFirstNameTxt.Text = string.Empty;
                editLastNameTxt.Text = string.Empty;
                DataGridAllEmp.ItemsSource = dataBaseConn.GetAllEmployees();
            }
        }
    }


    
}
