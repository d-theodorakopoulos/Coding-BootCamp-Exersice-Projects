using System.Text;

namespace VideoTest
{
    public class Frame
    {
        public Pixel[,] ImageFrame { get; private set; }

        public int FrameWidth
        {
            get {return ImageFrame.GetLength(0); }
        }
        public int FrameHeight
        {
          get { return ImageFrame.GetLength(1); }
        }

        public Frame (int width, int height)
        {
            ImageFrame = new Pixel [width,height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    ImageFrame[i, j] = new Pixel();
                }
            }
        }

        public StringBuilder ShowFrame()
        {
            StringBuilder frame = new StringBuilder();
            for (int i = 0; i < FrameWidth; i++)
            {
                for (int j = 0; j < FrameHeight; j++)
                {
                    frame.Append(ImageFrame[i, j].color);
                }
                frame.AppendLine();
            }
            return frame;
        }
    }
}
