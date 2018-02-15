using System.Data.Common;
using Npgsql;

namespace Events_Repository.Tools
{
    using System;
    using System.Data;
    using System.Data.SqlClient;

    public interface IDBManager : IDisposable
    {
        void Open();
        void Close();
        object ScalarRequest(string sqlRequest, string[] items, bool isStoreProc = false);
        DataTable TableRequest(string sqlRequest, string[] items);
        DataRow RowRequest(string sqlRequest, string[] items);
        DataColumn ColumnsRequest(string sqlRequest, string[] items);
        void AvoidRequest(string sqlRequest, string[] items);
    }

    public class DBManagersCreator
    {
        public IDBManager CreateDefaultConnection()
        {
            var config = Config.GetConfig();
            var typeDataBase = config["TypeDatabase"];
            var connectionString = config["ConnectionStrings:" + typeDataBase];
            if (typeDataBase.Equals("PostgreSQL"))
            {
                var db = new PostgreSQLDBManager(connectionString);
                db.Open();
                return db;
            }

            return null;
        }

    }

    public abstract class DBManager : IDBManager
    {
        private SqlConnection _cnn;
        private SqlTransaction _transaction;
        private string _transactionName;
        protected string connectionString;

        public virtual void Dispose()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Open thread to  data base
        /// </summary>
        /// <returns></returns>
        public virtual void Open()
        {
            _cnn = new SqlConnection(connectionString);
            _cnn.Open();
        }

        /// <summary>
        /// Close thread to  data base
        /// </summary>
        /// <returns></returns>
        public virtual void Close()
        {
            _cnn.Close();
        }

        /// <summary>
        /// Execute and return object
        /// </summary>
        /// <param name="sqlRequest"></param>
        /// <param name="items"></param>
        /// <returns></returns>
        public virtual object ScalarRequest(string sqlRequest, string[] items, bool isStoreProc = false)
        {
            using (var connection = new SqlConnection(""))
            {
                var command = new SqlCommand(sqlRequest, connection);
                try
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}\t{2}",
                            reader[0], reader[1], reader[2]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return null;
            }
        }

        /// <summary>
        /// Execute and return table items
        /// </summary>
        /// <param name="sqlRequest"></param>
        /// <param name="items"></param>
        /// <returns></returns>
        public virtual DataTable TableRequest(string sqlRequest, string[] items)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Execute and return row items
        /// </summary>
        /// <param name="sqlRequest"></param>
        /// <param name="items"></param>
        /// <returns></returns>
        public virtual DataRow RowRequest(string sqlRequest, string[] items)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Execute and return column items
        /// </summary>
        /// <param name="sqlRequest"></param>
        /// <param name="items"></param>
        /// <returns></returns>
        public virtual DataColumn ColumnsRequest(string sqlRequest, string[] items)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Execute and return anyitem
        /// </summary>
        /// <param name="sqlRequest"></param>
        /// <param name="items"></param>
        public virtual void AvoidRequest(string sqlRequest, string[] items)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create tansaction
        /// </summary>
        public virtual void CreateTransaction()
        {
            _transactionName = Guid.NewGuid().ToString().Replace("-", "");
            _transaction = _cnn.BeginTransaction(_transactionName);
        }

        /// <summary>
        /// Rollback transaction
        /// </summary>
        public virtual void RollbackTransaction()
        {
            if (_transaction != null)
            {
                _transaction.Rollback();
                _transaction = null;
                _transactionName = null;
            }
        }
    }

    public class PostgreSQLDBManager : DBManager, IDBManager, IDisposable
    {
        private NpgsqlConnection _cnn;
        private NpgsqlTransaction _transaction;
        private string _transactionName;
        protected string connectionString;

        public PostgreSQLDBManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public override void CreateTransaction()
        {
            //_transactionName = Guid.NewGuid().ToString().Replace("-", "");
            _transaction = _cnn.BeginTransaction();
        }

        public override void RollbackTransaction()
        {
            if (_transaction != null)
            {
                _transaction.Rollback();
                _transaction = null;
                _transactionName = null;
            }
        }


        public override void Dispose()
        {
        }

        public virtual void Open()
        {
            _cnn = new NpgsqlConnection(connectionString);
            _cnn.Open();
        }

        public virtual void Close()
        {
            _cnn.Close();
        }

        public override object ScalarRequest(string sqlRequest, string[] items, bool isStoreProc = false)
        {
            object result = null;
            if (_cnn.State == ConnectionState.Closed) _cnn.Open();
            using (var cmd = new NpgsqlCommand(sqlRequest, _cnn))
            {
                if (isStoreProc) cmd.CommandType = CommandType.StoredProcedure;
                if (_transaction != null)
                {
                    cmd.Transaction = _transaction;
                }
                //if (parameters.IsNotEmpty())
                //{
                //    foreach (var pair in parameters)
                //    {
                //        cmd.Parameters.AddWithValue(pair.Key, pair.Value ?? DBNull.Value);
                //    }
                //}
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        result = reader[0];
                        if (result == DBNull.Value) result = null;
                    }
                }
            }

            return result;
            //using (var connection = new SqlConnection())
            //{
            //    var command = new SqlCommand(sqlRequest, connection);
            //    try
            //    {
            //        connection.Open();
            //        var reader = command.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            Console.WriteLine("\t{0}\t{1}\t{2}",
            //                reader[0], reader[1], reader[2]);
            //        }
            //        reader.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }

            //    return null;
            //}
        }

        public override DataTable TableRequest(string sqlRequest, string[] items)
        {
            throw new NotImplementedException();
        }

        public override DataRow RowRequest(string sqlRequest, string[] items)
        {
            throw new NotImplementedException();
        }

        public override DataColumn ColumnsRequest(string sqlRequest, string[] items)
        {
            throw new NotImplementedException();
        }

        public override void AvoidRequest(string sqlRequest, string[] items)
        {
            throw new NotImplementedException();
        }
    }

    public class PostgreSQLDBManagerTest : PostgreSQLDBManager
    {
        public PostgreSQLDBManagerTest(string connectionString) : base(connectionString)
        {

        }

        public override void Open()
        {
            base.Open();
            base.CreateTransaction();
        }

        public override void Close()
        {
            base.RollbackTransaction();
            base.Close();
        }
    }
}
