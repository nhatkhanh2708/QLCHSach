using System.Drawing;

namespace MVP.Utils
{
    public class Image
    {
        public static byte[] ConvertImg2Bytes(System.Drawing.Image img)
        {
                ImageConverter _imageConverter = new ImageConverter();
                byte[] xByte = (byte[])_imageConverter.ConvertTo(img, typeof(byte[]));
                return xByte;
        }

        public static Image ConvertBytes2Img(byte[] data)
        {
            return (Image)(new ImageConverter()).ConvertFrom(data);
        }
    }
}
