#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4664)]
    public partial struct _ETW_SILODRIVERSTATE
    {
        [FieldOffset(0)]
        public IntPtr Silo;
        [FieldOffset(8)]
        public IntPtr SiloGlobals;
        [FieldOffset(16)]
        public uint MaxLoggers;
        [FieldOffset(24)]
        public _ETW_GUID_ENTRY EtwpSecurityProviderGuidEntry;
        [FieldOffset(448)]
        public IntPtr EtwpLoggerRundown;
        [FieldOffset(456)]
        public IntPtr EtwpLoggerContext;
        [FieldOffset(464)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public _ETW_HASH_BUCKET[] EtwpGuidHashTable;
        [FieldOffset(4048)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public ushort[] EtwpSecurityLoggers;
        [FieldOffset(4064)]
        public byte EtwpSecurityProviderEnableMask;
        [FieldOffset(4068)]
        public int EtwpShutdownInProgress;
        [FieldOffset(4072)]
        public uint EtwpSecurityProviderPID;
        [FieldOffset(4080)]
        public _ETW_PRIV_HANDLE_DEMUX_TABLE PrivHandleDemuxTable;
        [FieldOffset(4112)]
        public IntPtr RTBacklogFileRoot;
        [FieldOffset(4120)]
        public _ETW_COUNTERS EtwpCounters;
        [FieldOffset(4136)]
        public _LARGE_INTEGER LogfileBytesWritten;
        [FieldOffset(4144)]
        public IntPtr ProcessorBlocks;
        [FieldOffset(4152)]
        public IntPtr ContainerStateWnfSubscription;
        [FieldOffset(4160)]
        public uint ContainerStateWnfCallbackCalled;
        [FieldOffset(4168)]
        public IntPtr UnsubscribeWorkItem;
        [FieldOffset(4176)]
        public _GUID PartitionId;
        [FieldOffset(4192)]
        public _GUID ParentId;
        [FieldOffset(4208)]
        public _LARGE_INTEGER QpcOffsetFromRoot;
        [FieldOffset(4216)]
        public IntPtr PartitionName;
        [FieldOffset(4224)]
        public ushort PartitionNameSize;
        [FieldOffset(4226)]
        public ushort UnusedPadding;
        [FieldOffset(4228)]
        public uint PartitionType;
        [FieldOffset(4232)]
        public _ETW_SYSTEM_LOGGER_SETTINGS SystemLoggerSettings;
        [FieldOffset(4608)]
        public _KMUTANT EtwpStartTraceMutex;
    }
}