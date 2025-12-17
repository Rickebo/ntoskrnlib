#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _PSP_SYSCALL_PROVIDER_DISPATCH_CONTEXT
    {
        [FieldOffset(0)]
        public uint Level;
        [FieldOffset(4)]
        public uint Slot;
    }
}