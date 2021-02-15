using System;
using System.Threading;

namespace ExampleEventsAndDelegatesCS
{
    public class VideoEncoder
    {
        // 1- Define a delegate
        // 2- Define an event based on that delegate
        // 3- Raise the event
        // a delegate determens the signature of the publisher
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // EventHandler
        // EventHandler<TEventArgs> generic

        public event VideoEncodedEventHandler VideoEncoded;
        public void Encode(Video video)
        {
            System.Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video });
        }
    }
}