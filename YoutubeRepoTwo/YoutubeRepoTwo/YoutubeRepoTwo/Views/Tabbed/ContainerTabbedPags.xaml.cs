using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace YoutubeRepoTwo.Views.Tabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContainerTabbedPags : Xamarin.Forms.TabbedPage
    {
        public ContainerTabbedPags()
        {
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Top);
            On<Android>().SetIsSmoothScrollEnabled(true);
        }
    }
}