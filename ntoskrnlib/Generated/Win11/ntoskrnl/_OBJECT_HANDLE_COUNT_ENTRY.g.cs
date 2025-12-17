#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _OBJECT_HANDLE_COUNT_ENTRY
    {
        [FieldOffset(0)]
        public IntPtr Process;
        [FieldOffset(8)]
        public uint HandleCount;
        [FieldOffset(8)]
        public uint LockCount;
    }
}