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

namespace Akropol.Veiw.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var qwert = Models.ClassHelpers.balashov.Managers.Where(i => i.Login == LogTb.Text && i.Password == PassTb.Text).FirstOrDefault();
            if (qwert != null)
            {
                Classes.ClassFrame.frame2.Navigate(new StartPage());
                Classes.ClassFrame.frame1.Navigate(new MenuStartManagers());
            }
            if(qwert == null)
            {
                LoginTb.Foreground = Brushes.Red;
                Passtb.Foreground = Brushes.Red;
            }
        }
    }
}
