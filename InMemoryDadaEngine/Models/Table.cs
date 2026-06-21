using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMemoryDadaEngine.Models
{
    public class Table
    {
        public string Name { get;  }
        public Schema Schema { get;  }
        public List<Row> Rows { get;  }

        public Table(string name,Schema schema,List<Row> rows)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Table name cannot be empty.", nameof(name));
            }

            if (schema==null) throw new ArgumentNullException(nameof(schema));
            
            this.Name = name;
            this.Schema = schema;
            this.Rows=new List<Row>();
        }
    }
}
