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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Suggrafeas
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Biblia : Page
    {
        public Biblia()
        {
            this.InitializeComponent();
            this.Loaded += BibliaPage;

            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            Windows.UI.Core.SystemNavigationManager.GetForCurrentView().BackRequested += (s, a) =>
            {
                if (Frame.CanGoBack)
                {
                    Frame.GoBack();
                    a.Handled = true;
                }
            };
        }




        public static BitmapImage Source { get; internal set; }

        private async void BibliaPage(object sender, RoutedEventArgs e)

        {
            XDocument loadedData;
            StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Books.xml"));
            Stream stream = await file.OpenStreamForReadAsync();
            loadedData = XDocument.Load(stream);
            foreach (var item in loadedData.Descendants("Item"))

            {
                Dedomena p = new Dedomena();
                p.Image = item.Element("image").Value;
                p.Onoma = item.Element("onoma").Value;
                p.Description = item.Element("description").Value;
                MyGridView.Items.Add(p);

            }

        }

        private void MyGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
               this.Frame.Navigate(typeof(Perilhpseis), MyGridView.SelectedItem);
        
           
        }
    }
    }



