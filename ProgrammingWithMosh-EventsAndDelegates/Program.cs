using System;
using System.Threading;

namespace ProgrammingWithMosh_EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber
            var messageService = new MessageService(); //another subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; //No parenthesis because it's a reference/pointer to the method
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded; //This is multicasting

            videoEncoder.Encode(video);

            Console.ReadLine();
        }
    }

    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: Sending a text message..." + e.Video.Title);
        }
    }

    class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending an email..." + e.Video.Title);
        }
    }

    public class Video
    {
        public string Title { get; set; }
    }

    class VideoEncoder
    {
        // 1- Define a delegate
        // 2- Define an event based on that delegate
        // 3- Raise the event

        //The delegate below holds a reference to a method that looks like the below:
        //void VideoEncodedEventHandler(object source, EventArgs e);
 
        //public delegate void EventHandler(object source, VideoEventArgs args);

        // EventHandler
        // EventHandler<TEventArgs>

        public event EventHandler<VideoEventArgs> VideoEncoded;
        
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);
            //Console.WriteLine("Encoding Complete. Press any key to continue.");
            //Console.ReadLine();

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            /*
            if (VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);
            */
            VideoEncoded?.Invoke(this, new VideoEventArgs(){ Video = video});
        }
    }
}
