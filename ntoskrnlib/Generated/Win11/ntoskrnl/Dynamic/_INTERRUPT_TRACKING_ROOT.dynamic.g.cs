using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_INTERRUPT_TRACKING_ROOT")]
    public sealed class _INTERRUPT_TRACKING_ROOT : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public _LIST_ENTRY TrackingEntryList { get; }
        public uint Gsiv { get; }
        public _INTERRUPT_VECTOR_DATA VectorData { get; }
        public uint SteeringMode { get; }
        public byte EnableSteering { get; }
        public _GROUP_AFFINITY CpuSetMask { get; }
        public ulong AffinityEpoch { get; }
        public _GROUP_AFFINITY CurrentTarget { get; }
        public _GROUP_AFFINITY NextTarget { get; }
        public ulong TimeDelta { get; }
        public IntPtr RedirectHandle { get; }
        public _LIST_ENTRY SteerQueueLink { get; }

        public _INTERRUPT_TRACKING_ROOT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _INTERRUPT_TRACKING_ROOT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_INTERRUPT_TRACKING_ROOT.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_INTERRUPT_TRACKING_ROOT.TrackingEntryList),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_INTERRUPT_TRACKING_ROOT.Gsiv),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_INTERRUPT_TRACKING_ROOT.VectorData),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_INTERRUPT_TRACKING_ROOT.SteeringMode),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_INTERRUPT_TRACKING_ROOT.EnableSteering),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_INTERRUPT_TRACKING_ROOT.CpuSetMask),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_INTERRUPT_TRACKING_ROOT.AffinityEpoch),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_INTERRUPT_TRACKING_ROOT.CurrentTarget),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_INTERRUPT_TRACKING_ROOT.NextTarget),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_INTERRUPT_TRACKING_ROOT.TimeDelta),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_INTERRUPT_TRACKING_ROOT.RedirectHandle),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_INTERRUPT_TRACKING_ROOT.SteerQueueLink),
                    new ulong[]
                    {
                        208UL
                    }
                }
            };
            Register<_INTERRUPT_TRACKING_ROOT>((mem, ptr) => new _INTERRUPT_TRACKING_ROOT(mem, ptr), offsets);
        }
    }
}