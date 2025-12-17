#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _SK_CRASH_STACK_FRAME
    {
        [FieldOffset(0)]
        public uint ModuleId;
        [FieldOffset(4)]
        public uint Rva;
        [FieldOffset(0)]
        public ulong Pc;
    }
}