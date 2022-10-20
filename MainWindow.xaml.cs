using System;
using System.Windows;
using System.Windows.Forms;

namespace StructT
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private T[] CreateArray<T>(T firstElement, T secondElement) where T : ICloneable, new()
        {
            return new T[] { firstElement, secondElement };          
        }
    }
}
