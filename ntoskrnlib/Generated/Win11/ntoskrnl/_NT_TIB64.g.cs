#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _NT_TIB64
    {
        [FieldOffset(0)]
        public ulong ExceptionList;
        [FieldOffset(8)]
        public ulong StackBase;
        [FieldOffset(16)]
        public ulong StackLimit;
        [FieldOffset(24)]
        public ulong SubSystemTib;
        [FieldOffset(32)]
        public ulong FiberData;
        [FieldOffset(32)]
        public uint Version;
        [FieldOffset(40)]
        public ulong ArbitraryUserPointer;
        [FieldOffset(48)]
        public ulong Self;
    }
}