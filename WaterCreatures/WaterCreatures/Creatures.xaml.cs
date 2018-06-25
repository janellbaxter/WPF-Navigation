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

namespace WaterCreatures
{
    /// <summary>
    /// Interaction logic for Creatures.xaml
    /// </summary>
    public partial class Creatures : Page
    {
        private string[] content = new string[] { "Creature 01\nInformation about the 1st creature...", "Creature 02\nInformation about the 2nd creature...", "Creature 03\nInformation about the 3rd creature..." };
        private string[] images = new string[] {"creature01.png", "creature02.png", "creature03.png" };
        private int index = 0;
        public Creatures()
        {
            InitializeComponent();
        }

        private void Move_Click(object sender, RoutedEventArgs e)
        {
            if (index <= content.Length)
            {
                Information.Text = content[index];
                CreatureImage.Source = new BitmapImage(new Uri(images[index], UriKind.Relative));
                 
                if (index < (content.Length-1))
                {
                    Move.Content = "Next";
                    index++;
                }
                else
                {
                    Move.Content = "Restart";
                    index = 0;
                    StartAdventure.Visibility = Visibility.Visible;
                }
            }
       
        }

        private void CreatureGrid_Loaded(object sender, RoutedEventArgs e)
        {
            //hide adventure start button
            StartAdventure.Visibility = Visibility.Collapsed;
            //introductory text
            Information.Text = Player.Name + ", there is much to learn about these creatures. Review what we have on file before entering the Water Creatures adventure.";
        }

        private void StartAdventure_Click(object sender, RoutedEventArgs e)
        {
            Information.Text = "Adventure has not yet been created.... add more to this starting framework.";
        }
    }
}
