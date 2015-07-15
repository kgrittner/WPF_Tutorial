using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Controls;


namespace ProWPF_C.Ch2_Xaml
{
    class CodeOnly : Window
    {
        private Button button1;

        public CodeOnly()
        {
            InitializeComponent();
        }


        private void InitializeComponent()
        { 
            // Configure the form
            this.Width = this.Height = 285;
            this.Left = this.Top = 100;
            this.Title = "Code-Only Window";

            // Create a container to hold a button
            //DockPanel panel = new DockPanel();
            //panel.Background = new SolidColorBrush(Colors.Blue);


            Grid grid1 = new Grid();
          //  grid1.Background = new SolidColorBrush(Colors.Blue);
            grid1.ShowGridLines = true;

            RowDefinition row1 = new RowDefinition();
            RowDefinition row2 = new RowDefinition();
           
            ColumnDefinition col1 = new ColumnDefinition();
            ColumnDefinition col2 = new ColumnDefinition();
            
            grid1.RowDefinitions.Add(row1);
            grid1.RowDefinitions.Add(row2);
            
            grid1.ColumnDefinitions.Add(col1);
            grid1.ColumnDefinitions.Add(col2);
            

            // Create a container to hold a button
            button1 = new Button();
            button1.Content = "Please Click Me";
           // button1.Margin = new Thickness(30);



            // Attach the event handler
            button1.Click += button1_Click;
            Grid.SetRow(button1, 1);
            Grid.SetColumn(button1, 1);
           // grid1.Children.Add(button1);

            // Place the button in the panel.
            IAddChild container = grid1;
            container.AddChild(button1);







            // Place the panel in the form.
            container = this;
            container.AddChild(grid1);
            


        }


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            button1.Content = "Thank you.";

            Color[] myColors = new Color[] { Colors.Red, Colors.Blue, Colors.Pink };
            button1.Background = addABunchOfGradients(myColors);
        }


        private Brush addABunchOfGradients(Color[] theColor)
        {
            LinearGradientBrush brush1 = new LinearGradientBrush();
            IList<GradientStop> list = brush1.GradientStops;

            double i = 1 / Convert.ToDouble(theColor.Length);
            double t = i;

            foreach (Color selColor in theColor)
            {
                GradientStop grad1 = new GradientStop();
                grad1.Offset = t;
                grad1.Color = selColor;
                list.Add(grad1);
                t += i;
            }
            return brush1;
        }

        private Brush addABunchOfGradients(Color[] theColor, int somedfj)
        {
            LinearGradientBrush brush1 = new LinearGradientBrush();
            IList<GradientStop> list = brush1.GradientStops;

            double i = 1 / Convert.ToDouble(theColor.Length);
            double t = i;

            foreach (Color selColor in theColor)
            {
                GradientStop grad1 = new GradientStop();
                grad1.Offset = t;
                grad1.Color = selColor;
                list.Add(grad1);
                t += i;
            }
            return brush1;
        }













    }
}
