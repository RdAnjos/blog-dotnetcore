using Dapper.Contrib.Extensions;

namespace Blog.Models
{
    [Table("[Post]")]
    public class Post
    {
        public Post()
        {
            Tags = new List<Tag>();
            Categories = new List<Category>();
        }


        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

        //Relação Muitos para 1.
        // Ex: Muitos [Posts] para 1 [Categoria e Author]
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }

        [Write(false)]
        public List<Tag> Tags { get; set; }

        [Write(false)]
        public List<Category> Categories { get; set; }

    }
}