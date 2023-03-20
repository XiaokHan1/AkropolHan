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
    /// Логика взаимодействия для dobPage.xaml
    /// </summary>
    public partial class dobPage : Page
    {
        public dobPage()
        {
            InitializeComponent();
            LocCmb.SelectedValuePath = "Id";
            LocCmb.DisplayMemberPath = "Locations";
            LocCmb.ItemsSource = Models.ClassHelpers.balashov.Location.ToList();

            SanuCmb.SelectedValuePath = "Id";
            SanuCmb.DisplayMemberPath = "NumberBathroom";
            SanuCmb.ItemsSource = Models.ClassHelpers.balashov.NumberBathrooms.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(NumStoreysTb.Text))
                mes += "Введите номер этажа\n";
            if (string.IsNullOrWhiteSpace(arendStoreys.Text))
                mes += "Введите арендованный этаж\n";
            if (string.IsNullOrWhiteSpace(Dtg.Text))
                mes += "Дата постройки\n";
            if (string.IsNullOrWhiteSpace(LocCmb.Text))
                mes += "Выберите местоположение\n";
            if (string.IsNullOrWhiteSpace(NumRooms.Text))
                mes += "Введите количество комнат\n";
            if (string.IsNullOrWhiteSpace(SanuCmb.Text))
                mes += "Введите вид санузла\n";
            if (string.IsNullOrWhiteSpace(SummaTb.Text))
                mes += "Сумма\n";
            if (string.IsNullOrWhiteSpace(marketTb.Text))
                mes += "Маркетная сумма\n";
            if (string.IsNullOrWhiteSpace(ArendTb.Text))
                mes += "Арендная сумма\n";

            if(mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Helpers.Fond fond = new Helpers.Fond()
            {
                NumberStoreys = int.Parse(NumStoreysTb.Text),
                ArendaStoreys = int.Parse(arendStoreys.Text),
                YearCostruction = (DateTime)Dtg.SelectedDate,
                Location = LocCmb.SelectedItem as Helpers.Location,
                NumberRooms = int.Parse(NumRooms.Text),
                NumberBathrooms = SanuCmb.SelectedItem as Helpers.NumberBathrooms,
                Conditioner = (bool)Check1.IsChecked,
                Summa = decimal.Parse(SummaTb.Text),
                MarketSumma = decimal.Parse(marketTb.Text),
                ArendSumma = decimal.Parse(ArendTb.Text),
                RoomArend = (bool)Check2.IsChecked
            };
            Models.ClassHelpers.balashov.Fond.Add(fond);
            Models.ClassHelpers.balashov.SaveChanges();
            MessageBox.Show("Новый фонд добавлен");

            NumStoreysTb.Text = "";
            arendStoreys.Text = "";
            Dtg.Text = "";
            LocCmb.Text = "";
            NumRooms.Text = "";
            SanuCmb.Text = "";
            Check1.IsChecked = false;
            SummaTb.Text = "";
            marketTb.Text = "";
            ArendTb.Text = "";
            Check2.IsChecked = false;
        }
    }
}
