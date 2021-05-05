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

namespace WpfOef2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Persoon> persoons = new List<Persoon>();
        public MainWindow()
        {
            InitializeComponent();

            persoons.Add(new Persoon() { VoorNaam = "Sad", AchterNaam = "Man", ImagePath = "Images/emo-3.png" });
            persoons.Add(new Persoon() { VoorNaam = "Happy", AchterNaam = "Man", ImagePath = "Images/emo-1.png" });
            persoons.Add(new Persoon() { VoorNaam = "Normal", AchterNaam = "Man", ImagePath = "Images/emo-2.png" });
            persoons.Add(new Persoon() { VoorNaam = "Sad", AchterNaam = "Man", ImagePath = "Images/emo-3.png" });
            persoons.Add(new Persoon() { VoorNaam = "Happy", AchterNaam = "Man", ImagePath = "Images/emo-1.png" });
            persoons.Add(new Persoon() { VoorNaam = "Normal", AchterNaam = "Man", ImagePath = "Images/emo-2.png" });
            persoons.Add(new Persoon() { VoorNaam = "Sad", AchterNaam = "Man", ImagePath = "Images/emo-3.png" });
            persoons.Add(new Persoon() { VoorNaam = "Happy", AchterNaam = "Man", ImagePath = "Images/emo-1.png" });
            persoons.Add(new Persoon() { VoorNaam = "Normal", AchterNaam = "Man", ImagePath = "Images/emo-2.png" });
            persoons.Add(new Persoon() { VoorNaam = "Sad", AchterNaam = "Man", ImagePath = "Images/emo-3.png" });
            persoons.Add(new Persoon() { VoorNaam = "Happy", AchterNaam = "Man", ImagePath = "Images/emo-1.png" });
            persoons.Add(new Persoon() { VoorNaam = "Normal", AchterNaam = "Man", ImagePath = "Images/emo-2.png" });
            persoons.Add(new Persoon() { VoorNaam = "Sad", AchterNaam = "Man", ImagePath = "Images/emo-3.png" });
            persoons.Add(new Persoon() { VoorNaam = "Happy", AchterNaam = "Man", ImagePath = "Images/emo-1.png" });
            persoons.Add(new Persoon() { VoorNaam = "Normal", AchterNaam = "Man", ImagePath = "Images/emo-2.png" });
            persoons.Add(new Persoon() { VoorNaam = "Sad", AchterNaam = "Man", ImagePath = "Images/emo-3.png" });
            persoons.Add(new Persoon() { VoorNaam = "Happy", AchterNaam = "Man", ImagePath = "Images/emo-1.png" });
            persoons.Add(new Persoon() { VoorNaam = "Normal", AchterNaam = "Man", ImagePath = "Images/emo-2.png" });

            lbTest.ItemsSource = persoons;
            cbPersonBox.ItemsSource = persoons;
            cbPersonBox.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
