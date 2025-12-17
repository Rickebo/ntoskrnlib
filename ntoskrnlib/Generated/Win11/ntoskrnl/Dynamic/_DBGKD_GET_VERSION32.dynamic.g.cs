using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_GET_VERSION32")]
    public sealed class _DBGKD_GET_VERSION32 : DynamicStructure
    {
        public ushort MajorVersion { get; }
        public ushort MinorVersion { get; }
        public ushort ProtocolVersion { get; }
        public ushort Flags { get; }
        public uint KernBase { get; }
        public uint PsLoadedModuleList { get; }
        public ushort MachineType { get; }
        public ushort ThCallbackStack { get; }
        public ushort NextCallback { get; }
        public ushort FramePointer { get; }
        public uint KiCallUserMode { get; }
        public uint KeUserCallbackDispatcher { get; }
        public uint BreakpointWithStatus { get; }
        public uint DebuggerDataList { get; }

        public _DBGKD_GET_VERSION32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_GET_VERSION32()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_GET_VERSION32.MajorVersion),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_GET_VERSION32.MinorVersion),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_DBGKD_GET_VERSION32.ProtocolVersion),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DBGKD_GET_VERSION32.Flags),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_DBGKD_GET_VERSION32.KernBase),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DBGKD_GET_VERSION32.PsLoadedModuleList),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_DBGKD_GET_VERSION32.MachineType),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DBGKD_GET_VERSION32.ThCallbackStack),
                    new ulong[]
                    {
                        18UL
                    }
                },
                {
                    nameof(_DBGKD_GET_VERSION32.NextCallback),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_DBGKD_GET_VERSION32.FramePointer),
                    new ulong[]
                    {
                        22UL
                    }
                },
                {
                    nameof(_DBGKD_GET_VERSION32.KiCallUserMode),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_DBGKD_GET_VERSION32.KeUserCallbackDispatcher),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_DBGKD_GET_VERSION32.BreakpointWithStatus),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_DBGKD_GET_VERSION32.DebuggerDataList),
                    new ulong[]
                    {
                        36UL
                    }
                }
            };
            Register<_DBGKD_GET_VERSION32>((mem, ptr) => new _DBGKD_GET_VERSION32(mem, ptr), offsets);
        }
    }
}