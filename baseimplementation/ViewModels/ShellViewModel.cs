using Prism.Mvvm;
using Prism.Regions;
using PrismBaseApp.Views;

namespace PrismBaseApp.ViewModels
{
    public class ShellViewModel : BindableBase
    {
        public ShellViewModel(IRegionManager regionManager)
        { 
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(Home));
        }
    }
}