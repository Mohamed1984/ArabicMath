using System;
using System.Collections.Generic;
using System.Text;

namespace ParserUtilities
{
    public interface Visitor<T>
    {
        void Visit(T obj);
        bool HasDone();
    }
}