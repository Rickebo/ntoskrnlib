#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _RTL_HP_HEAP_VA_CALLBACKS_ENCODED
    {
        [FieldOffset(0)]
        public ulong CallbackContext;
        [FieldOffset(8)]
        public ulong AllocateVirtualMemoryEncoded;
        [FieldOffset(16)]
        public ulong FreeVirtualMemoryEncoded;
        [FieldOffset(24)]
        public ulong QueryVirtualMemoryEncoded;
    }
}