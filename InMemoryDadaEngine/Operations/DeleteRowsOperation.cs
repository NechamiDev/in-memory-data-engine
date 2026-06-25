using InMemoryDadaEngine.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InMemoryDataEngine.Conditions;//צריך לבר ר עם נחמי את השמות
namespace InMemoryDadaEngine.Operations
{
    public class DeleteOperation : DataOperationBase
    {
        private readonly Table _table;
        private readonly ICondition _condition; //צריך לבר ר עם נחמי את השמות
        private List<Row> _deletedRows;
        public DeleteOperation(Table table, ICondition condition )
        {
            _table = table;
            _condition = condition;
            _deletedRows = new List<Row>();
        
        }

        protected override void Validate()
        {
            if (_table == null) {
                throw new Exception("Table does not exist");
               }
            if (_condition == null)
            {
                throw new Exception("Condition is required");
            }
        }  
        protected override List<Row> Execute()
            {
            foreach (Row row in _table.Rows.ToList()){
                if (_condition.Evaluate(row))//צריך לבר ר עם נחמי את השמות קובץ קונדישין פונקצית בדיקה
                {
                    _deletedRows.Add(row);
                    _table.Rows.Remove(row);
                }
                return _deletedRows;
            }

            }

    }

