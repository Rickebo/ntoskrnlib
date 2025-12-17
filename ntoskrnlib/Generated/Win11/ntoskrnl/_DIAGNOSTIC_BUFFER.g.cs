#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _DIAGNOSTIC_BUFFER
    {
        [FieldOffset(0)]
        public ulong Size;
        [FieldOffset(8)]
        public uint CallerType;
        [FieldOffset(16)]
        public ulong ProcessImageNameOffset;
        [FieldOffset(24)]
        public uint ProcessId;
        [FieldOffset(28)]
        public uint ServiceTag;
        [FieldOffset(16)]
        public ulong DeviceDescriptionOffset;
        [FieldOffset(24)]
        public ulong DevicePathOffset;
        [FieldOffset(32)]
        public ulong ReasonOffset;
    }
}