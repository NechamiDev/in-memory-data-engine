using InMemoryDadaEngine.Models;
using System;
using System.Collections.Generic;

namespace InMemoryDadaEngine.Operations
{
    public class CreateTableOperation : DataOperationBase
    {
        private readonly DataBase _database;
        private readonly Table _table;


        public CreateTableOperation(DataBase database, Table table)
        {
            _database = database;
            _table = table;
        }



        protected override void Validate()
        {
            if (_database == null)
            {
                throw new Exception("Database does not exist");
            }


            if (_table == null)
            {
                throw new Exception("Table is required");
            }


            if (_database.Tables.ContainsKey(_table.Name))
            {
                throw new Exception("Table already exists");
            }
        }



        protected override List<Row> Execute()
        {
            _database.Tables.Add(_table.Name, _table);


            return new List<Row>();
        }
    }
}