using System;

namespace ntoskrnlib.Structure
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true)]
    public class Length : Attribute
    {
        public int Value { get; }

        public Length(int length)
        {
            Value = length;
        }
    }
}
