using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OBJECT_HEADER_EXTENDED_INFO")]
    public sealed class _OBJECT_HEADER_EXTENDED_INFO : DynamicStructure
    {
        public IntPtr Footer { get; }
        public ulong Reserved { get; }

        public _OBJECT_HEADER_EXTENDED_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OBJECT_HEADER_EXTENDED_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OBJECT_HEADER_EXTENDED_INFO.Footer),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER_EXTENDED_INFO.Reserved),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_OBJECT_HEADER_EXTENDED_INFO>((mem, ptr) => new _OBJECT_HEADER_EXTENDED_INFO(mem, ptr), offsets);
        }
    }
}