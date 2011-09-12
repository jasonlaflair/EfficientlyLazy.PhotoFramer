using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;

namespace EfficientlyLazy.PhotoFramer.Services
{
    public static class ImageUtilities
    {
        private static Dictionary<string, ImageCodecInfo> _encoders;

        private static Dictionary<string, ImageCodecInfo> Encoders
        {
            get
            {
                if (_encoders == null)
                {
                    _encoders = new Dictionary<string, ImageCodecInfo>();
                }

                //if there are no codecs, try loading them 
                if (_encoders.Count == 0)
                {
                    //get all the codecs 
                    foreach (ImageCodecInfo codec in ImageCodecInfo.GetImageEncoders())
                    {
                        //add each codec to the quick lookup 
                        _encoders.Add(codec.MimeType.ToLower(), codec);
                    }
                }

                //return the lookup 
                return _encoders;
            }
        }

        /// <summary>  
        /// Returns the image codec with the given mime type  
        /// </summary>  
        private static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            //do a case insensitive search for the mime type 
            string lookupKey = mimeType.ToLower();

            //the codec to return, default to null 
            ImageCodecInfo foundCodec = null;

            //if we have the encoder, get it to return 
            if (Encoders.ContainsKey(lookupKey))
            {
                //pull the codec from the lookup 
                foundCodec = Encoders[lookupKey];
            }

            return foundCodec;
        }

        /// <summary> 
        /// Resize the image to the specified width and height. 
        /// </summary> 
        /// <param name="image">The image to resize.</param> 
        /// <param name="width">The width to resize to.</param> 
        /// <param name="height">The height to resize to.</param> 
        /// <returns>The resized image.</returns> 
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var result = new Bitmap(width, height);

            //use a graphics object to draw the resized image into the bitmap 
            using (var graphics = Graphics.FromImage(result))
            {
                //set the resize quality modes to high quality 
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                //draw the image into the target bitmap 
                graphics.DrawImage(image, 0, 0, result.Width, result.Height);
            }

            //return the resulting bitmap 
            return result;
        }

        /// <summary>  
        /// Saves an image as a jpeg image, with the given quality  
        /// </summary>  
        /// <param name="path">Path to which the image would be saved.</param>
        /// <param name="image"></param>
        /// <param name="quality">An integer from 0 to 100, with 100 being the  
        /// highest quality</param>  
        /// <exception cref="ArgumentOutOfRangeException"> 
        /// An invalid value was entered for image quality. 
        /// </exception> 
        public static void SaveJpeg(string path, Image image, int quality)
        {
            if ((quality < 0) || (quality > 100))
            {
                var error = string.Format("Jpeg image quality must be between 0 and 100, with 100 being the highest quality.  A value of {0} was specified.", quality);
                throw new ArgumentOutOfRangeException(error);
            }

            var qualityParam = new EncoderParameter(Encoder.Quality, quality);
            var jpegCodec = GetEncoderInfo("image/jpeg");

            var encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = qualityParam;
            image.Save(path, jpegCodec, encoderParams);
        }

        
    } 
}
