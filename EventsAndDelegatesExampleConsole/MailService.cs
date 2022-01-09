namespace EventsAndDelegatesExampleConsole
{
    public class MailService : IMailService
    {
        public void OnVideoEncoded(object sender, VideoEventArgs e)
        {
            Console.WriteLine($"MailServic: video title: { e.Video.Title }");
        }
    }
}
