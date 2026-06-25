using InMemoryDadaEngine.Models;
using System;
using System.Collections.Generic;

namespace InMemoryDadaEngine.Operations
{
    public class RemoveTableOperation : DataOperationBase
    {
        private readonly DataBase _database;
        private readonly string _tableName;


        public RemoveTableOperation(DataBase database, string tableName)
        {
            _database = database;
            _tableName = tableName;
        }


        protected override void Validate()
        {
            if (_database == null)
            {
                throw new Exception("Database does not exist");
            }


            if (!_database.Tables.ContainsKey(_tableName))
            {
                throw new Exception("Table does not exist");
            }
        }



        protected override List<Row> Execute()
        {
            _database.Tables.Remove(_tableName);


            return new List<Row>();
        }
    }
}