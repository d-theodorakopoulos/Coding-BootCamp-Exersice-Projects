namespace VideoTest
{
    public class Pixel
    {
        public Color color { get; set; }
        
        public Pixel ()
        {
            color = new Color();
        }

        public Pixel (Color newColor)
            : this()
        {
            this.color = newColor;
        }
    }
}
