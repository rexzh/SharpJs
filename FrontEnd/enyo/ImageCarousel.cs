using System;

namespace enyo
{
    public class ImageCarousel : enyo.Panels
    {
        /// <summary>
        /// The default scale value to be applied to each ImageView. Can be "auto", "width", "height", or any positive numeric value.
        /// </summary>
        public ImageScale DefaultScale;

        /// <summary>
        /// If true, ImageView instances are created with zooming disabled.
        /// </summary>
        public bool DisableZoom { get; set; }

        /// <summary>
        /// If true, any ImageViews that are not in the immediate viewing area (i.e., the currently active image and the first image on either side of it) will be destroyed to free up memory.
        /// This has the benefit of using minimal memory (which is good for mobile devices), but has the downside that, if you want to view the images again, the ImageViews will have to be re-created and the images re-fetched (thus increasing the number of image-related GET calls). Defaults to false.
        /// </summary>
        public bool LowMemory { get; set; }

        /// <summary>
        /// Array of image source file paths
        /// </summary>
        public string[] Images { get; set; }

        /// <summary>
        /// Returns the currently displayed ImageView.
        /// </summary>
        /// <returns></returns>
        public ImageView GetActiveImage()
        {
            return null;
        }

        /// <summary>
        /// Returns the ImageView with the specified index.
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public ImageView GetImageByIndex(int idx)
        {
            return null;
        }

        /// <summary>
        /// Destroys any ImageView objects that are not in the immediate viewing area (i.e., the currently active image and the first image on either side of it) to free up memory. If you set the Image Carousel's lowMemory property to true, this function will be called automatically as needed.
        /// </summary>
        public void CleanupMemory()
        {
        }
    }
}
