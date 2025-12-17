using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_GET_VERSION64")]
    public sealed class _DBGKD_GET_VERSION64 : DynamicStructure
    {
        public ushort MajorVersion { get; }
        public ushort MinorVersion { get; }
        public byte ProtocolVersion { get; }
        public byte KdSecondaryVersion { get; }
        public ushort Flags { get; }
        public ushort MachineType { get; }
        public byte MaxPacketType { get; }
        public byte MaxStateChange { get; }
        public byte MaxManipulate { get; }
        public byte Simulation { get; }
        public ushort[] Unused { get; }
        public ulong KernBase { get; }
        public ulong PsLoadedModuleList { get; }
        public ulong DebuggerDataList { get; }

        public _DBGKD_GET_VERSION64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_GET_VERSION64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_GET_VERSION64.MajorVersion),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_GET_VERSION64.MinorVersion),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_DBGKD_GET_VERSION64.ProtocolVersion),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DBGKD_GET_VERSION64.KdSecondaryVersion),
                    new ulong[]
                    {
                        5UL
                    }
                },
                {
                    nameof(_DBGKD_GET_VERSION64.Flags),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_DBGKD_GET_VERSION64.MachineType),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DBGKD_GET_VERSION64.MaxPacketType),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_DBGKD_GET_VERSION64.MaxStateChange),
                    new ulong[]
                    {
                        11UL
                    }
                },
                {
                    nameof(_DBGKD_GET_VERSION64.MaxManipulate),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_DBGKD_GET_VERSION64.Simulation),
                    new ulong[]
                    {
                        13UL
                    }
                },
                {
                    nameof(_DBGKD_GET_VERSION64.Unused),
                    new ulong[]
                    {
                        14UL
                    }
                },
                {
                    nameof(_DBGKD_GET_VERSION64.KernBase),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DBGKD_GET_VERSION64.PsLoadedModuleList),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_DBGKD_GET_VERSION64.DebuggerDataList),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_DBGKD_GET_VERSION64>((mem, ptr) => new _DBGKD_GET_VERSION64(mem, ptr), offsets);
        }
    }
}