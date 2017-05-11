using System.Text;

namespace VideoTest
{
    public class Video
    {
        public Frame[] Footage { get; set; }
        public int Length { get; private set; }

        public Video (int seconds)
        {
            Footage = new Frame[seconds];
            Length = seconds;
        }

        public StringBuilder ShowVideo()
        {
            StringBuilder video = new StringBuilder();

            for (int i = 0; i < Length; i++)
            {
                video.Append(Footage[i].ShowFrame());
            }

            return video;
        }
    }
}
