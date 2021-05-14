using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public Button btnToMove = null;
        public MainWindow()
        {
            InitializeComponent();
            var circle = new Image();
            circle.Source =
                new BitmapImage(
                    new Uri("C:\\Users\\ROSTIK\\RiderProjects\\WpfApplication2\\WpfApplication2\\index.png", UriKind.Absolute));
            b0.Content = circle;
            
            chessTable.Buttons = new List<Button> {b0, b1, b2, b3, b4, b5, b6, b7, b8};
        }

        private void Choose(object sender, RoutedEventArgs e)
        {
            var senderBtn = ((Button)sender);
            if (btnToMove == null)
            {
                btnToMove = senderBtn;
                senderBtn.BorderThickness = new Thickness(3);
            }

            else
            {
                if (!Equals(sender, btnToMove) && btnToMove.Content!=null)
                {
                    senderBtn.Content = btnToMove.Content;
                    btnToMove.Content = null;
                    btnToMove.BorderThickness = new Thickness(1);
                    btnToMove = null;
                }
                else
                {
                    btnToMove.BorderThickness = new Thickness(1);
                    btnToMove = null;  
                }
            }
        }
    }
}