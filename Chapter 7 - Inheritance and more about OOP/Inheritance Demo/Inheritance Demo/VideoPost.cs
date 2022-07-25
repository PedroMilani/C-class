using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Inheritance_Demo
{
    class VideoPost : Post
    {
        // member fields
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;
        protected string VideoURL { get; set; }
        protected int VideoLength { get; set; }
        public VideoPost() { }
        public VideoPost(string title, string sendByUsername, string videoURL, int videoLength, bool isPublic)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            this.VideoURL = videoURL;
            this.VideoLength = videoLength;
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing...");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        public void TimerCallback(Object o)
        {
            if (currDuration < VideoLength)
            {
                currDuration++;
                Console.WriteLine("Video at {0}s", currDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0}s", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3}s - by {4}", 
                this.ID, this.Title, this.VideoURL, this.VideoLength, this.SendByUsername);
        }

    }
}
