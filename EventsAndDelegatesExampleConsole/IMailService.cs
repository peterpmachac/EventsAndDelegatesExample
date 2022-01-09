
namespace EventsAndDelegatesExampleConsole
{
    public interface IMailService
    {
        void OnVideoEncoded(object sender, VideoEventArgs e);
    }
}