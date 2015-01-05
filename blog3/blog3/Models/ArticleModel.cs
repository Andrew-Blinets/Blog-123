using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace blog3.Models
{
    public class ArticleModel
    {
        public ArticleModel()
        {
            Title = "qown cjs csjod ";
            Body = "<p>Etiam vitae lacus eu arcu rutrum fermentum. Nullam fringilla imperdiet magna, id sagittis nisl feugiat at. Donec eget lacus eros, et blandit odio. Maecenas et urna vitae sapien dictum dapibus. Aliquam id sem metus. Aenean sapien felis, congue porttitor elementum quis, pretium sit amet urna. Curabitur libero sapien, sollicitudin in pellentesque id, auctor id nisl.</p>";
            Date = DateTime.Now.AddDays(0);
            Comments = new Collection<CommentItemModel>();
            Likes = new Collection<LikeModel>();
        }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }


        public ICollection<LikeModel> Likes { get; set; }
        public ICollection<CommentItemModel> Comments { get; set; }

    }
}