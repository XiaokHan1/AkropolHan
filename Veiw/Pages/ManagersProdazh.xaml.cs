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
    /// Логика взаимодействия для ManagersProdazh.xaml
    /// </summary>
    public partial class ManagersProdazh : Page
    {
        public ManagersProdazh()
        {
            InitializeComponent();
            Dtg.ItemsSource = Models.ClassHelpers.balashov.Fond.ToList();

            Cmb.SelectedValuePath = "Id";
            Cmb.DisplayMemberPath = "Locations";
            Cmb.ItemsSource = Models.ClassHelpers.balashov.Location.ToList();
        }

        private void Cmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectSort = Convert.ToInt32(Cmb.SelectedValue);
            Dtg.ItemsSource = Models.ClassHelpers.balashov.Fond.Where(i => i.IdLocation == SelectSort).ToList();
        }

        private void SummaTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            int SelectSort = Convert.ToInt32(SummaTb.Text);
            Dtg.ItemsSource = Models.ClassHelpers.balashov.Fond.Where(i => i.Summa == SelectSort).ToList();
        }

        private void Tb1_TextChanged(object sender, TextChangedEventArgs e)
        {
            int SelectSort = Convert.ToInt32(Tb1.Text);
            Dtg.ItemsSource = Models.ClassHelpers.balashov.Fond.Where(i => i.NumberRooms == SelectSort).ToList();
        }
    }
}
