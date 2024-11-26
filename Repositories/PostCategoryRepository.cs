using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class PostCategoryRepository : Repository<Post>
    {
        private readonly SqlConnection _connection;

        public PostCategoryRepository(SqlConnection connection) : base()
            => _connection = connection;

        public List<Post> ListPostsAndCategories()
        {
            var query = @"SELECT 
                            [Post].[Id],
                            [Post].[Title],
                            [Post].[Summary],
                            [Post].[CreateDate],
                            [Category].[Id],
                            [Category].[Name],
                            [Category].[Slug]
                        FROM
                            [Post]
                        INNER JOIN [Category] ON [Post].[CategoryId] = [Category].[Id]
                        GROUP BY
                            [Post].[Id],
                            [Post].[Title],
                            [Post].[Summary],
                            [Post].[CreateDate],
                            [Category].[Id],
                            [Category].[Name],
                            [Category].[Slug]";

            var listPosts = new List<Post>();

            var items = _connection.Query<Post, Category, Post>(
                query,
                (post, category) =>
                {
                    var posts = listPosts.FirstOrDefault(x => x.Id == post.Id);

                    if (posts == null)
                    {
                        posts = post;
                        if (category != null)
                        {
                            posts.Categories.Add(category);
                        }
                        listPosts.Add(posts);
                    }
                    else
                    {
                        posts.Categories.Add(category);
                    }
                    return post;
                }, splitOn: "Id"
            );
            return listPosts;
        }
    }
}