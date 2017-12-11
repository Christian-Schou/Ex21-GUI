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
            //Using the singleton instance and instantiating the Controler.CS
            var controller = Controler.GetInstance();
            //Calling the addperson method in Controler.CS
            controller.AddPerson();
            //Data for person to add
            controller.CurentPerson.FirstName = firstnameTextBox.Text;
            controller.CurentPerson.LastName = lastnameTextBox.Text;
            controller.CurentPerson.Age = int.Parse(ageTextBox.Text);
            controller.CurentPerson.TelephoneNr = telephonenrTextBox.Text;

            //Update counters in application
            this.personCountInt.Text = controller.PerconCount.ToString();
            this.indexCountInt.Text = controller.PersonIndex.ToString();
        }

        private void up_Click(object sender, RoutedEventArgs e)
        {
            //Using the singleton instance and instantiating the Controler.CS
            var controller = Controler.GetInstance();
            //Asking for the next person in Controler.CS
            controller.NextPerson();
            //Data for person to view
            firstnameTextBox.Text = controller.CurentPerson.FirstName;
            lastnameTextBox.Text = controller.CurentPerson.LastName;
            ageTextBox.Text = controller.CurentPerson.Age.ToString();
            telephonenrTextBox.Text = controller.CurentPerson.TelephoneNr;

            //Update counters in application
            this.personCountInt.Text = controller.PerconCount.ToString();
            this.indexCountInt.Text = controller.PersonIndex.ToString();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            //Using the singleton instance and instantiating the Controler.CS
            var controller = Controler.GetInstance();
            //Delete person in Controler.CS
            controller.DeletePerson();
            //Data for person to delete
            controller.CurentPerson.FirstName = firstnameTextBox.Text;
            controller.CurentPerson.LastName = lastnameTextBox.Text;
            controller.CurentPerson.Age = int.Parse(ageTextBox.Text);
            controller.CurentPerson.TelephoneNr = telephonenrTextBox.Text;

            //Update counters in application
            this.personCountInt.Text = controller.PerconCount.ToString();
            this.indexCountInt.Text = controller.PersonIndex.ToString();
        }

        private void down_Click(object sender, RoutedEventArgs e)
        {
            //Using the singleton instance and instantiating the Controler.CS
            var controller = Controler.GetInstance();
            //Asking for the previous person in Controler.CS
            controller.PrevPerson();
            //Data for person to view
            firstnameTextBox.Text = controller.CurentPerson.FirstName;
            lastnameTextBox.Text = controller.CurentPerson.LastName;
            ageTextBox.Text = controller.CurentPerson.Age.ToString();
            telephonenrTextBox.Text = controller.CurentPerson.TelephoneNr;

            //Update counters in application
            this.personCountInt.Text = controller.PerconCount.ToString();
            this.indexCountInt.Text = controller.PersonIndex.ToString();
        }
    }
}
