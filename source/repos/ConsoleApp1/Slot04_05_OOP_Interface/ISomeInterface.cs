using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot04_05_OOP_Interface
{
    public interface ISomeInterface
    {
        string SomeProperty { get; set; }
        string SomeMethod();
        void SomethingElse();
    }
}
