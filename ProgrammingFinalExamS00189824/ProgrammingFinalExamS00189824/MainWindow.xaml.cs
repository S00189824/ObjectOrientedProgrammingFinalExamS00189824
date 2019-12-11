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

namespace ProgrammingFinalExamS00189824
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random r = new Random();
        List<Player> Allplayers = new List<Player>();
        List<Player> SelectedPlayers = new List<Player>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Player p1 = new Player("Sophie", "O Niell", Position.GoalKeeper, new DateTime(1994, 09, 02), 25);
            Player p2 = new Player("Grace", "Walsh", Position.Defender, new DateTime(1993, 08, 02),26);
            Player p3 = new Player("Harry", "Lynch", Position.Defender, new DateTime(1994, 10, 02), 20);
            Player p4 = new Player("Luke", "O Niell", Position.Defender, new DateTime(1994, 08, 11), 20);
            Player p5 = new Player("Michael", "Daly", Position.Defender, new DateTime(1993, 09, 02), 20);
            Player p6 = new Player("Luke", "Nolan", Position.Midfielder, new DateTime(1994, 09, 02), 20);
            Player p7 = new Player("Luke", "Lynch", Position.Midfielder, new DateTime(1994, 09, 02), 20);
            Player p8 = new Player("Luke", "McCarthy", Position.Midfielder, new DateTime(1994, 09, 02), 20);
            Player p9 = new Player("Luke", "Dunne", Position.Midfielder, new DateTime(1994, 09, 02), 20);
            Player p10 = new Player("Sean", "Brennan", Position.Midfielder, new DateTime(1994, 09, 02), 20);
            Player p11 = new Player("Ava", "Walsh", Position.Forward, new DateTime(1994, 09, 02), 20);
            Player p12= new Player("Jack", "O Sullivan", Position.Forward, new DateTime(1994, 09, 02), 20);
            Player p13 = new Player("Amellial", "O Sullivan", Position.GoalKeeper, new DateTime(1994, 09, 02), 20);
            Player p14 = new Player("Nicholas", "O Niell", Position.Defender, new DateTime(1994, 09, 02), 20);
            Player p15 = new Player("Setella", "O Niell", Position.Forward, new DateTime(1994, 09, 02), 20);
            Player p16 = new Player("Mike", "O Niell", Position.Forward, new DateTime(1994, 09, 02), 20);
            Player p17 = new Player("Ashley", "Long", Position.Forward, new DateTime(1994, 09, 02), 20);
            Player p18 = new Player("Chelsea", "O Niell", Position.Defender, new DateTime(1994, 09, 02), 20);

            Allplayers.Add(p1);
            Allplayers.Add(p2);
            Allplayers.Add(p3);
            Allplayers.Add(p4);
            Allplayers.Add(p5);
            Allplayers.Add(p6);
            Allplayers.Add(p7);
            Allplayers.Add(p8);
            Allplayers.Add(p9);
            Allplayers.Add(p10);
            Allplayers.Add(p11);
            Allplayers.Add(p12);
            Allplayers.Add(p13);
            Allplayers.Add(p14);
            Allplayers.Add(p15);
            Allplayers.Add(p16);
            Allplayers.Add(p17);
            Allplayers.Add(p18);

            Listbx1.ItemsSource = Allplayers;
        }

        public void playercreate(int dob)
        {
            
        }

        private void Listbx1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Addbtn_Click(object sender, RoutedEventArgs e)
        {
            Player selectedplayer = Listbx1.SelectedItem as Player;

            if (selectedplayer != null)
            {
                Allplayers.Remove(selectedplayer);
                SelectedPlayers.Add(selectedplayer);
                Listbx1.ItemsSource = null;
                Listbx1.ItemsSource = Allplayers;

                //Refreshing
                Listbx2.ItemsSource = null;
                Listbx2.ItemsSource = SelectedPlayers;
            }
        }

        private void Removebtn_Click(object sender, RoutedEventArgs e)
        {
            Player selectedplayer = Listbx2.SelectedItem as Player;

            if (selectedplayer != null)
            {
                SelectedPlayers.Remove(selectedplayer);
                Allplayers.Add(selectedplayer);
                Listbx2.ItemsSource = null;
                Listbx2.ItemsSource = SelectedPlayers;

                //Refreshing
                Listbx1.ItemsSource = null;
                Listbx1.ItemsSource = Allplayers;

                for (int i = 0; i < SelectedPlayers.Count; i++)
                {
                    txspaces.Text = SelectedPlayers.Count.ToString();
                }
            }
        }
    }
}
