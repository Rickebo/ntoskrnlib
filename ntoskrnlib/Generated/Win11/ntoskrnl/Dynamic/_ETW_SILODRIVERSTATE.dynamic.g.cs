using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_SILODRIVERSTATE")]
    public sealed class _ETW_SILODRIVERSTATE : DynamicStructure
    {
        public IntPtr Silo { get; }
        public IntPtr SiloGlobals { get; }
        public uint MaxLoggers { get; }
        public _ETW_GUID_ENTRY EtwpSecurityProviderGuidEntry { get; }
        public IntPtr EtwpLoggerRundown { get; }
        public IntPtr EtwpLoggerContext { get; }
        public byte[] EtwpGuidHashTable { get; }
        public ushort[] EtwpSecurityLoggers { get; }
        public byte EtwpSecurityProviderEnableMask { get; }
        public int EtwpShutdownInProgress { get; }
        public uint EtwpSecurityProviderPID { get; }
        public _ETW_PRIV_HANDLE_DEMUX_TABLE PrivHandleDemuxTable { get; }
        public IntPtr RTBacklogFileRoot { get; }
        public _ETW_COUNTERS EtwpCounters { get; }
        public _LARGE_INTEGER LogfileBytesWritten { get; }
        public IntPtr ProcessorBlocks { get; }
        public IntPtr ContainerStateWnfSubscription { get; }
        public uint ContainerStateWnfCallbackCalled { get; }
        public IntPtr UnsubscribeWorkItem { get; }
        public _GUID PartitionId { get; }
        public _GUID ParentId { get; }
        public _LARGE_INTEGER QpcOffsetFromRoot { get; }
        public IntPtr PartitionName { get; }
        public ushort PartitionNameSize { get; }
        public ushort UnusedPadding { get; }
        public uint PartitionType { get; }
        public _ETW_SYSTEM_LOGGER_SETTINGS SystemLoggerSettings { get; }
        public _KMUTANT EtwpStartTraceMutex { get; }

        public _ETW_SILODRIVERSTATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_SILODRIVERSTATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_SILODRIVERSTATE.Silo),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_SILODRIVERSTATE.SiloGlobals),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ETW_SILODRIVERSTATE.MaxLoggers),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ETW_SILODRIVERSTATE.EtwpSecurityProviderGuidEntry),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_ETW_SILODRIVERSTATE.EtwpLoggerRundown),
                    new ulong[]
                    {
                        448UL
                    }
                },
                {
                    nameof(_ETW_SILODRIVERSTATE.EtwpLoggerContext),
                    new ulong[]
                    {
                        456UL
                    }
                },
                {
                    nameof(_ETW_SILODRIVERSTATE.EtwpGuidHashTable),
                    new ulong[]
                    {
                        464UL
                    }
                },
                {
                    nameof(_ETW_SILODRIVERSTATE.EtwpSecurityLoggers),
                    new ulong[]
                    {
                        4048UL
                    }
                },
                {
                    nameof(_ETW_SILODRIVERSTATE.EtwpSecurityProviderEnableMask),
                    new ulong[]
                    {
                        4064UL
                    }
                },
                {
                    nameof(_ETW_SILODRIVERSTATE.EtwpShutdownInProgress),
                    new ulong[]
                    {
                        4068UL
                    }
                },
                {
                    nameof(_ETW_SILODRIVERSTATE.EtwpSecurityProviderPID),
                    new ulong[]
                    {
                        4072UL
                    }
                },
                {
                    nameof(_ETW_SILODRIVERSTATE.PrivHandleDemuxTable),
                    new ulong[]
                    {
                        4080UL
                    }
                },
                {
                    nameof(_ETW_SILODRIVERSTATE.RTBacklogFileRoot),
                    new ulong[]
                    {
                        4112UL
                    }
                },
                {
                    nameof(_ETW_SILODRIVERSTATE.EtwpCounters),
                    new ulong[]
                    {
                        4120UL
                    }
                },
                {
                    nameof(_ETW_SILODRIVERSTATE.LogfileBytesWritten),
                    new ulong[]
                    {
                        4136UL
                    }
                },
                {
                    nameof(_ETW_SILODRIVERSTATE.ProcessorBlocks),
                    new ulong[]
                    {
                        4144UL
                    }
                },
                {
                    nameof(_ETW_SILODRIVERSTATE.ContainerStateWnfSubscription),
                    new ulong[]
                    {
                        4152UL
                    }
                },
                {
                    nameof(_ETW_SILODRIVERSTATE.ContainerStateWnfCallbackCalled),
                    new ulong[]
                    {
                        4160UL
                    }
                },
                {
                    nameof(_ETW_SILODRIVERSTATE.UnsubscribeWorkItem),
                    new ulong[]
                    {
                        4168UL
                    }
                },
                {
                    nameof(_ETW_SILODRIVERSTATE.PartitionId),
                    new ulong[]
                    {
                        4176UL
                    }
                },
                {
                    nameof(_ETW_SILODRIVERSTATE.ParentId),
                    new ulong[]
                    {
                        4192UL
                    }
                },
                {
                    nameof(_ETW_SILODRIVERSTATE.QpcOffsetFromRoot),
                    new ulong[]
                    {
                        4208UL
                    }
                },
                {
                    nameof(_ETW_SILODRIVERSTATE.PartitionName),
                    new ulong[]
                    {
                        4216UL
                    }
                },
                {
                    nameof(_ETW_SILODRIVERSTATE.PartitionNameSize),
                    new ulong[]
                    {
                        4224UL
                    }
                },
                {
                    nameof(_ETW_SILODRIVERSTATE.UnusedPadding),
                    new ulong[]
                    {
                        4226UL
                    }
                },
                {
                    nameof(_ETW_SILODRIVERSTATE.PartitionType),
                    new ulong[]
                    {
                        4228UL
                    }
                },
                {
                    nameof(_ETW_SILODRIVERSTATE.SystemLoggerSettings),
                    new ulong[]
                    {
                        4232UL
                    }
                },
                {
                    nameof(_ETW_SILODRIVERSTATE.EtwpStartTraceMutex),
                    new ulong[]
                    {
                        4608UL
                    }
                }
            };
            Register<_ETW_SILODRIVERSTATE>((mem, ptr) => new _ETW_SILODRIVERSTATE(mem, ptr), offsets);
        }
    }
}