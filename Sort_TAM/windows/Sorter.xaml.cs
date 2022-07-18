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
using System.Windows.Shapes;
using Sort_TAM.structure;

namespace Sort_TAM.windows
{
    /// <summary>
    /// Interaction logic for Sorter.xaml
    /// </summary>
    public partial class Sorter : Window
    {
        public bool IsWindowClosed;
        private string TAMUK_str_in;
        private string TAMUK_str_out;
        private char[] TAMUK;
        public Sorter()
        {
            InitializeComponent();

            // Initialize instance variables
            this.IsWindowClosed = false;
            this.TAMUK_str_in = "";
            this.TAMUK_str_out = "";

            // Set static parameters
            Output_String_Textbox.Foreground = Brushes.Green;
        }

        protected override void OnClosed(EventArgs e)
        {
            // Call parent class method
            base.OnClosed(e);

            // Update boolean
            this.IsWindowClosed = true;
        }

        private bool Evaluate_Input_String(string input)
        {
            // Check for empty string
            if (input == "")
            {
                MessageBox.Show("No input string is provided. Please provide an input!", "Input error", MessageBoxButton.OK, MessageBoxImage.Error);
                Input_String_Textbox.Text = "";
                return false;
            }
            // Check if empty # is provided as input
            else if (input == "#")
            {
                MessageBox.Show("Input string provided is just '#'. Please correct it!", "Input error", MessageBoxButton.OK, MessageBoxImage.Error);
                Input_String_Textbox.Text = "";
                return false;
            }
            else
            {
                // Check if end of the string is '#'
                if (input[input.Length - 1] != '#')
                {
                    MessageBox.Show("Input string is not ending with #. Please correct it!", "Input error", MessageBoxButton.OK, MessageBoxImage.Error);
                    Input_String_Textbox.Text = "";
                    return false;
                }
                else
                {
                    // Check if input string contains only A, T & M
                    foreach (char letter in input)
                    {
                        if (letter != '#')
                        {
                            if (letter == 't' | letter == 'a' | letter == 'm')
                            {
                                MessageBox.Show("Input string should contain only A, T & M and be upper case. Please correct it!", "Input error", MessageBoxButton.OK, MessageBoxImage.Error);
                                Input_String_Textbox.Text = "";
                                return false;
                            }

                            if (letter != 'T' & letter != 'A' & letter != 'M')
                            {
                                MessageBox.Show("Input string should contain only A, T & M. Please correct it!", "Input error", MessageBoxButton.OK, MessageBoxImage.Error);
                                Input_String_Textbox.Text = "";
                                return false;
                            }
                        }
                    }
                }
            }

            return true;
        }

        private void Input_String_Textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Save the input string to instance variable
            this.TAMUK_str_in = Input_String_Textbox.Text;
        }

        private void Sort_Button_Click(object sender, RoutedEventArgs e)
        {
            // Evaluate the input string
            if (this.Evaluate_Input_String(input: this.TAMUK_str_in))
            {
                // Create list of chars from input string
                this.TAMUK = this.TAMUK_str_in.Substring(0, this.TAMUK_str_in.Length - 1).ToCharArray();

                // Call Sorter, sort the input string and display the output string
                this.TAMUK_str_out = TAMSorter.Sort_TAM(this.TAMUK);
                Output_String_Textbox.Text = this.TAMUK_str_out;
            }
        }

        private void Output_String_Textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Not needed, as this field is Read-Only
        }

        private void Refresh_Button_Click(object sender, RoutedEventArgs e)
        {
            // Clear all textboxes
            Input_String_Textbox.Text = "";
            Output_String_Textbox.Text = "";
        }
    }
}
