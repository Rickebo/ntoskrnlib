using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_INTERRUPT_CONNECTION_DATA")]
    public sealed class _INTERRUPT_CONNECTION_DATA : DynamicStructure
    {
        public uint Count { get; }
        public byte[] Vectors { get; }

        public _INTERRUPT_CONNECTION_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _INTERRUPT_CONNECTION_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_INTERRUPT_CONNECTION_DATA.Count),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_INTERRUPT_CONNECTION_DATA.Vectors),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_INTERRUPT_CONNECTION_DATA>((mem, ptr) => new _INTERRUPT_CONNECTION_DATA(mem, ptr), offsets);
        }
    }
}