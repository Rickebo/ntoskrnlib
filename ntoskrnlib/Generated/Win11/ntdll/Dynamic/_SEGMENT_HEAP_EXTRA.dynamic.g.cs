using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_SEGMENT_HEAP_EXTRA")]
    public sealed class _SEGMENT_HEAP_EXTRA : DynamicStructure
    {
        public ushort AllocationTag { get; }
        public byte InterceptorIndex { get; }
        public byte UserFlags { get; }
        public byte ExtraSizeInUnits { get; }
        public IntPtr Settable { get; }

        public _SEGMENT_HEAP_EXTRA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SEGMENT_HEAP_EXTRA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SEGMENT_HEAP_EXTRA.AllocationTag),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP_EXTRA.InterceptorIndex),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP_EXTRA.UserFlags),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP_EXTRA.ExtraSizeInUnits),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP_EXTRA.Settable),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_SEGMENT_HEAP_EXTRA>((mem, ptr) => new _SEGMENT_HEAP_EXTRA(mem, ptr), offsets);
        }
    }
}