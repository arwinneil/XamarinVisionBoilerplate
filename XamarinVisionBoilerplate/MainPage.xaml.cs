using Plugin.Media;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace XamarinVisionBoilerplate
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Plugin.Media.Abstractions.StoreCameraMediaOptions options = new Plugin.Media.Abstractions.StoreCameraMediaOptions();

            var image = await CrossMedia.Current.TakePhotoAsync(options);

            pic.Source = image.Path;
        }
    }
}