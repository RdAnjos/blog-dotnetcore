using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class ListPostsTagsRepository : Repository<Post>
    {
        private readonly SqlConnection _connection;

        public ListPostsTagsRepository(SqlConnection connection) : base()
        {
            _connection = connection;
        }

        public List<Post> ListPostsAndTags()
        {
            var query = @"SELECT
                            [Post].[Id],
                            [Post].[Title],
                            [Post].[Slug],
                            [Tag].[Id],
                            [Tag].[Name],
                            [Tag].[Slug]
                        FROM 
                            [Post]
                        INNER JOIN [PostTag] ON [Post].[Id] = [PostTag].[PostId]
                        INNER JOIN [Tag] ON [Tag].[Id] = [PostTag].[TagId]
                        GROUP BY
                            [Post].[Id],
                            [Post].[Title],
                            [Post].[Slug],
                            [Tag].[Id],
                            [Tag].[Name],
                            [Tag].[Slug]";

            var listPosts = new List<Post>();

            var items = _connection.Query<Post, Tag, Post>(
                query,
                (post, tag) =>
                {
                    var posts = listPosts.FirstOrDefault(x => x.Id == post.Id);

                    if (posts == null)
                    {
                        posts = post;
                        if (tag != null)
                        {
                            posts.Tags.Add(tag);
                        }
                        listPosts.Add(posts);
                    }
                    else
                    {
                        posts.Tags.Add(tag);
                    }
                    return post;
                }, splitOn: "Id"
            );
            return listPosts;
        }
    }
}