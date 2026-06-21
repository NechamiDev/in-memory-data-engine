using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMemoryDadaEngine.Models
{
    public class Column
    {
        public string Name { get;  }
        public DataType DataType { get; }
        public Column(string name, DataType dataType)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Column name cannot be empty.", nameof(name));
            }

            Name = name;
            DataType = dataType;
        }
    }
}
