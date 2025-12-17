#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _MI_PAGE_MOVE_PROGRESS_STATE
    {
        [FieldOffset(0)]
        public ulong InProgressProcessors;
        [FieldOffset(0)]
        public ulong SequenceNumber;
        [FieldOffset(0)]
        public long EntireValue;
    }
}