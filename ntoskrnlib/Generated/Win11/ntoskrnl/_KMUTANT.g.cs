#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _KMUTANT
    {
        [FieldOffset(0)]
        public _DISPATCHER_HEADER Header;
        [FieldOffset(24)]
        public _LIST_ENTRY MutantListEntry;
        [FieldOffset(40)]
        public IntPtr OwnerThread;
        [FieldOffset(48)]
        public byte MutantFlags;
        [FieldOffset(48)]
        public byte Abandoned;
        [FieldOffset(48)]
        public byte Spare1;
        [FieldOffset(48)]
        public byte Abandoned2;
        [FieldOffset(48)]
        public byte AbEnabled;
        [FieldOffset(48)]
        public byte Spare2;
        [FieldOffset(49)]
        public byte ApcDisable;
    }
}