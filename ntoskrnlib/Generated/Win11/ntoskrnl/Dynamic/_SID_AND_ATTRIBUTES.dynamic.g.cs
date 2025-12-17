using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SID_AND_ATTRIBUTES")]
    public sealed class _SID_AND_ATTRIBUTES : DynamicStructure
    {
        public IntPtr Sid { get; }
        public uint Attributes { get; }

        public _SID_AND_ATTRIBUTES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SID_AND_ATTRIBUTES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SID_AND_ATTRIBUTES.Sid),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SID_AND_ATTRIBUTES.Attributes),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_SID_AND_ATTRIBUTES>((mem, ptr) => new _SID_AND_ATTRIBUTES(mem, ptr), offsets);
        }
    }
}