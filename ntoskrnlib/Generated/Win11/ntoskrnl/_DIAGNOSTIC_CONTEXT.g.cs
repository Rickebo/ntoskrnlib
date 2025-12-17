#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _DIAGNOSTIC_CONTEXT
    {
        [FieldOffset(0)]
        public uint CallerType;
        [FieldOffset(8)]
        public IntPtr Process;
        [FieldOffset(16)]
        public _UNICODE_STRING ProcessImageName;
        [FieldOffset(32)]
        public uint ProcessId;
        [FieldOffset(36)]
        public uint SessionId;
        [FieldOffset(40)]
        public uint ServiceTag;
        [FieldOffset(8)]
        public IntPtr DeviceObject;
        [FieldOffset(48)]
        public ulong ReasonSize;
    }
}