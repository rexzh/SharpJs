using JavaScript;

namespace enyo
{
    [NoCompile]
    public class ImageScale
    {
        private ImageScale() { }
        public static implicit operator ImageScale(string val)
        {
            return null;
        }

        public static implicit operator ImageScale(float val)
        {
            return null;
        }

        /// <summary>
        /// Fits the image to the size of the ImageView
        /// </summary>
        [EvalAtCompile]
        public const string Auto = "auto";

        /// <summary>
        /// Fits the image the width of the ImageView
        /// </summary>
        [EvalAtCompile]
        public const string Width = "width";

        /// <summary>
        /// Fits the image to the height of the ImageView
        /// </summary>
        [EvalAtCompile]
        public const string Height = "height";
    }
}
