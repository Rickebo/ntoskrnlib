using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_LOADER_PERFORMANCE_DATA")]
    public sealed class _LOADER_PERFORMANCE_DATA : DynamicStructure
    {
        public ulong StartTime { get; }
        public ulong EndTime { get; }
        public ulong PreloadEndTime { get; }
        public ulong TcbLoaderStartTime { get; }
        public ulong LoadHypervisorTime { get; }
        public ulong LaunchHypervisorTime { get; }
        public ulong LoadVsmTime { get; }
        public ulong LaunchVsmTime { get; }
        public ulong ExecuteTransitionStartTime { get; }
        public ulong ExecuteTransitionEndTime { get; }
        public ulong LoadDriversTime { get; }
        public ulong CleanupVsmTime { get; }

        public _LOADER_PERFORMANCE_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LOADER_PERFORMANCE_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LOADER_PERFORMANCE_DATA.StartTime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LOADER_PERFORMANCE_DATA.EndTime),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_LOADER_PERFORMANCE_DATA.PreloadEndTime),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_LOADER_PERFORMANCE_DATA.TcbLoaderStartTime),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_LOADER_PERFORMANCE_DATA.LoadHypervisorTime),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_LOADER_PERFORMANCE_DATA.LaunchHypervisorTime),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_LOADER_PERFORMANCE_DATA.LoadVsmTime),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_LOADER_PERFORMANCE_DATA.LaunchVsmTime),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_LOADER_PERFORMANCE_DATA.ExecuteTransitionStartTime),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_LOADER_PERFORMANCE_DATA.ExecuteTransitionEndTime),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_LOADER_PERFORMANCE_DATA.LoadDriversTime),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_LOADER_PERFORMANCE_DATA.CleanupVsmTime),
                    new ulong[]
                    {
                        88UL
                    }
                }
            };
            Register<_LOADER_PERFORMANCE_DATA>((mem, ptr) => new _LOADER_PERFORMANCE_DATA(mem, ptr), offsets);
        }
    }
}