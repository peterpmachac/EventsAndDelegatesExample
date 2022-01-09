namespace EventsAndDelegatesExampleConsole
{
    public class MessageService : IMessageService
    {
        public void OnVideoEncoded(object sender, VideoEventArgs e)
        {
            Console.WriteLine($"MailService: video title: { e.Video.Title }");
        }
    }
}
