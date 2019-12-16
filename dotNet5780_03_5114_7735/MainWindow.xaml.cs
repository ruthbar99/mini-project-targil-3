//Ruth Bar Dagan (Bardugo) ID:208317735
//Yael Suisa ID:318905114
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

namespace dotNet5780_03_5114_7735
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Host currentHost;
        public List<Host> hostsList;

        public MainWindow()
        {

            hostsList = new List<Host>()
        {
            new Host()
            {

                HostName = "הפסגה",
                Units=new List<HostingUnit>()

                {
                    new HostingUnit()
                    {
                        UnitName = "חושן",
                        Rooms = 2,
                        IsSwimmingPool = true,
                        AllOrders=new List<DateTime>(),
                        Uris=new List<string>()
                        {
                          "https://pic.rrr.co.il/images/amity/58%20(Custom).jpg",
                          "https://pic.rrr.co.il/images/amity/39%20(Custom).jpg",
                          "https://pic.rrr.co.il/images/amity/53%20(Custom).jpg"
                        }

                    },
                    new HostingUnit()
                    {
                        UnitName = "שנהב",
                        Rooms = 3,
                        IsSwimmingPool = false,
                        AllOrders=new List<DateTime>(),
                        Uris=new List<string>()
                        {
                          "https://pic.rrr.co.il/images/amity/41%20(Custom).jpg",
                          "https://pic.rrr.co.il/images/amity/47%20(Custom).jpg",
                          "https://pic.rrr.co.il/images/amity/34%20(Custom).jpg"
                        }
                    },
                    new HostingUnit()
                    {
                        UnitName = "אגם",
                        Rooms = 3,
                        IsSwimmingPool = true,
                        AllOrders=new List<DateTime>(),
                        Uris=new List<string>()
                        {
                          "https://pic.rrr.co.il/images/biktabatmarim/163%20(Custom).jpg",
                          "https://pic.rrr.co.il/images/biktabatmarim/129%20(Custom).jpg",
                          "https://pic.rrr.co.il/images/biktabatmarim/134%20(Custom).jpg"
                        }
                    },

                }
            },
            new Host()
            {

                HostName = "סוויטת מישל",
                Units=new List<HostingUnit>()
                {
                    new HostingUnit()
                    {
                        UnitName = "קסם",
                        Rooms = 2,
                        IsSwimmingPool = false,
                        AllOrders=new List<DateTime>(),
                        Uris=new List<string>()
                        {
                          "https://pic.rrr.co.il/images/place/173%20(Custom).jpg",
                          "https://pic.rrr.co.il/images/place/155%20(Custom).jpg",
                          "https://pic.rrr.co.il/images/place/164%20(Custom).jpg"
                        }

                    },
                    new HostingUnit()
                    {
                    UnitName = "פלינה",
                        Rooms = 2,
                        IsSwimmingPool = true,
                        AllOrders=new List<DateTime>(),
                        Uris=new List<string>()
                        {
                          "https://pic.rrr.co.il/images/bithaomanim/91%20(Custom).jpg",
                          "https://pic.rrr.co.il/images/bithaomanim/27%20(Custom).jpg",
                          "https://pic.rrr.co.il/images/bithaomanim/5%20(Custom).jpg"
                        }

                    },
                }
            },

            new Host()
            {

                HostName = "אידיליה",
                Units=new List<HostingUnit>()
                {
                    new HostingUnit()
                    {
                        UnitName = "זהב",
                        Rooms = 2,
                        IsSwimmingPool = false,
                        AllOrders=new List<DateTime>(),
                        Uris=new List<string>()
                        {
                          "https://pic.rrr.co.il/images/vilakiiit/5%20(Custom).jpg",
                          "https://pic.rrr.co.il/images/vilakiiit/14%20(Custom).jpg",
                          "https://pic.rrr.co.il/images/vilakiiit/1%20(Custom).jpg"
                        }

                    },
                    new HostingUnit()
                    {
                    UnitName = "נחושת",
                        Rooms = 3,
                        IsSwimmingPool = true,
                        AllOrders=new List<DateTime>(),
                        Uris=new List<string>()
                        {
                         "https://pic.rrr.co.il/images/vilakiiit/32%20(Custom).jpg",
                         "https://pic.rrr.co.il/images/vilakiiit/43%20(Custom).jpg",
                         "https://pic.rrr.co.il/images/vilakiiit/4%20(Custom).jpg"
                        }
                    },

                    new HostingUnit()
                    {
                        UnitName = "יהלום",
                        Rooms = 3,
                        IsSwimmingPool = false,
                        AllOrders=new List<DateTime>(),
                        Uris=new List<string>()
                        {
                         "https://pic.rrr.co.il/images/makombahof/34%20(Custom).jpg",
                         "https://pic.rrr.co.il/images/makombahof/33%20(Custom).jpg",
                         "https://pic.rrr.co.il/images/makombahof/38%20(Custom).jpg"
                        }
                    },
                }
            }

            };


            InitializeComponent();

            cbHostList.ItemsSource = hostsList;
            cbHostList.DisplayMemberPath = "HostName";
            cbHostList.SelectedIndex = 0;
        }

        private void CbHostList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InitializeHost(cbHostList.SelectedIndex);
        }

        private void InitializeHost(int index)
        {
            MainGrid.Children.RemoveRange(1, 3);
            currentHost = hostsList[index];
            UpGrid.DataContext = currentHost;
            for (int i = 0; i < currentHost.Units.Count; i++)
            {
                HostingUnitUserControl a = new HostingUnitUserControl(currentHost.Units[i]);
                MainGrid.Children.Add(a);
                Grid.SetRow(a, i + 1);
            }
        }

        private void TbHostName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        
    }   
}
