using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_SYSTEM_ACCELERATORS")]
    public sealed class _MI_SYSTEM_ACCELERATORS : DynamicStructure
    {
        public _LIST_ENTRY HardwareInstances { get; }
        public uint NumberOfHardwareInstances { get; }
        public byte ShuttingDown { get; }
        public byte AllocationFailures { get; }
        public byte AllocationQueryFailures { get; }
        public byte AllocationQueryBadNodes { get; }
        public _SINGLE_LIST_ENTRY DeferredPoolFrees { get; }
        public IntPtr OpaqueContext { get; }
        public int Lock { get; }

        public _MI_SYSTEM_ACCELERATORS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_SYSTEM_ACCELERATORS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_SYSTEM_ACCELERATORS.HardwareInstances),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_ACCELERATORS.NumberOfHardwareInstances),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_ACCELERATORS.ShuttingDown),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_ACCELERATORS.AllocationFailures),
                    new ulong[]
                    {
                        21UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_ACCELERATORS.AllocationQueryFailures),
                    new ulong[]
                    {
                        22UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_ACCELERATORS.AllocationQueryBadNodes),
                    new ulong[]
                    {
                        23UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_ACCELERATORS.DeferredPoolFrees),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_ACCELERATORS.OpaqueContext),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_ACCELERATORS.Lock),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_MI_SYSTEM_ACCELERATORS>((mem, ptr) => new _MI_SYSTEM_ACCELERATORS(mem, ptr), offsets);
        }
    }
}