using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsAndDelegates
{
    class VideoEncoder
    {
        // Step 1 - Define a delegate
        // Step 2 - Define an event based on that delegate
        // Step 3 - Raise the event


        // If the name of the event is 'VideoEncoded', then delegate is ...EventHandler
        // Step 1
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        // Step 2
        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded();
        }

        // Step 3
        protected virtual void OnVideoEncoded()
        {
            if(VideoEncoded != null)
            {
                // Event
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}
