namespace PersonalWebsite.Web
{
    public class Views
    {
        public const string MainLayout = "~/Views/Shared/_Layout.cshtml";

        public class Layouts
        {
            public const string EditPostLayout = "~/Views/Layouts/EditPostLayout.cshtml";
        }

        public class Home
        {
            public const string HomeView = "~/Areas/Home/Home.cshtml";
        }

        public class Blog
        {
            public class Post
            {
                public const string PostView = "~/Areas/Blog/Post/Post.cshtml";
                public const string EditPostView = "~/Areas/Blog/Post/EditPost/EditPost.cshtml";
                public const string DeletePostView = "~/Areas/Blog/Post/EditPost/EditPost.cshtml";
            }
        }

        public class Membership
        {
            public class Login
            {
                public const string LoginView = "~/Areas/Membership/Login/Login.cshtml";
            }
        }
    }
}