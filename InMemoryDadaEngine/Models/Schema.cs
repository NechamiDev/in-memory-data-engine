using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMemoryDadaEngine.Models
{
    public class Schema
        {
            public List<Column> Columns { get; }

            public Schema(List<Column> columns)
            {
                if (columns == null)
                {
                    throw new ArgumentNullException(nameof(columns));
                }

                Columns = columns;
            }
        }
    }

