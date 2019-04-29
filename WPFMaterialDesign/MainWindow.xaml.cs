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

namespace WPFMaterialDesign
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            firstNameLabel.Content = "Ruslan";
            lastNameLabel.Content = "Shadikyan";
            addressLabel.Content = "Samal 10";
            birthdayDateLabel.Content = "15.01.2003";
            groupLabel.Content = "SDP 181/1";
        }
    }
}
