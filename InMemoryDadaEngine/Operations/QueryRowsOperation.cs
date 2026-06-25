using InMemoryDadaEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMemoryDadaEngine.Operations
{
    public class QueryRowsOperation : DataOperationBase
    {
        private readonly Table _table;
        private readonly ICondition _condition;
        private readonly List<Row> _result;
        public QueryRowsOperation(Table table, ICondition condition)
        {
            _table = table;
            _condition = condition;
            _result = new List<Row>();
        }
        protected override void Validate()
        {
            if (_table == null)
                throw new Exception("table dose not exsist");
            if (_condition == null) throw new Exception("condition is required");
        }
        protected override List<Row> Execute()
        {
            foreach (Row row in _table.Rows)
            {
                if (_condition.Evaluate(row))
                {
                    _result.Add(row);
                }
            }
            return _result;
        }
    }
}