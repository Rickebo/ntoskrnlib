#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _RTLP_HP_THREAD_CTX
    {
        [FieldOffset(0)]
        public byte LegacyVirtualAffinity;
        [FieldOffset(1)]
        public byte CachedProcIndex;
        [FieldOffset(2)]
        public ushort LFHDataSlot;
        [FieldOffset(0)]
        public uint EntireUlong;
    }
}