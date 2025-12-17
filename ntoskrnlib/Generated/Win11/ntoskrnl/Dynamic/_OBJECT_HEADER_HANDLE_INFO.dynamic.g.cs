using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OBJECT_HEADER_HANDLE_INFO")]
    public sealed class _OBJECT_HEADER_HANDLE_INFO : DynamicStructure
    {
        public IntPtr HandleCountDataBase { get; }
        public _OBJECT_HANDLE_COUNT_ENTRY SingleEntry { get; }

        public _OBJECT_HEADER_HANDLE_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OBJECT_HEADER_HANDLE_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OBJECT_HEADER_HANDLE_INFO.HandleCountDataBase),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER_HANDLE_INFO.SingleEntry),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_OBJECT_HEADER_HANDLE_INFO>((mem, ptr) => new _OBJECT_HEADER_HANDLE_INFO(mem, ptr), offsets);
        }
    }
}