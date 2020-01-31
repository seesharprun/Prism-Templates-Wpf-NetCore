using System;
using Prism.Events;
using Prism.Mvvm;
using PrismFullApp.Events;

namespace PrismFullApp.ViewModels
{
    public class HomeViewModel : BindableBase
    {
        private string _content = "Click button to start...";

        private readonly IEventAggregator _eventAggregator;

        public HomeViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

            _eventAggregator.GetEvent<MessageEvent>().Subscribe(MessageEventReceived);
        }
        
        public string Content
        {
            get => _content;
            set => SetProperty(ref _content, value);
        }

        private void MessageEventReceived(string message)
        {
            Content = message;
        }
    }
}