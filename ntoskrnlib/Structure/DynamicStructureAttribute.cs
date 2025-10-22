using System;

namespace ntoskrnlib.Structure
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true)]
    public class DynamicStructureAttribute : Attribute
    {
        public string BackingSymbolName { get; }

        public DynamicStructureAttribute(string backingSymbolName)
        {
            BackingSymbolName = backingSymbolName;
        }
    }
}