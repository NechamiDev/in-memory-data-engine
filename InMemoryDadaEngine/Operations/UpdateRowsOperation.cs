using InMemoryDadaEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InMemoryDataEngine.Conditions;
namespace InMemoryDadaEngine.Operations
{
    public class UpdateRowsOperation : DataOperationBase
    {
        private readonly Table _table;
        private readonly ICondition _condition;
        private readonly Dictionary<string, object> _updatedValues;
        private readonly List<Row> _updatedRows;
        public UpdateRowsOperation(Table table, ICondition condition, Dictionary<string, object> updatedValues)
        {
            _table = table;
            _condition = condition;
            _updatedValues = updatedValues;
            _updatedRows = new List<Row>();
        }
        protected override void Validate()
        {
            if (_table == null) throw new Exception("Table does not exist");
            if (_condition == null) throw new Exception("Condition is required");
            if (_updatedValues == null || _updatedValues.Count == 0)
            {
                throw new Exception("Update values are required");
            }
        }
        protected override List<Row> Execute()
        {
            foreach (Row row in _table.Rows)
            {
                if (_condition.Evaluate(row))
                {
                    foreach (var value in _updatedValues)
                    {
                        row.Values[value.Key] = value.Value;
                    }
                    _updatedRows.Add(row);
                }


            }
            return _updatedRows;
        }
    }
}