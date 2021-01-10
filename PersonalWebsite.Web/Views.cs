namespace PersonalWebsite.Web
{
    public class Views
    {
        public const string MainLayout = "~/Views/Shared/_Layout.cshtml";

        public class Home
        {
            public const string HomeView = "~/Areas/Home/Home.cshtml";
        }

        public class Blog
        {
            public class Post
            {
                public const string PostView = "~/Areas/Blog/Post/Post.cshtml";
            }
        }
    }
}