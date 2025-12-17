using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_LOCAL_DATA")]
    public sealed class _HEAP_LOCAL_DATA : DynamicStructure
    {
        public _SLIST_HEADER DeletedSubSegments { get; }
        public IntPtr CrtZone { get; }
        public IntPtr LowFragHeap { get; }
        public uint Sequence { get; }
        public uint DeleteRateThreshold { get; }

        public _HEAP_LOCAL_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_LOCAL_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_LOCAL_DATA.DeletedSubSegments),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LOCAL_DATA.CrtZone),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HEAP_LOCAL_DATA.LowFragHeap),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HEAP_LOCAL_DATA.Sequence),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HEAP_LOCAL_DATA.DeleteRateThreshold),
                    new ulong[]
                    {
                        36UL
                    }
                }
            };
            Register<_HEAP_LOCAL_DATA>((mem, ptr) => new _HEAP_LOCAL_DATA(mem, ptr), offsets);
        }
    }
}