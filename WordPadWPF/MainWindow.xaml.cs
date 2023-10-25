using System;
using System.Collections.Generic;
using System.IO;
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

namespace WordPadWPF
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

        private void mouse_enter_textbox(object sender, MouseEventArgs e)
        {
            if(path_txtbox.Text=="Enter Path")
                path_txtbox.Text= string.Empty;
        }

        private void mouse_leave_txtbox(object sender, MouseEventArgs e)
        {
            if (path_txtbox.Text == string.Empty)
                path_txtbox.Text = "Enter Path";
        }

        private void rich_txtbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Get the text from the RichTextBox in WPF
            if(check_box.IsChecked == true)
            {
                if(!path_txtbox.Text.EndsWith(".txt"))
                {
                    MessageBox.Show("This Must Be a TXT File ! ");
                    return;
                }    
                TextRange textRange = new TextRange(rich_textbox.Document.ContentStart, rich_textbox.Document.ContentEnd);
                string text = textRange.Text;
                File.WriteAllText(path_txtbox.Text, text);
            }
        }

       

        private void save_button_Click(object sender, RoutedEventArgs e)
        {
            if (!path_txtbox.Text.EndsWith(".txt"))
            {
                MessageBox.Show("Please Enter TXT File !");
                return;
            }
            TextRange textRange = new TextRange(rich_textbox.Document.ContentStart, rich_textbox.Document.ContentEnd);
            string text = textRange.Text;
            File.WriteAllText(path_txtbox.Text, text);
        }

        private void open_button_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists(path_txtbox.Text))
            {
                rich_textbox.Document.Blocks.Clear();
                string stringFromFile = File.ReadAllText(path_txtbox.Text);
                rich_textbox.AppendText(stringFromFile);

            }
            else 
                MessageBox.Show("This File Does Not Exsist !");
        }

        private void select_all_button_Click(object sender, RoutedEventArgs e)
        {
            rich_textbox.SelectAll();
        }

        private void copy_button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(rich_textbox.Selection.Text))
            {
                // Copy the selected text to the clipboard
                Clipboard.SetText(rich_textbox.Selection.Text);
            }
        }

        private void paste_button_Click(object sender, RoutedEventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                string clipboardText = Clipboard.GetText();
                rich_textbox.Selection.Text = clipboardText;
            }
        }

        private void cut_button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(rich_textbox.Selection.Text))
            {
                Clipboard.SetText(rich_textbox.Selection.Text);
                rich_textbox.Selection.Text = string.Empty;
            }
        }
    }
}
