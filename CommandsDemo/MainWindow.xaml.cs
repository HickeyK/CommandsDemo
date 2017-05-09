using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CommandsDemo
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

        private void OnAddListItemExecute(object sender, ExecutedRoutedEventArgs e)
        {
            ListView lv = sender as ListView;
            if (lv != null)
            {
                lv.Items.Add(e.Parameter);
                textbox.Clear();
                e.Handled = true;
            }
        }

        private void OnRemoveListItemExecute(object sender, ExecutedRoutedEventArgs e)
        {
            ListView lv = sender as ListView;
            if (lv != null)
            {
                if (lv.SelectedItem != null)
                {
                    lv.Items.Remove(lv.SelectedItem);
                    e.Handled = true;
                }
            }
        }

        private void CanAddListItemExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !String.IsNullOrEmpty(textbox.Text) && !listview.Items.Contains(textbox.Text);
            e.Handled = true;
        }

        private void CanRemoveListItemExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            ListView lv = sender as ListView;
            if (lv != null)
            {
                e.CanExecute = lv.SelectedItem != null;
                e.Handled = true;
            }
        }

    }
}
