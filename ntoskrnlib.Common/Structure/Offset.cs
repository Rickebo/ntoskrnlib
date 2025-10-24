using System;

namespace ntoskrnlib.Structure
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true)]
    public class Offset : Attribute
    {
        public ulong[] Offsets { get; }
        public string[] OffsetKeys { get; }

        public Offset(params ulong[] offsets)
        {
            Offsets = offsets;
        }

        public Offset(params string[] keys)
        {
            OffsetKeys = keys;
        }
    }
}
