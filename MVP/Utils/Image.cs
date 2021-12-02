using System.Drawing;
using System.IO;

namespace MVP.Utils
{
    public class Image
    {
        public static byte[] ConvertImg2Bytes(Image img)
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
