#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _DBGKD_GET_VERSION32
    {
        [FieldOffset(0)]
        public ushort MajorVersion;
        [FieldOffset(2)]
        public ushort MinorVersion;
        [FieldOffset(4)]
        public ushort ProtocolVersion;
        [FieldOffset(6)]
        public ushort Flags;
        [FieldOffset(8)]
        public uint KernBase;
        [FieldOffset(12)]
        public uint PsLoadedModuleList;
        [FieldOffset(16)]
        public ushort MachineType;
        [FieldOffset(18)]
        public ushort ThCallbackStack;
        [FieldOffset(20)]
        public ushort NextCallback;
        [FieldOffset(22)]
        public ushort FramePointer;
        [FieldOffset(24)]
        public uint KiCallUserMode;
        [FieldOffset(28)]
        public uint KeUserCallbackDispatcher;
        [FieldOffset(32)]
        public uint BreakpointWithStatus;
        [FieldOffset(36)]
        public uint DebuggerDataList;
    }
}