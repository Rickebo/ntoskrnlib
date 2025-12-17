using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OBJECT_HEADER_PADDING_INFO")]
    public sealed class _OBJECT_HEADER_PADDING_INFO : DynamicStructure
    {
        public uint PaddingAmount { get; }

        public _OBJECT_HEADER_PADDING_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OBJECT_HEADER_PADDING_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OBJECT_HEADER_PADDING_INFO.PaddingAmount),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_OBJECT_HEADER_PADDING_INFO>((mem, ptr) => new _OBJECT_HEADER_PADDING_INFO(mem, ptr), offsets);
        }
    }
}