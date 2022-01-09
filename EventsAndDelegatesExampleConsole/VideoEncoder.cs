﻿namespace EventsAndDelegatesExampleConsole
{
    internal class VideoEncoder
    {
        // 1: Define a delegate
        // 2: Define an event based on the delegate
        // 3: Raise the event

        // EventHandler
        // EventHandler<TEventArgs>
        // Differnt ways to declare
        // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        public event EventHandler<VideoEventArgs> VideoEncoded;
        //public event EventHandler VideoEncoded02;


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video... ");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }
}
