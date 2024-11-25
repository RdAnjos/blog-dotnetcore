using Dapper.Contrib.Extensions;

namespace Blog.Models
{
    //NOTAÇÃO OU METADADOS - fizemos isso para o Dapper Contrib conseguir acessar essa tabela pois, ele tende a pluralizar os nome das tabelas.
    [Table("[User]")]
    public class User
    {
        //Sempre q tenho uma lista na classe, preciso inicializa-la no metodo CONSTRUTOR
        public User()
            => Roles = new List<Role>();


        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }


        // Aqui estou tratando a tabela [UserRoles]
        // [Write(false)] -> Faz com que nao escreva no INSERT
        [Write(false)]
        public List<Role> Roles { get; set; }
    }
}