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
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();
            RoleCmb.SelectedValuePath = "Id";
            RoleCmb.DisplayMemberPath = "Title";
            RoleCmb.ItemsSource = Models.ClassHelpers.balashov.Roles.ToList();

            FondCmb.SelectedValuePath = "Id";
            FondCmb.DisplayMemberPath = "Id";
            FondCmb.ItemsSource = Models.ClassHelpers.balashov.Fond.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(NameTb.Text))
                mes += Name.Foreground = Brushes.Red;
            if (string.IsNullOrWhiteSpace(LogTb.Text))
                mes += Login.Foreground = Brushes.Red;
            if (string.IsNullOrWhiteSpace(PassTb.Text))
                mes += Pass.Foreground = Brushes.Red;
            if (string.IsNullOrWhiteSpace(RoleCmb.Text))
                mes += Roles.Foreground = Brushes.Red;
            if (string.IsNullOrWhiteSpace(FondCmb.Text))
                mes += Fonds.Foreground = Brushes.Red;
            if (mes != "")
            {
               
                mes = "";
                return;
            }
            Helpers.Managers managers = new Helpers.Managers()
            {
                Name = NameTb.Text,
                Login = LogTb.Text,
                Password = PassTb.Text,
                Roles = RoleCmb.SelectedItem as Helpers.Roles,
                Fond = FondCmb.SelectedItem as Helpers.Fond
            };
            Models.ClassHelpers.balashov.Managers.Add(managers);
            Models.ClassHelpers.balashov.SaveChanges();
            MessageBox.Show("Добален(а)");

            NameTb.Text = "";
            LogTb.Text = "";
            PassTb.Text = "";
            RoleCmb.Text = "";
            FondCmb.Text = "";

        }
    }
}
