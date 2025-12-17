using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_PARTITION_ZEROING")]
    public sealed class _MI_PARTITION_ZEROING : DynamicStructure
    {
        public _WORK_QUEUE_ITEM RebalanceZeroFreeWorkItem { get; }
        public int BackgroundZeroingDisabled { get; }
        public int BootEnginesCalibrating { get; }
        public _KEVENT BootEnginesCalibrationWaiters { get; }
        public int ZeroFreePageSlistMinimum { get; }
        public uint BackgroundZeroingPreference { get; }

        public _MI_PARTITION_ZEROING(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_PARTITION_ZEROING()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_PARTITION_ZEROING.RebalanceZeroFreeWorkItem),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PARTITION_ZEROING.BackgroundZeroingDisabled),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_PARTITION_ZEROING.BootEnginesCalibrating),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_MI_PARTITION_ZEROING.BootEnginesCalibrationWaiters),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MI_PARTITION_ZEROING.ZeroFreePageSlistMinimum),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_MI_PARTITION_ZEROING.BackgroundZeroingPreference),
                    new ulong[]
                    {
                        68UL
                    }
                }
            };
            Register<_MI_PARTITION_ZEROING>((mem, ptr) => new _MI_PARTITION_ZEROING(mem, ptr), offsets);
        }
    }
}