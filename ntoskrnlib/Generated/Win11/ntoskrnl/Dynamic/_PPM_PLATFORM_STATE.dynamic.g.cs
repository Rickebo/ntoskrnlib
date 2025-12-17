using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PPM_PLATFORM_STATE")]
    public sealed class _PPM_PLATFORM_STATE : DynamicStructure
    {
        public ulong LevelId { get; }
        public uint Latency { get; }
        public uint BreakEvenDuration { get; }
        public _PPM_VETO_ACCOUNTING VetoAccounting { get; }
        public byte TransitionDebugger { get; }
        public byte Platform { get; }
        public byte Enabled { get; }
        public byte CoordinatedDependencies { get; }
        public uint DependencyListCount { get; }
        public _KAFFINITY_EX Processors { get; }
        public _UNICODE_STRING Name { get; }
        public IntPtr DependencyLists { get; }
        public _PPM_COORDINATED_SYNCHRONIZATION Synchronization { get; }
        public ulong EnterTime { get; }
        public int RefCount { get; }
        public byte[] CacheAlign0 { get; }

        public _PPM_PLATFORM_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PPM_PLATFORM_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PPM_PLATFORM_STATE.LevelId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_PLATFORM_STATE.Latency),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PPM_PLATFORM_STATE.BreakEvenDuration),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_PPM_PLATFORM_STATE.VetoAccounting),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PPM_PLATFORM_STATE.TransitionDebugger),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PPM_PLATFORM_STATE.Platform),
                    new ulong[]
                    {
                        57UL
                    }
                },
                {
                    nameof(_PPM_PLATFORM_STATE.Enabled),
                    new ulong[]
                    {
                        58UL
                    }
                },
                {
                    nameof(_PPM_PLATFORM_STATE.CoordinatedDependencies),
                    new ulong[]
                    {
                        59UL
                    }
                },
                {
                    nameof(_PPM_PLATFORM_STATE.DependencyListCount),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_PPM_PLATFORM_STATE.Processors),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PPM_PLATFORM_STATE.Name),
                    new ulong[]
                    {
                        328UL
                    }
                },
                {
                    nameof(_PPM_PLATFORM_STATE.DependencyLists),
                    new ulong[]
                    {
                        344UL
                    }
                },
                {
                    nameof(_PPM_PLATFORM_STATE.Synchronization),
                    new ulong[]
                    {
                        352UL
                    }
                },
                {
                    nameof(_PPM_PLATFORM_STATE.EnterTime),
                    new ulong[]
                    {
                        360UL
                    }
                },
                {
                    nameof(_PPM_PLATFORM_STATE.RefCount),
                    new ulong[]
                    {
                        384UL
                    }
                },
                {
                    nameof(_PPM_PLATFORM_STATE.CacheAlign0),
                    new ulong[]
                    {
                        384UL
                    }
                }
            };
            Register<_PPM_PLATFORM_STATE>((mem, ptr) => new _PPM_PLATFORM_STATE(mem, ptr), offsets);
        }
    }
}