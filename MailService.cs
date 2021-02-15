using System;

namespace ExampleEventsAndDelegatesCS
{    
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            System.Console.WriteLine("MailService: Sending an email..." + args.Video.Title);
        }
    }
}