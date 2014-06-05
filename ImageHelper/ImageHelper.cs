using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;

namespace DocumentPagingUtils
{
    public class ImageHelper
    {
        public static Bitmap AdjustColors(Image originalImage, float brightness, float contrast, float gamma)
        {
            Bitmap adjustedImage = new Bitmap(originalImage.Width, originalImage.Height);

            float adjustedBrightness = brightness - 1.0f;
            // create matrix that will brighten and contrast the image
            float[][] ptsArray ={
                    new float[] {contrast, 0, 0, 0, 0}, // scale red
                    new float[] {0, contrast, 0, 0, 0}, // scale green
                    new float[] {0, 0, contrast, 0, 0}, // scale blue
                    new float[] {0, 0, 0, 1.0f, 0}, // don't scale alpha
                    new float[] {adjustedBrightness, adjustedBrightness, adjustedBrightness, 0, 1}};

            var imageAttributes = new ImageAttributes();
            imageAttributes.ClearColorMatrix();
            imageAttributes.SetColorMatrix(new ColorMatrix(ptsArray), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            imageAttributes.SetGamma(gamma, ColorAdjustType.Bitmap);

            using (Graphics g = Graphics.FromImage(adjustedImage))
            {
                g.DrawImage(
                    originalImage,
                    new Rectangle(0, 0, adjustedImage.Width, adjustedImage.Height)
                    , 0, 0, originalImage.Width, originalImage.Height,
                    GraphicsUnit.Pixel,
                    imageAttributes
                );
            }

            return adjustedImage;
        }

        public static void AdjustColors(string pathIn, string pathOut, float brightness, float contrast, float gamma, ImageFormat imf = null)
        {
            Bitmap output = null;
            try 
            {
                using (var orig = Image.FromFile(pathIn))
                {
                    output = AdjustColors(orig, brightness, contrast, gamma);
                }
            }
            finally
            {
                if (null != output)
                {
                    // Default to PNG
                    if (imf == null)
                        imf = ImageFormat.Png;

                    output.Save(pathOut, imf);
                    output.Dispose();
                }
            }
        }
    }
}
