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

namespace StandardAlgorithms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<int> numbers = new List<int>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RowDefinition_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            int listLength = int.Parse(Randomnumberstext.Text);

            Random rnd = new Random();
            numbers.Clear();

            for (int i = 0; i < listLength; i++)
            {
                int x = rnd.Next(1, 1000);
                numbers.Add(x);
                
            }

            Printlist();
        }

        void Printlist()
        {
            Numbershower.Document.Blocks.Clear();
            for (int i = 0; i < numbers.Count; i++)
            {
                Numbershower.AppendText(i + ", " + numbers[i] + "\r");
            }
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Linearsearch_Click(object sender, RoutedEventArgs e)
        {
            int Numsearch = int.Parse(Linearsearch.Text);

            for (int i = 0; i < numbers.Count; i++)
            {
                if (Numsearch == numbers[i])
                {
                    MessageBox.Show(numbers[i].ToString() + " At position " + i);
                    break;
                }
                
            }
            MessageBox.Show("There were no numbers found");
        }

        private void Randomnumberstext_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Minbutton_Click(object sender, RoutedEventArgs e)
        {
            int minimum = numbers[0];

            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] < minimum)
                {
                    minimum = numbers[i];
                }
                
            }
            MessageBox.Show("the min is " + minimum);
        }

        private void Maxbutton_Click(object sender, RoutedEventArgs e)
        {
            int maximum = numbers[0];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > maximum)
                {
                    maximum = numbers[i];
                }

            }
            MessageBox.Show("the max is " + maximum);
        }

        private void Linearsearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Insertion_Click(object sender, RoutedEventArgs e)
        {
            
            for (int a = 0; a < numbers.Count - 1; a++)
            {
                for (int i = a + 1; i > 0; i--)
                {
                    if(numbers[i - 1] > numbers[i])
                    {
                        int temp = numbers[i - 1];
                        numbers[i - 1] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }
            Printlist();
        }

        private void Selection_Click(object sender, RoutedEventArgs e)
        {
            int Pass = 0;

            while (Pass < numbers.Count)
            {
                
            }
        }
    }
}

