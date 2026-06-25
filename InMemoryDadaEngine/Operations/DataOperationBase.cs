using InMemoryDadaEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMemoryDadaEngine.Operations
{
    public abstract class DataOperationBase
    {
        public List<Row> Run()
        { 
            Validate();
            
            var resulte = Execute();

            return resulte;
        }
        protected abstract void Validate();

        protected abstract List<Row> Execute();
    }
}
