using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDisposeExercice
{
    class DisposeExercice : IDisposable
    {
        public string Example { get; set; }

        public DisposeExercice(String ex)
        {
            this.Example = ex;
        }

        void IDisposable.Dispose()
        {
            // Method intentionally left empty.
        }

        public void DisposeFunction() => Console.WriteLine("Se ha llamado al metodo Dispose()");
    }
}
