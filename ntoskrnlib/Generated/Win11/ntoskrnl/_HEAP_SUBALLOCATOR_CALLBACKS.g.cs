#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _HEAP_SUBALLOCATOR_CALLBACKS
    {
        [FieldOffset(0)]
        public ulong Allocate;
        [FieldOffset(8)]
        public ulong Free;
        [FieldOffset(16)]
        public ulong Commit;
        [FieldOffset(24)]
        public ulong Decommit;
        [FieldOffset(32)]
        public ulong ExtendContext;
        [FieldOffset(40)]
        public ulong TlsCleanup;
    }
}