using System;
using Prism.Events;
using Prism.Mvvm;

namespace PrismBaseApp.ViewModels
{
    public class HomeViewModel : BindableBase
    {
        private string _content = "Prism Demo Application";
        
        public string Content
        {
            get => _content;
            set => SetProperty(ref _content, value);
        }
    }
}