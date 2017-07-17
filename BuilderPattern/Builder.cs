using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    internal abstract class Builder
    {
        internal abstract void BuildPartA();
        internal abstract void BuildPartB();

        internal abstract Product GetResult();
    }
}
