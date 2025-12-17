using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMSUPPORT_AGGREGATION")]
    public sealed class _MMSUPPORT_AGGREGATION : DynamicStructure
    {
        public uint PageFaultCount { get; }
        public ulong WorkingSetSize { get; }
        public ulong WorkingSetLeafSize { get; }
        public ulong PeakWorkingSetSize { get; }

        public _MMSUPPORT_AGGREGATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMSUPPORT_AGGREGATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMSUPPORT_AGGREGATION.PageFaultCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSUPPORT_AGGREGATION.WorkingSetSize),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MMSUPPORT_AGGREGATION.WorkingSetLeafSize),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MMSUPPORT_AGGREGATION.PeakWorkingSetSize),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_MMSUPPORT_AGGREGATION>((mem, ptr) => new _MMSUPPORT_AGGREGATION(mem, ptr), offsets);
        }
    }
}