using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_XSTATE_CONFIGURATION")]
    public sealed class _XSTATE_CONFIGURATION : DynamicStructure
    {
        public ulong EnabledFeatures { get; }
        public ulong EnabledVolatileFeatures { get; }
        public uint Size { get; }
        public uint ControlFlags { get; }
        public uint OptimizedSave { get; }
        public uint CompactionEnabled { get; }
        public uint ExtendedFeatureDisable { get; }
        public byte[] Features { get; }
        public ulong EnabledSupervisorFeatures { get; }
        public ulong AlignedFeatures { get; }
        public uint AllFeatureSize { get; }
        public uint[] AllFeatures { get; }
        public ulong EnabledUserVisibleSupervisorFeatures { get; }
        public ulong ExtendedFeatureDisableFeatures { get; }
        public uint AllNonLargeFeatureSize { get; }
        public ushort MaxSveVectorLength { get; }
        public ushort Spare1 { get; }

        public _XSTATE_CONFIGURATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _XSTATE_CONFIGURATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_XSTATE_CONFIGURATION.EnabledFeatures),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_XSTATE_CONFIGURATION.EnabledVolatileFeatures),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_XSTATE_CONFIGURATION.Size),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_XSTATE_CONFIGURATION.ControlFlags),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_XSTATE_CONFIGURATION.OptimizedSave),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_XSTATE_CONFIGURATION.CompactionEnabled),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_XSTATE_CONFIGURATION.ExtendedFeatureDisable),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_XSTATE_CONFIGURATION.Features),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_XSTATE_CONFIGURATION.EnabledSupervisorFeatures),
                    new ulong[]
                    {
                        536UL
                    }
                },
                {
                    nameof(_XSTATE_CONFIGURATION.AlignedFeatures),
                    new ulong[]
                    {
                        544UL
                    }
                },
                {
                    nameof(_XSTATE_CONFIGURATION.AllFeatureSize),
                    new ulong[]
                    {
                        552UL
                    }
                },
                {
                    nameof(_XSTATE_CONFIGURATION.AllFeatures),
                    new ulong[]
                    {
                        556UL
                    }
                },
                {
                    nameof(_XSTATE_CONFIGURATION.EnabledUserVisibleSupervisorFeatures),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_XSTATE_CONFIGURATION.ExtendedFeatureDisableFeatures),
                    new ulong[]
                    {
                        824UL
                    }
                },
                {
                    nameof(_XSTATE_CONFIGURATION.AllNonLargeFeatureSize),
                    new ulong[]
                    {
                        832UL
                    }
                },
                {
                    nameof(_XSTATE_CONFIGURATION.MaxSveVectorLength),
                    new ulong[]
                    {
                        836UL
                    }
                },
                {
                    nameof(_XSTATE_CONFIGURATION.Spare1),
                    new ulong[]
                    {
                        838UL
                    }
                }
            };
            Register<_XSTATE_CONFIGURATION>((mem, ptr) => new _XSTATE_CONFIGURATION(mem, ptr), offsets);
        }
    }
}