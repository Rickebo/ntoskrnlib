using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_MMSUPPORT_INSTANCE")]
    public sealed class _MMSUPPORT_INSTANCE : DynamicStructure
    {
        public uint NextPageColor { get; }
        public uint PageFaultCount { get; }
        public ulong TrimmedPageCount { get; }
        public IntPtr VmWorkingSetList { get; }
        public _LIST_ENTRY WorkingSetExpansionLinks { get; }
        public ulong[] AgeDistribution { get; }
        public IntPtr ExitOutswapGate { get; }
        public ulong MinimumWorkingSetSize { get; }
        public ulong MaximumWorkingSetSize { get; }
        public ulong WorkingSetLeafSize { get; }
        public ulong WorkingSetLeafPrivateSize { get; }
        public ulong WorkingSetSize { get; }
        public ulong WorkingSetPrivateSize { get; }
        public ulong PeakWorkingSetSize { get; }
        public uint HardFaultCount { get; }
        public ushort LastTrimStamp { get; }
        public ushort PartitionId { get; }
        public ulong SelfmapLock { get; }
        public _MMSUPPORT_FLAGS Flags { get; }
        public uint InterlockedFlags { get; }

        public _MMSUPPORT_INSTANCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMSUPPORT_INSTANCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMSUPPORT_INSTANCE.NextPageColor),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSUPPORT_INSTANCE.PageFaultCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_MMSUPPORT_INSTANCE.TrimmedPageCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MMSUPPORT_INSTANCE.VmWorkingSetList),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MMSUPPORT_INSTANCE.WorkingSetExpansionLinks),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MMSUPPORT_INSTANCE.AgeDistribution),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MMSUPPORT_INSTANCE.ExitOutswapGate),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_MMSUPPORT_INSTANCE.MinimumWorkingSetSize),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_MMSUPPORT_INSTANCE.MaximumWorkingSetSize),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_MMSUPPORT_INSTANCE.WorkingSetLeafSize),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_MMSUPPORT_INSTANCE.WorkingSetLeafPrivateSize),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_MMSUPPORT_INSTANCE.WorkingSetSize),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_MMSUPPORT_INSTANCE.WorkingSetPrivateSize),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_MMSUPPORT_INSTANCE.PeakWorkingSetSize),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_MMSUPPORT_INSTANCE.HardFaultCount),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_MMSUPPORT_INSTANCE.LastTrimStamp),
                    new ulong[]
                    {
                        172UL
                    }
                },
                {
                    nameof(_MMSUPPORT_INSTANCE.PartitionId),
                    new ulong[]
                    {
                        174UL
                    }
                },
                {
                    nameof(_MMSUPPORT_INSTANCE.SelfmapLock),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_MMSUPPORT_INSTANCE.Flags),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_MMSUPPORT_INSTANCE.InterlockedFlags),
                    new ulong[]
                    {
                        188UL
                    }
                }
            };
            Register<_MMSUPPORT_INSTANCE>((mem, ptr) => new _MMSUPPORT_INSTANCE(mem, ptr), offsets);
        }
    }
}