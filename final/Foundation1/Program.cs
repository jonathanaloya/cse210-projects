class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create and add videos
        Video video1 = new Video
        {
            Title = "Programming with Classes",
            Author = "Duane Richards",
            Length = 300,
            Comments = new List<Comment>
            {
                new Comment { CommenterName = "Jonathan", Text = "Great video!" },
                new Comment { CommenterName = "Steven", Text = "Very informative." },
                new Comment { CommenterName = "Charlie", Text = "I learned a lot." }
            }
        };
        videos.Add(video1);

        Video video2 = new Video
        {
            Title = "Introductio to Data Base",
            Author = "Jane Smith",
            Length = 450,
            Comments = new List<Comment>
            {
                new Comment { CommenterName = "David", Text = "Awesome content!" },
                new Comment { CommenterName = "Emily", Text = "Helped me solve a problem." }
            }
        };
        videos.Add(video2);

        Video video3 = new Video
        {
            Title = "C# Best Practices",
            Author = "Michael Johnson",
            Length = 600,
            Comments = new List<Comment>
            {
                new Comment { CommenterName = "Grace", Text = "Very useful tips." },
                new Comment { CommenterName = "Henry", Text = "I appreciate the examples." },
                new Comment { CommenterName = "Isabella", Text = "Clear explanations." }
            }
        };
        videos.Add(video3);

        // Display video information and comments
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine("- " + comment.CommenterName + ": " + comment.Text);
            }
            Console.WriteLine();
        }
    }
}