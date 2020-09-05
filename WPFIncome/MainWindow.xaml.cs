using Microsoft.Win32;
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

namespace WPFIncome
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WPFViewModel vm;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm = new WPFViewModel(new RealFileProvider());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //var openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            //openFileDialog.Title = "Locate your Excel Input File";
            //openFileDialog.Multiselect = false;
            //if (openFileDialog.ShowDialog() ?? false)
            //{
            //    vm.ImportFilePath = openFileDialog.FileName;
            //}
        }
    }
}
