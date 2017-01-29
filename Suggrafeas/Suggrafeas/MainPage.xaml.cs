using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Suggrafeas
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private object e;

        public MainPage()
        {

            this.InitializeComponent();
            Button1.Visibility = Visibility.Collapsed;
            MyFrame.Navigate(typeof(Biografiko));
            TextBlock.Text = " Βιογραφικό";
            Biografiko.IsSelected = true;



        }





        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }



        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Biografiko.IsSelected)
            {
                Button1.Visibility = Visibility.Collapsed;
                MyFrame.Navigate(typeof(Biografiko)); TextBlock.Text = "Βιογραφικό";

            }

            if (Sungramata.IsSelected)
            {
                Button1.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(Biblia)); TextBlock.Text = "Συγγράμματα";

            }
            if (EkdotikosOikos.IsSelected)
            {
                Button1.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(Anima)); TextBlock.Text = "Εκδοτικός";

            }
            if (Fwtografies.IsSelected)
            {
                Button1.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(BlankPage1)); TextBlock.Text = "Φωτογραφίες";

            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (MyFrame.CanGoBack)
            {
            MyFrame.GoBack();
            }
        }
    }
}
