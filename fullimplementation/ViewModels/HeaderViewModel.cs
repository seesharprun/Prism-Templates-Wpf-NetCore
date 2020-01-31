using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using PrismFullApp.Events;
using PrismFullApp.Services;

namespace PrismFullApp.ViewModels
{
    public class HeaderViewModel : BindableBase
    {
        private int _counter = 0;
        private string _title;
        
        private readonly IEventAggregator _eventAggregator;
        private readonly ITitleService _titleService;

        public HeaderViewModel(IEventAggregator eventAggregator, ITitleService titleService)
        {
            _eventAggregator = eventAggregator;
            _titleService = titleService;

            Title = _titleService.GetMainTitle();

            ChangeTitleCommand = new DelegateCommand(ChangeTitleExecute);
        }

        public DelegateCommand ChangeTitleCommand { get; private set; }
        
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        private void ChangeTitleExecute()
        {
            string message = $"Clicked {++_counter} times!";

            _eventAggregator.GetEvent<MessageEvent>().Publish(message);
        }
    }
}