using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;

namespace blog.Repositories
{
    public class ListPostsCategoryRepository : Repository<Category>
    {
        private readonly SqlConnection _connection;

        public ListPostsCategoryRepository(SqlConnection connection) : base()
        {
            _connection = connection;
        }

        public List<Category> ListPostsCategory()
        {
            var query = @"SELECT 
                            [Category].[Id],
                            [Category].[Name],
                            [Post].[Id],
                            [Post].[Title],
                            [Post].[Summary],
                            [Post].[Slug]
                        FROM 
                            [Category]
                        INNER JOIN [Post] ON [Category].[Id] = [Post].[CategoryId]
                        GROUP BY
                            [Category].[Id],
                            [Category].[Name],
                            [Post].[Id],
                            [Post].[Title],
                            [Post].[Summary],
                            [Post].[Slug]";

            var listCategory = new List<Category>();

            var items = _connection.Query<Category, Post, Category>(
                query,
                (category, post) =>
                {
                    var categories = listCategory.FirstOrDefault(x => x.Id == category.Id);

                    if (categories == null)
                    {
                        categories = category;
                        if (post != null)
                        {
                            categories.Posts.Add(post);
                        }
                        listCategory.Add(categories);
                    }
                    else
                    {
                        categories.Posts.Add(post);
                    }
                    return category;
                }, splitOn: "Id");
            return listCategory;
        }

    }
}