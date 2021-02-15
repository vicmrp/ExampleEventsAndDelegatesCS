using System;

namespace ExampleEventsAndDelegatesCS
{    
    public class MessegeService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            System.Console.WriteLine("MessegeService: Sending a text message... " + args.Video.Title);
        }
    }
}