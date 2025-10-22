using System;

namespace ntoskrnlib.Structure
{
    public class StructureInitializationException 
        : Exception
    {
        public StructureInitializationException(string msg) : base(msg) {}
    }
}
