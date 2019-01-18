using System;
using Xamarin.Forms;

namespace XFFormattedStringBug
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void OpenToc(object sender, EventArgs e) =>
            Device.OpenUri(new Uri("https://google.com"));

        public void OpenPP(object sender, EventArgs e) =>
            Device.OpenUri(new Uri("https://twitter.com"));
    }
}
