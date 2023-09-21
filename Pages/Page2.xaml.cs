using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfAppToolBar.Pages
{
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();

        }         
            private void StackPanel_Click(object sender, RoutedEventArgs e)
            {
                var ClickedButton = e.OriginalSource as NavigationSeite2;


                NavigationService.Navigate(ClickedButton.NavUri);
            }
        }
    }


