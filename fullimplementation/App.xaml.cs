using System.Windows;
using Prism.Ioc;
using Prism.Unity;
using Prism.Unity.Ioc;
using PrismFullApp.Services;
using PrismFullApp.Views;

namespace PrismFullApp
{
    public partial class App : PrismApplication
    { 
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<ITitleService, TitleService>();
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