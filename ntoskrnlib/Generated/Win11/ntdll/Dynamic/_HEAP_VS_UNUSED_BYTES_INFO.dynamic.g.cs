using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_VS_UNUSED_BYTES_INFO")]
    public sealed class _HEAP_VS_UNUSED_BYTES_INFO : DynamicStructure
    {
        public ushort UnusedBytes { get; }
        public ushort LfhSubsegment { get; }
        public ushort ExtraPresent { get; }
        public ushort OneByteUnused { get; }
        public byte[] Bytes { get; }

        public _HEAP_VS_UNUSED_BYTES_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_VS_UNUSED_BYTES_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_VS_UNUSED_BYTES_INFO.UnusedBytes),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_VS_UNUSED_BYTES_INFO.LfhSubsegment),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_VS_UNUSED_BYTES_INFO.ExtraPresent),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_VS_UNUSED_BYTES_INFO.OneByteUnused),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_VS_UNUSED_BYTES_INFO.Bytes),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_HEAP_VS_UNUSED_BYTES_INFO>((mem, ptr) => new _HEAP_VS_UNUSED_BYTES_INFO(mem, ptr), offsets);
        }
    }
}