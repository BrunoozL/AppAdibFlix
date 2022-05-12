using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAdibFlix.Filmes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Batman : ContentPage
    {
        public Batman()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppAdibFlix.Imagens.banner.png");
            poster.Source = ImageSource.FromResource("AppAdibFlix.Posters.batman.jpg");

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width = '400'
                                        height = '300'
                                        src = 'https://www.youtube.com/watch?v=HJv4LQxbVEA'
                                        frameborder = '0'
                                        allow = 'accelerometer; autoplay; encrypted-media; gyroscope;
                                            picture-in-picture'
                                        allowfullscreen
                                </iframe>";

            visualizador.Source = htmlSource;
        }
    }
}