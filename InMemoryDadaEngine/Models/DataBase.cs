using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMemoryDadaEngine.Models
{
    public class DataBase
    {
        public string Name { get; }
        public Dictionary<string,Table> Tables { get; }

        public DataBase(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Database name cannot be empty.", nameof(name));
            }
            Name = name;
            Tables = new Dictionary<string, Table>();
        }

        public void RegisterTable(Table table)
        {
            if (table == null) throw new ArgumentNullException(nameof(table));

            if (Tables.ContainsKey(table.Name))
            {
                throw new InvalidOperationException($"Table '{table.Name}' already exists.");
            }
            Tables.Add(table.Name, table);
        }
        public void RemoveTable(string tableName)
        {
            if (string.IsNullOrWhiteSpace(tableName))
            {
                throw new ArgumentException("Table name cannot be empty.", nameof(tableName));
            }
            if (!Tables.ContainsKey(tableName))
            {
                throw new InvalidOperationException($"Table '{tableName}' does not exist.");
            }
            Tables.Remove(tableName);

        }

       public Table GetTable(string tableName)
        {
            if (string.IsNullOrWhiteSpace(tableName))
            {
                throw new ArgumentException("Table name cannot be empty.", nameof(tableName));
            }
            if (!Tables.ContainsKey(tableName))
            {
                throw new InvalidOperationException($"Table '{tableName}' does not exist.");
            }
            return Tables[tableName];
        }
    }
}
