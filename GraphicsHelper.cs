using System.Drawing.Imaging;

namespace MicActiveBar
{
    internal static class GraphicsHelper
    {

        public static Icon Darken(this Icon icon, float darkenFactor)
        {
            return icon.ToBitmap().Darken(darkenFactor).ToIcon();
        }

        public static Icon ToIcon(this Image img)
        {
            var ms = new MemoryStream();
            var bw = new BinaryWriter(ms);
            // Header
            bw.Write((short)0);   // 0 : reserved
            bw.Write((short)1);   // 2 : 1=ico, 2=cur
            bw.Write((short)1);   // 4 : number of images
                                  // Image directory
            var w = img.Width;
            if (w >= 256) w = 0;
            bw.Write((byte)w);    // 0 : width of image
            var h = img.Height;
            if (h >= 256) h = 0;
            bw.Write((byte)h);    // 1 : height of image
            bw.Write((byte)0);    // 2 : number of colors in palette
            bw.Write((byte)0);    // 3 : reserved
            bw.Write((short)0);   // 4 : number of color planes
            bw.Write((short)0);   // 6 : bits per pixel
            var sizeHere = ms.Position;
            bw.Write(0);     // 8 : image size
            var start = (int)ms.Position + 4;
            bw.Write(start);      // 12: offset of image data
                                  // Image data
            img.Save(ms, ImageFormat.Png);
            var imageSize = (int)ms.Position - start;
            ms.Seek(sizeHere, SeekOrigin.Begin);
            bw.Write(imageSize);
            ms.Seek(0, SeekOrigin.Begin);

            // And load it
            return new Icon(ms);
        }

        public static Bitmap Darken(this Bitmap b, float intensity)
        {
            Bitmap b2 = new Bitmap(b.Width, b.Height);

            ImageAttributes ia = new ImageAttributes();

            ColorMatrix m = new ColorMatrix(new float[][] {
                new float[] { 1, 0, 0, 0, 0 },
                new float[] { 0, 1, 0, 0, 0 },
                new float[] { 0, 0, 1, 0, 0 },
                new float[] { 0, 0, 0, intensity, 0 },
                new float[] { 0, 0, 0, 0, 1 }
            });

            ia.SetColorMatrix(m);
            Graphics g = Graphics.FromImage(b2);
            g.DrawImage(b, new Rectangle(0, 0, b.Width, b.Height), 0, 0, b.Width, b.Height, GraphicsUnit.Pixel, ia);
            return b2;
        }

        public static Icon GetSoundIndicationIcon(MABOptions options)
        {
            return Properties.Resources.no_sound.Darken(options.Darken);
        }
    }
}