using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Example_ListView2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = this;
            entries = new ObservableCollection<string>();
            InitializeComponent();
         
        }

        private ObservableCollection<string> entries;

        public ObservableCollection<string> Entries
        {
            get { return entries; } 
            set { entries = value; }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string selectedItem = (string)lvEntries.SelectedItem;
            entries.Remove(selectedItem);
        }


        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            entries.Clear();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Entries.Add(txtEntry.Text);
        }
    }
}