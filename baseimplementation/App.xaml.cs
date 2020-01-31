using System.Windows;
using Prism.Ioc;
using Prism.Unity;
using Prism.Unity.Ioc;
using PrismBaseApp.Views;

namespace PrismBaseApp
{
    public partial class App : PrismApplication
    { 
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Register services here
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override IContainerExtension CreateContainerExtension()
        {
            return new UnityContainerExtension();
        }
    }
}