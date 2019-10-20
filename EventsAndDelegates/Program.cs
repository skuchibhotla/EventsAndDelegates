using System;

namespace EventsAndDelegates
{
    public class Program
    {
        public void Main(string [] args)
        {
            var video = new Video() { Title = "Video 1" };

            // Publisher
            var videoEncoder = new VideoEncoder();

            // Subscriber
            var mailService = new MailService();

            // OnVideoEncoded is the handler
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }

    // Sending an email once Video is encoded
    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("MailService - Sending an email...");
        }
    }
}
