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
        // creates a list
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
            //puts the list into the actual box
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
            // numbers the randomly generated numbers
            Numbershower.Document.Blocks.Clear();
            for (int i = 0; i < numbers.Count; i++)
            {
                //to add your number plus a new line to a textbox
                Numbershower.AppendText(i + ", " + numbers[i] + "\r");
            }
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Linearsearch_Click(object sender, RoutedEventArgs e)
        {
            int Numsearch = int.Parse(Linearsearch.Text);
            //loop to search through numbers
            for (int i = 0; i < numbers.Count; i++)
            {
                //comparing the users searched number to all the lists numbers
                if (Numsearch == numbers[i])
                {
                    //printing out if the program has found the users number
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
            //setting the first number to the minimum
            int minimum = numbers[0];
            //goes through the array
            for (int i = 0; i < numbers.Count; i++)
            {
                // if the current number is smaller than the current minimum assign the new number to the minimum
                if(numbers[i] < minimum)
                {
                    minimum = numbers[i];
                }
                
            }
            MessageBox.Show("the min is " + minimum);
            //display min
        }

        private void Maxbutton_Click(object sender, RoutedEventArgs e)
        {
            //setting max to first button
            int maximum = numbers[0];
            // go through array
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > maximum) // number greater than current max, assign new max
                {
                    maximum = numbers[i];
                }

            }
            MessageBox.Show("the max is " + maximum);
            //display max
        }

        private void Linearsearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Insertion_Click(object sender, RoutedEventArgs e)
        {
            //first item to be the sorted part the array
            for (int a = 0; a < numbers.Count - 1; a++)
            {
                for (int i = a + 1; i > 0; i--)
                {
                    //if currnet item is smaller, swap items
                    if(numbers[i - 1] > numbers[i])
                    {
                        //sorting new item
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
            //A sorted and an unsorted list are maintained.
            while (Pass < numbers.Count)
            {
                int Count = Pass + 1;
                int Minimum = Pass;
                while (Count < numbers.Count)
                {
                    if (numbers[Count] < numbers[Minimum])
                    {
                        Minimum = Count;
                        // The smallest item in the unsorted list is swapped with the first item in the unsorted list. 
                    }
                    Count = Count + 1; //The sorted list is increased in length to include the new item. 
                }
                int temp = numbers[Minimum];
                numbers[Minimum] = numbers[Pass];
                numbers[Pass] = temp;
                Pass = Pass + 1;
                // the process is repeated while there are items in the unsorted list
            }
            Printlist();
        }

        private void Bubble_Click(object sender, RoutedEventArgs e)
        {
            // Pairs of adjacent items are compared in turn. If they are out of order, they are swapped. 
            bool swapped = true;
            int pass = 1;
            while (swapped == true)
            {
                
                swapped = false;
                int comparison = 0;
                while (comparison < numbers.Count - pass)
                {
                    // Pairs of adjacent items are compared in turn. If they are out of order, they are swapped. 
                    if (numbers[comparison] > numbers[comparison + 1])
                    {
                        int temp = numbers[comparison];
                        numbers[comparison] = numbers[comparison + 1];
                        numbers[comparison + 1] = temp;
                        swapped = true;
                    }
                    comparison++;
                    //Once the end of the list is reached, we move back to the start and repeat the process. 
                }
                pass++;
                // Eventually no swaps will be required, indicating that the list is sorted
            }
            Printlist();
        }

        private void BinarySearch_Click(object sender, RoutedEventArgs e)
        {
            //setting the low and the high point of the array
            int Low = 0;
            int High = numbers.Count;
            bool found = false;
            int itemtofind = int.Parse(Linearsearch.Text);

            while (High >= Low && found == false)
            {
                //getting the middle and checking if the number is in the first or second half of the arrau
                int middle = ((Low + High) / 2);
                if (itemtofind < numbers[middle]) //checking lower half
                {
                    High = middle - 1;
                }
                else if(itemtofind > numbers[middle]) //checking higher half
                {
                    Low = middle;
                }
                else
                {
                    found = true; // if its the number in the middle of the array than its found
                }
            }
            if (found == true)
            {
                MessageBox.Show("Found " + itemtofind);
            }
            else
            {
                MessageBox.Show("Not Found");
            }
        }
    }
}

