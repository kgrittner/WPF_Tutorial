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
using System.Windows.Media.Animation;


namespace ProWPF_C.Ch15_Animation
{
    /// <summary>
    /// Interaction logic for CodeAnimation.xaml
    /// </summary>
    public partial class CodeAnimation : Window
    {
        public CodeAnimation()
        {
            InitializeComponent();
        }


        private void cmdGrow_Click(object sender, RoutedEventArgs e)
        {
            // this -- Means this window
            // this.Width -100 means the width of the window -100 from each side
            DoubleAnimation widthAnimation = new DoubleAnimation();
            widthAnimation.To = 400; //this.Width - 100; 
            widthAnimation.Duration = TimeSpan.FromSeconds(5);

            DoubleAnimation heightAnimation = new DoubleAnimation();
            heightAnimation.To = cmdGrow.Height + 40; //(this.Height - 50) / 3;
            heightAnimation.Duration = TimeSpan.FromSeconds(5);

            // This begins the animation
            cmdGrow.BeginAnimation(Button.WidthProperty, widthAnimation);
            cmdGrow.BeginAnimation(Button.HeightProperty, heightAnimation);
        }


        private void cmdShrink_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation widthAnimation = new DoubleAnimation();
            //widthAnimation.Duration = TimeSpan.FromSeconds(5);
            DoubleAnimation heightAnimation = new DoubleAnimation();
            //heightAnimation.Duration = TimeSpan.FromSeconds(5);

            cmdGrow.BeginAnimation(Button.WidthProperty, widthAnimation);
            cmdGrow.BeginAnimation(Button.HeightProperty, heightAnimation);
        }

        private void cmdGrowIncrementally_Click(object sender, RoutedEventArgs e)
        {
            // .By is what makes it grow incrementally
            DoubleAnimation widthAnimation = new DoubleAnimation();
            widthAnimation.By = 10;
            widthAnimation.Duration = TimeSpan.FromSeconds(0.5);

            cmdGrowIncrementally.BeginAnimation(Button.WidthProperty, widthAnimation);
        }

















    }
}
