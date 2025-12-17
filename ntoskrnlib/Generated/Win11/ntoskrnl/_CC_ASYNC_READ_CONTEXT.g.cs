#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _CC_ASYNC_READ_CONTEXT
    {
        [FieldOffset(0)]
        public IntPtr CompletionRoutine;
        [FieldOffset(8)]
        public IntPtr Context;
        [FieldOffset(16)]
        public IntPtr Mdl;
        [FieldOffset(24)]
        public sbyte RequestorMode;
        [FieldOffset(28)]
        public uint NestingLevel;
    }
}