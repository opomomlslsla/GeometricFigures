using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFugures.Exceptions
{
    public class InvalidParameterException: ArgumentException
    {
        public InvalidParameterException(string? parameter) : base("Parameters must be greater than 0, invalid parameter.", parameter) { }
    }
}
