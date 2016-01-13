namespace JavaScript.Html
{
    public abstract class Screen
    {
        /// <summary>
        /// Returns the height of the screen (excluding the Windows Taskbar)
        /// </summary>
        public readonly int AvailHeight;

        /// <summary>
        /// Returns the width of the screen (excluding the Windows Taskbar)
        /// </summary>
        public readonly int AvailWidth;

        /// <summary>
        /// Returns the bit depth of the color palette for displaying images
        /// </summary>
        public readonly int ColorDepth;

        /// <summary>
        /// Returns the total height of the screen
        /// </summary>
        public readonly int Height;

        /// <summary>
        /// Returns the color resolution (in bits per pixel) of the screen
        /// </summary>
        public readonly int PixelDepth;

        /// <summary>
        /// Returns the total width of the screen
        /// </summary>
        public readonly int Width;
    }
}
