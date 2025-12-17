#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _PCW_REGISTRATION_INFORMATION
    {
        [FieldOffset(0)]
        public uint Version;
        [FieldOffset(8)]
        public IntPtr Name;
        [FieldOffset(16)]
        public uint CounterCount;
        [FieldOffset(24)]
        public IntPtr Counters;
        [FieldOffset(32)]
        public IntPtr Callback;
        [FieldOffset(40)]
        public IntPtr CallbackContext;
        [FieldOffset(48)]
        public uint Flags;
    }
}