using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_exemplos
{
    public class Class1
    {
        // os metodos Equals, ToString e GetHashCode estão na classe pronta do C# chamada object
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
