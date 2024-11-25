using Blog.Models;
using Blog.Repositories;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class TagPostsRepository : Repository<Tag>
    {
        private readonly SqlConnection _connection;

        public TagPostsRepository(SqlConnection connection) : base()
           => _connection = connection;

        public List<Tag> ListTagAndPostsQuantity()
        {
            var query = @"SELECT 
                            [Tag].*,
                            [Post].[Id],
                            COUNT([Post].[Id]) AS [Posts]
                        FROM 
                            [Tag]
                        INNER JOIN [PostTag] ON [PostTag].[TagId] = [Tag].[Id]
                        INNER JOIN [Post] ON [PostTag].[PostId] = [Post].[Id]
                        GROUP BY     
                            [Tag].[Id],
                            [Tag].[Name],
                            [Tag].[Slug],
                            [Post].[Id]";

            var listTags = new List<Tag>();

            var items = _connection.Query<Tag, Post, Tag>(
                query,
                (tag, post) =>
                {
                    var tags = listTags.FirstOrDefault(t => t.Id == tag.Id);

                    if (tags == null)
                    {
                        tags = tag;
                        if (post != null)
                        {
                            tags.Posts.Add(post);
                        }
                        listTags.Add(tags);
                    }
                    else
                    {
                        tags.Posts.Add(post);
                    }
                    return tag;
                }, splitOn: "Id");
            return listTags;
        }

    }
}