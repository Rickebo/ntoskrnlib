using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_BUS_EXTENSION_LIST")]
    public sealed class _BUS_EXTENSION_LIST : DynamicStructure
    {
        public IntPtr Next { get; }
        public IntPtr BusExtension { get; }

        public _BUS_EXTENSION_LIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _BUS_EXTENSION_LIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_BUS_EXTENSION_LIST.Next),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_BUS_EXTENSION_LIST.BusExtension),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_BUS_EXTENSION_LIST>((mem, ptr) => new _BUS_EXTENSION_LIST(mem, ptr), offsets);
        }
    }
}