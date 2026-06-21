using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMemoryDadaEngine.Models
{
    public class Row
    {
        public Dictionary<string, object> Values { get; }

        public Row(Dictionary<string, object> values)
        {
            Values=values;
        }
    }
}

