using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PO_DIRECTED_DRIPS_STATE")]
    public sealed class _PO_DIRECTED_DRIPS_STATE : DynamicStructure
    {
        public _LIST_ENTRY QueueLink { get; }
        public _LIST_ENTRY VisitedQueueLink { get; }
        public uint Flags { get; }
        public uint CachedFlags { get; }
        public uint DeviceUsageCount { get; }
        public IntPtr Diagnostic { get; }

        public _PO_DIRECTED_DRIPS_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PO_DIRECTED_DRIPS_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PO_DIRECTED_DRIPS_STATE.QueueLink),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PO_DIRECTED_DRIPS_STATE.VisitedQueueLink),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PO_DIRECTED_DRIPS_STATE.Flags),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PO_DIRECTED_DRIPS_STATE.CachedFlags),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_PO_DIRECTED_DRIPS_STATE.DeviceUsageCount),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PO_DIRECTED_DRIPS_STATE.Diagnostic),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_PO_DIRECTED_DRIPS_STATE>((mem, ptr) => new _PO_DIRECTED_DRIPS_STATE(mem, ptr), offsets);
        }
    }
}