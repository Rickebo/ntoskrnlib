using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PPM_PLATFORM_STATES")]
    public sealed class _PPM_PLATFORM_STATES : DynamicStructure
    {
        public uint StateCount { get; }
        public uint ProcessorCount { get; }
        public byte CoordinatedInterface { get; }
        public IntPtr IdleTest { get; }
        public IntPtr IdlePreExecute { get; }
        public IntPtr IdleComplete { get; }
        public IntPtr QueryPlatformStateResidency { get; }
        public IntPtr Accounting { get; }
        public uint DeepSleepState { get; }
        public byte[] State { get; }

        public _PPM_PLATFORM_STATES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PPM_PLATFORM_STATES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PPM_PLATFORM_STATES.StateCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_PLATFORM_STATES.ProcessorCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PPM_PLATFORM_STATES.CoordinatedInterface),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PPM_PLATFORM_STATES.IdleTest),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PPM_PLATFORM_STATES.IdlePreExecute),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PPM_PLATFORM_STATES.IdleComplete),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PPM_PLATFORM_STATES.QueryPlatformStateResidency),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PPM_PLATFORM_STATES.Accounting),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PPM_PLATFORM_STATES.DeepSleepState),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PPM_PLATFORM_STATES.State),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_PPM_PLATFORM_STATES>((mem, ptr) => new _PPM_PLATFORM_STATES(mem, ptr), offsets);
        }
    }
}