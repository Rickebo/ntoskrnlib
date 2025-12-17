using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HAL_CHANNEL_MEMORY_RANGES")]
    public sealed class _HAL_CHANNEL_MEMORY_RANGES : DynamicStructure
    {
        public ulong PageFrameIndex { get; }
        public ushort MpnId { get; }
        public ushort Node { get; }
        public ushort Channel { get; }
        public byte IsPowerManageable { get; }
        public byte DeepPowerState { get; }

        public _HAL_CHANNEL_MEMORY_RANGES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HAL_CHANNEL_MEMORY_RANGES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HAL_CHANNEL_MEMORY_RANGES.PageFrameIndex),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HAL_CHANNEL_MEMORY_RANGES.MpnId),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HAL_CHANNEL_MEMORY_RANGES.Node),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_HAL_CHANNEL_MEMORY_RANGES.Channel),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HAL_CHANNEL_MEMORY_RANGES.IsPowerManageable),
                    new ulong[]
                    {
                        14UL
                    }
                },
                {
                    nameof(_HAL_CHANNEL_MEMORY_RANGES.DeepPowerState),
                    new ulong[]
                    {
                        15UL
                    }
                }
            };
            Register<_HAL_CHANNEL_MEMORY_RANGES>((mem, ptr) => new _HAL_CHANNEL_MEMORY_RANGES(mem, ptr), offsets);
        }
    }
}