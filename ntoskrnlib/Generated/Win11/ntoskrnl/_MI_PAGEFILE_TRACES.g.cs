#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public partial struct _MI_PAGEFILE_TRACES
    {
        [FieldOffset(0)]
        public int Status;
        [FieldOffset(4)]
        public byte PagefileNumber;
        [FieldOffset(5)]
        public byte Priority;
        [FieldOffset(6)]
        public byte IrpPriority;
        [FieldOffset(7)]
        public byte ReservationWrite;
        [FieldOffset(8)]
        public ulong CurrentTime;
        [FieldOffset(16)]
        public ulong AvailablePages;
        [FieldOffset(24)]
        public ulong ModifiedPagesTotal;
        [FieldOffset(32)]
        public ulong ModifiedPagefilePages;
        [FieldOffset(40)]
        public ulong ModifiedNoWritePages;
        [FieldOffset(48)]
        public ulong ModifiedPagefileNoReservationPages;
        [FieldOffset(56)]
        public ulong ModifiedPageFileNoReservationCompressPages;
        [FieldOffset(64)]
        public ulong ModifiedPagefileReservationPages;
        [FieldOffset(72)]
        public _unnamed_tag_ LocalMdl;
    }
}