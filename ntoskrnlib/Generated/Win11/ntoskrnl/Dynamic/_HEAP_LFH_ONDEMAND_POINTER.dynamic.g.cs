using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEAP_LFH_ONDEMAND_POINTER")]
    public sealed class _HEAP_LFH_ONDEMAND_POINTER : DynamicStructure
    {
        public ushort Invalid { get; }
        public ushort AllocationInProgress { get; }
        public ushort Spare0 { get; }
        public ushort UsageData { get; }
        public IntPtr AllBits { get; }

        public _HEAP_LFH_ONDEMAND_POINTER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_LFH_ONDEMAND_POINTER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_LFH_ONDEMAND_POINTER.Invalid),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LFH_ONDEMAND_POINTER.AllocationInProgress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LFH_ONDEMAND_POINTER.Spare0),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LFH_ONDEMAND_POINTER.UsageData),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_HEAP_LFH_ONDEMAND_POINTER.AllBits),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_HEAP_LFH_ONDEMAND_POINTER>((mem, ptr) => new _HEAP_LFH_ONDEMAND_POINTER(mem, ptr), offsets);
        }
    }
}