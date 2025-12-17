#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _ALPC_HANDLE_TABLE
    {
        [FieldOffset(0)]
        public IntPtr Handles;
        [FieldOffset(8)]
        public _EX_PUSH_LOCK Lock;
        [FieldOffset(16)]
        public ulong TotalHandles;
        [FieldOffset(24)]
        public uint Flags;
    }
}