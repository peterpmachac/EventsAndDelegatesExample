
namespace EventsAndDelegatesExampleConsole
{
    public interface IMessageService
    {
        void OnVideoEncoded(object sender, VideoEventArgs e);
    }
}