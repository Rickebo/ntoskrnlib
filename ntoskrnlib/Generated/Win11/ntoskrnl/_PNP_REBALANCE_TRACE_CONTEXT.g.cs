#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public partial struct _PNP_REBALANCE_TRACE_CONTEXT
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] DeviceCount;
        [FieldOffset(8)]
        public uint RebalancePhase;
        [FieldOffset(12)]
        public uint Reason;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] Failure;
        [FieldOffset(24)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public IntPtr[] SubtreeRoot;
        [FieldOffset(40)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] SubtreeIncludesRoot;
        [FieldOffset(48)]
        public IntPtr TriggerRoot;
        [FieldOffset(56)]
        public _PNP_REBALANCE_FLAGS Flags;
        [FieldOffset(64)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] BeginTime;
        [FieldOffset(80)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public IntPtr[] VetoNode;
        [FieldOffset(96)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] VetoQueryRebalanceReason;
        [FieldOffset(104)]
        public _PNP_RESOURCE_CONFLICT_TRACE_CONTEXT ConflictContext;
    }
}