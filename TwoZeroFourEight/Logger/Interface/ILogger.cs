using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoZeroFourEight.Logger.Interface
{
    public interface ILogger
    {
        void WriteLine(string message);
        void Write(string message);
        void Clear();

	}
}
