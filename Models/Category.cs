using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Blog.Models
{
    [Table("[Category]")]
    public class Category
    {
        public Category()
            => Posts = new List<Post>();

        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }

        //Quando tenho 1 para Muitos
        //Ex: Em um [POST] tenho uma LISTA  de [CATEGORIAS]
        [Write(false)]
        public List<Post> Posts { get; set; }
    }
}