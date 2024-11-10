using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    //<T> Dizendo que minha classe é GENERICA, onde posso passar qualquer outra classe pra ela.
    public class Repository<T> where T : class
    {
        //Criando nosso respository generico, onde teremos o CRUD que posso implantar nas demais classes
        // private readonly SqlConnection _connection;
        // public Repository(SqlConnection connection)
        //     => _connection = connection;

        public IEnumerable<T> Get() => Database.Connection.GetAll<T>();

        public T GetById(int id) => Database.Connection.Get<T>(id);

        // => é um exemplo de Expression Body
        public void Create(T model) => Database.Connection.Insert<T>(model);

        //exemplo de Expression Body
        public void Update(T model) => Database.Connection.Update<T>(model);

        public void Delete(T model) => Database.Connection.Delete<T>(model);

        public void DeleteById(int id)
        {
            var model = Database.Connection.Get<T>(id); //Busco o ID
            Database.Connection.Delete<T>(model); // Excluo
        }

    }
}