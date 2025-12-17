#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _HARDWARE_PTE
    {
        [FieldOffset(0)]
        public ulong Valid;
        [FieldOffset(0)]
        public ulong Write;
        [FieldOffset(0)]
        public ulong Owner;
        [FieldOffset(0)]
        public ulong WriteThrough;
        [FieldOffset(0)]
        public ulong CacheDisable;
        [FieldOffset(0)]
        public ulong Accessed;
        [FieldOffset(0)]
        public ulong Dirty;
        [FieldOffset(0)]
        public ulong LargePage;
        [FieldOffset(0)]
        public ulong Global;
        [FieldOffset(0)]
        public ulong CopyOnWrite;
        [FieldOffset(0)]
        public ulong Prototype;
        [FieldOffset(0)]
        public ulong reserved0;
        [FieldOffset(0)]
        public ulong PageFrameNumber;
        [FieldOffset(0)]
        public ulong SoftwareWsIndex;
        [FieldOffset(0)]
        public ulong NoExecute;
    }
}