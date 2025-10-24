using System;

namespace ntoskrnlib.Structure
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
    public class DynamicStructureAttribute : Attribute
    {
        public string BackingSymbolName { get; }

        public DynamicStructureAttribute(string backingSymbolName)
        {
            BackingSymbolName = backingSymbolName;
        }
    }
}
