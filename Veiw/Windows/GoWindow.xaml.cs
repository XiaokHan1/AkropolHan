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

namespace Akropol.Veiw.Windows
{
    /// <summary>
    /// Логика взаимодействия для GoWindow.xaml
    /// </summary>
    public partial class GoWindow : Window
    {
        public GoWindow()
        {
            InitializeComponent();

            Classes.ClassFrame.frame1 = Frm;
            Frm.Navigate(new Pages.MenuPage());

            Classes.ClassFrame.frame2 = frames;
            frames.Navigate(new Pages.Page1());
        }
    }
}
