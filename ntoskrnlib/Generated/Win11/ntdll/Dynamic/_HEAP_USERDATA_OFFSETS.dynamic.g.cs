using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_USERDATA_OFFSETS")]
    public sealed class _HEAP_USERDATA_OFFSETS : DynamicStructure
    {
        public ushort FirstAllocationOffset { get; }
        public ushort BlockStride { get; }
        public uint StrideAndOffset { get; }

        public _HEAP_USERDATA_OFFSETS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_USERDATA_OFFSETS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_USERDATA_OFFSETS.FirstAllocationOffset),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_USERDATA_OFFSETS.BlockStride),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_HEAP_USERDATA_OFFSETS.StrideAndOffset),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_HEAP_USERDATA_OFFSETS>((mem, ptr) => new _HEAP_USERDATA_OFFSETS(mem, ptr), offsets);
        }
    }
}