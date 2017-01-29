using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class Perilhpseis : Page
    {
        public Perilhpseis()
        {
            this.InitializeComponent();
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
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Dedomena p = (Dedomena)e.Parameter;
            Textblock.Text = p.Onoma;
            Textblock1.Text = p.Description;
            BitmapImage photo = new BitmapImage(new Uri(@"ms-appx:///" + p.Image));
            image.Source = photo;
            image.Source = photo;
        }
    }
}
