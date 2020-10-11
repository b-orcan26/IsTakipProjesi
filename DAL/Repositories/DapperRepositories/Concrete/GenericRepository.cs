using DAL.Repositories.DapperRepositories.Interfaces;
using Dapper;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.DapperRepositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly string _tableName;
        protected IConnectionFactory connectionFactory;
        private IEnumerable<PropertyInfo> GetProperties => typeof(T).GetProperties();
       

        protected GenericRepository(string tableName , IConnectionFactory factory)
        {
            _tableName = tableName;
            connectionFactory = factory;
        }

        public async Task Add(T entity)
        {
            var query = GenerateInsertQuery(entity);
            using (var connection = connectionFactory.GetConnection())
            {
                await connection.ExecuteAsync(query, entity);
            }
        }


        private string GenerateInsertQuery(T entity)
        {
            var insertQuery = new StringBuilder($"INSERT INTO {_tableName} ");

            insertQuery.Append("(");

            var properties = GenerateListOfProperties(GetProperties,entity);
            foreach(var prop in properties){
                if(!prop.Equals("Id"))
                insertQuery.Append($"[{prop}],");
            }
            //properties.ForEach(prop => { insertQuery.Append($"[{prop}],"); });

            insertQuery
                .Remove(insertQuery.Length - 1, 1)
                .Append(") VALUES (");

            foreach (var prop in properties)
            {
                if (!prop.Equals("Id"))
                    insertQuery.Append($"@{prop},");
            }
            //properties.ForEach(prop => { insertQuery.Append($"@{prop},"); });

            insertQuery
                .Remove(insertQuery.Length - 1, 1)
                .Append(")");

            return insertQuery.ToString();
        }



        public async Task Delete(int id)
        {
            using (var connection = connectionFactory.GetConnection())
            {
                await connection.ExecuteAsync($"DELETE FROM {_tableName} WHERE Id=@Id", new { Id = id });               
            }
        }

        public async Task<T> Get(int id)
        {
            using (var connection = connectionFactory.GetConnection())
            {
                var result = await connection.QuerySingleOrDefaultAsync<T>($"SELECT * FROM {_tableName} WHERE Id=@Id", new { Id = id });               
                return result;
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            using (var connection = connectionFactory.GetConnection())
            {
                return await connection.QueryAsync<T>($"SELECT * FROM {_tableName}");
            }
        }

        public async Task Update(T entity)
        {
            var updateQuery = GenerateUpdateQuery(entity);

            using (var connection = connectionFactory.GetConnection())
            {
                await connection.ExecuteAsync(updateQuery, entity);
            }
        }

        private static List<string> GenerateListOfProperties(IEnumerable<PropertyInfo> listOfProperties, T entity)
        {            
            var liste = new List<string>();
            foreach(var item in listOfProperties)
            {
                if (typeof(T).GetProperty(item.Name.ToString()).GetValue(entity)!=null)
                {
                    liste.Add(item.Name);
                }
               
            }
            return liste;            
        }

        private string GenerateUpdateQuery(T entity)
        {
            var updateQuery = new StringBuilder($"UPDATE {_tableName} SET ");
            var properties = GenerateListOfProperties(GetProperties,entity);

            properties.ForEach(property =>
            {
                if (!property.Equals("Id"))
                {
                    updateQuery.Append($"{property}=@{property},");
                }
            });

            updateQuery.Remove(updateQuery.Length - 1, 1); //remove last comma
            updateQuery.Append(" WHERE Id=@Id");

            return updateQuery.ToString();
        }
    }
}
