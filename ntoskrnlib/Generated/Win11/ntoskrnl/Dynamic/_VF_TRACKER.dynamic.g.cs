using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VF_TRACKER")]
    public sealed class _VF_TRACKER : DynamicStructure
    {
        public uint TrackerFlags { get; }
        public uint TrackerSize { get; }
        public uint TrackerIndex { get; }
        public uint TraceDepth { get; }

        public _VF_TRACKER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VF_TRACKER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VF_TRACKER.TrackerFlags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VF_TRACKER.TrackerSize),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_VF_TRACKER.TrackerIndex),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_VF_TRACKER.TraceDepth),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_VF_TRACKER>((mem, ptr) => new _VF_TRACKER(mem, ptr), offsets);
        }
    }
}