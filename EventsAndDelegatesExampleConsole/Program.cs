namespace EventsAndDelegatesExampleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber
            var messageServie = new MessageService(); //subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageServie.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}


// C# Events and Delegates Made Simple | Mosh
// https://www.youtube.com/watch?v=jQgwEsJISy0