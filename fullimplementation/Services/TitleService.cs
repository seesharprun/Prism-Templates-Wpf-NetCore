namespace PrismFullApp.Services
{
    public interface ITitleService
    {
        string GetMainTitle();
    }

    public sealed class TitleService : ITitleService
    {
        public string GetMainTitle() => "Demo Prism Application";
    }
}