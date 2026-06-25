using InMemoryDadaEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMemoryDadaEngine.Operations
{
    internal class InsertRowOperation : DataOperationBase
    {
        private readonly Table _table;
        private readonly Row _row;
        public InsertRowOperation(Table table, Row row)
        {
            _table = table;
            _row = row;
        }
        protected override void Validate()
        {
            if (_table == null)
            {
                throw new Exception("Table does not exist");
            }
            if (_row == null)
            {
                throw new Exception("Row is required");
            }
        }
        protected override List<Row> Execute()
        {
            _table.Rows.Add(_row);

            return new List<Row>()
            {
                _row
            };
            
        }

    }
}
