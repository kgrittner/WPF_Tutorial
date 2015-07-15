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

namespace ProWPF_C.Ch16_AdvancedAnimation
{
    /// <summary>
    /// Interaction logic for AnimateRadialGradient.xaml
    /// </summary>
    public partial class AnimateRadialGradient : Window
    {
        public AnimateRadialGradient()
        {
            InitializeComponent();
        }

        public double count = 0;

        //public void WatchYou(object sender, MouseEventArgs e)
        //{
        //    Point npoint = Mouse.GetPosition(this.ellipse);
        //    Ellipse elips = ((Ellipse)ellipse);
        //    double elWidth = Convert.ToDouble(elips.ActualWidth);
        //    elWidth -= this.myWind.ActualWidth - elWidth;
        //    double dblPointX = Convert.ToDouble(npoint.X);
        //    double dblPointY = Convert.ToDouble(npoint.Y);
           
        //    txtPointA.Text = "X: " + ((dblPointX / elWidth)).ToString();
        //    txtPointB.Text = "Y: " + ((dblPointY / elWidth)).ToString();
        //    count += .01;


        //    // myStoryBoard.Children.Clear();

            

        //    PointAnimationUsingKeyFrames centerPointAnimation
        //        = new PointAnimationUsingKeyFrames();

        //    RadialGradientBrush rBrush = new RadialGradientBrush();
        //    rBrush.GradientStops.Add(new GradientStop(Colors.White, 0));
        //    rBrush.GradientStops.Add(new GradientStop(Colors.Blue, 0.2));
        //    rBrush.GradientStops.Add(new GradientStop(Colors.Yellow, 0.6));

        //    Storyboard.SetTargetName(centerPointAnimation, "ellipse");
        //    //Storyboard.SetTargetProperty(
        //    //    centerPointAnimation, new PropertyPath(Ellipse.));

        //    centerPointAnimation.KeyFrames.Add(new LinearPointKeyFrame(
        //        new Point(((dblPointY) * .01), ((dblPointX) * .01))));


        //    // Create a storyboard to apply the animation.
        //    Storyboard ellipseStoryboard = new Storyboard();
        //    ellipseStoryboard.Children.Add(centerPointAnimation);

        //    ellipseStoryboard.Begin(this);

        //}
       

    }
}
