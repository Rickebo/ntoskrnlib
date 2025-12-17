#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _DEVICE_FLAGS
    {
        [FieldOffset(0)]
        public uint Failed;
        [FieldOffset(0)]
        public uint ReadOnly;
        [FieldOffset(0)]
        public uint Removable;
        [FieldOffset(0)]
        public uint ConsoleIn;
        [FieldOffset(0)]
        public uint ConsoleOut;
        [FieldOffset(0)]
        public uint Input;
        [FieldOffset(0)]
        public uint Output;
    }
}