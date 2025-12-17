#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _DBGKD_GET_VERSION64
    {
        [FieldOffset(0)]
        public ushort MajorVersion;
        [FieldOffset(2)]
        public ushort MinorVersion;
        [FieldOffset(4)]
        public byte ProtocolVersion;
        [FieldOffset(5)]
        public byte KdSecondaryVersion;
        [FieldOffset(6)]
        public ushort Flags;
        [FieldOffset(8)]
        public ushort MachineType;
        [FieldOffset(10)]
        public byte MaxPacketType;
        [FieldOffset(11)]
        public byte MaxStateChange;
        [FieldOffset(12)]
        public byte MaxManipulate;
        [FieldOffset(13)]
        public byte Simulation;
        [FieldOffset(14)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public ushort[] Unused;
        [FieldOffset(16)]
        public ulong KernBase;
        [FieldOffset(24)]
        public ulong PsLoadedModuleList;
        [FieldOffset(32)]
        public ulong DebuggerDataList;
    }
}