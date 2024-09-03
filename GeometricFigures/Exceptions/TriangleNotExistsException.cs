using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFugures.Exceptions
{
    public class TriangleDoNotExistsException : ArgumentException
    {
        public TriangleDoNotExistsException() : base("Triangle with this parameters cannot exist") { }
    }
}
