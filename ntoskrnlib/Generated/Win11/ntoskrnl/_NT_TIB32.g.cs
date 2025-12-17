#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial struct _NT_TIB32
    {
        [FieldOffset(0)]
        public uint ExceptionList;
        [FieldOffset(4)]
        public uint StackBase;
        [FieldOffset(8)]
        public uint StackLimit;
        [FieldOffset(12)]
        public uint SubSystemTib;
        [FieldOffset(16)]
        public uint FiberData;
        [FieldOffset(16)]
        public uint Version;
        [FieldOffset(20)]
        public uint ArbitraryUserPointer;
        [FieldOffset(24)]
        public uint Self;
    }
}