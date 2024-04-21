using Strategy;

internal class Program
{
    private static void Main(string[] args)
    {
        var fileSystemImage = new Image(@"C:\test.jpg", new FileSystemImageLoader());
        fileSystemImage.LoadImage();

        var networkImage = new Image("https://example.com/image.jpg", new NetworkImageLoader());
        networkImage.LoadImage();
    }
}