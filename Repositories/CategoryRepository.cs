using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class CategoryRepository : Repository<Category>
    {
        private readonly SqlConnection _connection;
        public CategoryRepository(SqlConnection connection) : base()
            => _connection = connection;


        public List<Category> GetWithPosts()
        {
            var query = @"SELECT 
                            [Category].*,
                            [Post].[Id],
                            [Post].[Title],
                            COUNT([Post].[Id]) AS [Posts]
                        FROM
                            [Category]
                        INNER JOIN [Post] ON [Category].[Id] = [Post].[CategoryId]
                        GROUP BY
                            [Category].Id,
                            [Category].[Name],
                            [Category].[Slug],
                            [Post].[Id],
                            [Post].[Title]";

            var categories = new List<Category>();

            var items = _connection.Query<Category, Post, Category>(
                query,
                (category, post) =>
                {
                    var catrs = categories.FirstOrDefault(x => x.Id == category.Id);
                    if (catrs == null)
                    {
                        catrs = category;

                        if (post != null)
                        {
                            catrs.Posts.Add(post);
                        }
                        categories.Add(catrs);
                    }
                    else
                    {
                        catrs.Posts.Add(post);
                    }
                    return category;
                }, splitOn: "Id");

            return categories;
        }

    }
}