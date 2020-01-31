using Prism.Mvvm;
using Prism.Regions;
using PrismFullApp.Views;

namespace PrismFullApp.ViewModels
{
    public class ShellViewModel : BindableBase
    {
        public ShellViewModel(IRegionManager regionManager)
        { 
            regionManager.RegisterViewWithRegion("HeaderRegion", typeof(Header));
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(Home));
        }
    }
}