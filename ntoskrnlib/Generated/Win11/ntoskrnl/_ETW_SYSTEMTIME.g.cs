#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _ETW_SYSTEMTIME
    {
        [FieldOffset(0)]
        public ushort Year;
        [FieldOffset(2)]
        public ushort Month;
        [FieldOffset(4)]
        public ushort DayOfWeek;
        [FieldOffset(6)]
        public ushort Day;
        [FieldOffset(8)]
        public ushort Hour;
        [FieldOffset(10)]
        public ushort Minute;
        [FieldOffset(12)]
        public ushort Second;
        [FieldOffset(14)]
        public ushort Milliseconds;
    }
}