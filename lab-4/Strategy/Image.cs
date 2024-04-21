namespace Strategy
{
    class Image
    {
        private readonly string href;
        private readonly ILoad loader;

        public Image(string href, ILoad loader)
        {
            this.href = href;
            this.loader = loader;
        }

        public void LoadImage()
        {
            loader.LoadImage(href);
        }
    }
}
