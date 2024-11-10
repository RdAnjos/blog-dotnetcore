using Microsoft.Data.SqlClient;

namespace Blog
{
    //As classes static sempre ficam na memoria, nunca saem (quando nosso programa esta sendo executado)
    public static class Database
    {
        public static SqlConnection Connection;
    }
}