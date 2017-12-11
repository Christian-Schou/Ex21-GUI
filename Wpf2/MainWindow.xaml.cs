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

namespace Wpf2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void new_Click(object sender, RoutedEventArgs e)
        {
            var controller = Controler.GetInstance();
            controller.AddPerson();
            controller.CurentPerson.FirstName = firstnameTextBox.Text;
            controller.CurentPerson.LastName = lastnameTextBox.Text;
            controller.CurentPerson.Age = int.Parse(ageTextBox.Text);
            controller.CurentPerson.TelephoneNr = telephonenrTextBox.Text;

            this.personCountInt.Text = controller.PerconCount.ToString();
            this.indexCountInt.Text = controller.PersonIndex.ToString();
        }

        private void up_Click(object sender, RoutedEventArgs e)
        {
            var controller = Controler.GetInstance();
            controller.NextPerson();
            firstnameTextBox.Text = controller.CurentPerson.FirstName;
            lastnameTextBox.Text = controller.CurentPerson.LastName;
            ageTextBox.Text = controller.CurentPerson.Age.ToString();
            telephonenrTextBox.Text = controller.CurentPerson.TelephoneNr;

            this.personCountInt.Text = controller.PerconCount.ToString();
            this.indexCountInt.Text = controller.PersonIndex.ToString();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            var controller = Controler.GetInstance();
            controller.DeletePerson();
            controller.CurentPerson.FirstName = firstnameTextBox.Text;
            controller.CurentPerson.LastName = lastnameTextBox.Text;
            controller.CurentPerson.Age = int.Parse(ageTextBox.Text);
            controller.CurentPerson.TelephoneNr = telephonenrTextBox.Text;

            this.personCountInt.Text = controller.PerconCount.ToString();
            this.indexCountInt.Text = controller.PersonIndex.ToString();
        }

        private void down_Click(object sender, RoutedEventArgs e)
        {
            var controller = Controler.GetInstance();
            controller.PrevPerson();
            firstnameTextBox.Text = controller.CurentPerson.FirstName;
            lastnameTextBox.Text = controller.CurentPerson.LastName;
            ageTextBox.Text = controller.CurentPerson.Age.ToString();
            telephonenrTextBox.Text = controller.CurentPerson.TelephoneNr;

            this.personCountInt.Text = controller.PerconCount.ToString();
            this.indexCountInt.Text = controller.PersonIndex.ToString();
        }
    }
}
