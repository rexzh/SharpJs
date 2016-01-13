namespace JavaScript.Html
{
    public abstract class History
    {
        private History()
        {
        }

        /// <summary>
        /// Returns the number of URLs in the history list
        /// </summary>
        public readonly uint length;

        /// <summary>
        /// Loads the previous URL in the history list
        /// </summary>
        public void Back()
        {
        }

        /// <summary>
        /// Loads the next URL in the history list
        /// </summary>
        public void Forward()
        {
        }

        /// <summary>
        /// Loads a specific URL from the history list, -1 = back, 1 = forward
        /// </summary>
        public void Go(int num)
        {
        }

        /// <summary>
        /// The string must be a partial or full URL, and the function will go to the first URL that matches the string
        /// </summary>
        /// <param name="url"></param>
        public void Go(string url)
        {
        }
    }
}
