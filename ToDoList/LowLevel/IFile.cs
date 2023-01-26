using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevel
{
    public interface IFile
    {
        void Save<T>(T obj);
        T Load<T>();
    }
}
