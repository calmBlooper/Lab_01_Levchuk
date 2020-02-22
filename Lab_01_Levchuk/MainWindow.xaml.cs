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

namespace Lab_01_Levchuk
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
  /*
        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
            if (DPBirthDate.SelectedDate != null)
            {
                DateTime text = DPBirthDate.SelectedDate.Value;
                string output = "";
                int age = System.DateTime.Today.Year-text.Year;
                output = "You are " + age + " years old";
                if (text.Month == DateTime.Today.Month && text.Day == DateTime.Today.Day) output += "\nHey, you were born today - happy birthday!";
                if (age >= 135) output += "\nThat`s means a wrong date - you were supposed to be dead by now!";

                //Console.WriteLine(text.ToString());
                MessageBox.Show(output);
            }
            else MessageBox.Show("You gotta choose your date of birth first!");
        }
        */
    }
}
