
//..................extensions......................


//string post = " this is a post for a very long text test";
//var newpost = post.Shorten(5);
//Console.WriteLine(newpost);
//public static class ExtensionForString
//{
//    public static string Shorten(this string value, int index)
//    {
//        if (index < 0)
//            throw new ArgumentOutOfRangeException("Number of words should be greater or equal to 0");
//        if (index == 0)
//            return "";

//        var words = value.Split(" ");
//        if (words.Length <= index)
//            return value;

//        return String.Join(" ", words.Take(index));
//    }
//}

//...................events..............................

//var video = new Video() { Title = "Video1" };
//var encoder = new VideEncoder();
//var mailservice = new MailService();
//encoder.VideoEncoded += mailservice.OnVideoEncoded;
//encoder.Encode(video);

//public class Video
//{
//    public string Title { get; set; }
//}
//public class VideoEventArgs : EventArgs
//{
//    public Video Video { get; set; }
//}
//public class VideEncoder
//{
//    //1.Define a delegate
//    //2.Define an event based on that delegate
//    //3.Raise the event
//    Action add = () => Console.WriteLine("Test");
//    //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

//    //EventHandler
//    //EventHandler<TEventArgs>
//    public event EventHandler<VideoEventArgs> VideoEncoded;
//    public void Encode(Video video)
//    {
//        Console.WriteLine("Encoding video......");
//        add();
//        Console.WriteLine();
//        Thread.Sleep(3000);
//        OnVideEncoded(video);
//    }
//    protected virtual void OnVideEncoded(Video video)
//    {

//        VideoEncoded?.Invoke(this,new VideoEventArgs() { Video=video});
//    }
//}

//public class MailService
//{
//    public void OnVideoEncoded(object source, VideoEventArgs args)
//    {
//        Console.WriteLine($"Mail service: sending an email.................... video {args.Video.Title} encode");
//    }
//}

//...................Lambda..............
//var books = new BookRepo().GetBooks();
//books.FindAll(x=>x.Price>10);
////foreach (var item in books)
////{
////    Console.WriteLine(item.Name);
////}

//var b1 = new BookRec() { Name = "Test", Price = 10 };
//var b2 = new BookRec() { Name = "Test", Price = 10 };
//if (b1 == b2)
//{
//    Console.WriteLine(b1);
//}
//else
//{
//    Console.WriteLine("Not equal");
//}
//public class BookRepo
//{
//    public List<Book> GetBooks()
//    {
//        return new List<Book>
//        {
//            new Book(){Name="Name1",Price=8},
//            new Book(){Name="Name2",Price=5},
//            new Book(){Name="Name3",Price=30},
//        };
//    }
//}
//public class Book
//{
//    public string Name { get; set; }
//    public int Price { get; set; }
//}
//public record BookRec
//{
//    public string Name { get; set; }
//    public int Price { get; set; }
//}

//...................Delegates.............................
//var photo = new Photo();
//photo.Name = "Test";
//var processor = new PhotoProcessor();
//var filters = new PhotoFilters();
////PhotoProcessor.PhotoHandlerDelegate filterHandler = filters.AddBrightness;
//Action<Photo> filterHandler = filters.AddBrightness;
//filterHandler += filters.AddContrast;
//filterHandler += AddColor;
//processor.Process(photo, AddColor);
//void AddColor(Photo photo)
//{
//Console.WriteLine("Add color");
//}
//public class PhotoProcessor
//{
//    //public delegate void PhotoHandlerDelegate(Photo photo);
//    public void Process(Photo photo, Action<Photo> photoHandler)
//    {

//        photoHandler(photo);
//    }

//}
//public class Photo
//{
//    public string Name { get; set; }
//}

//public class PhotoFilters
//{
//    public void AddBrightness(Photo photo)
//    {
//        Console.WriteLine($"Add brightness to {photo.Name}");
//    }
//    public void AddContrast(Photo photo)
//    {
//        Console.WriteLine($"Add contrast to {photo.Name}");
//    }
//}