#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _TIME_FIELDS
    {
        [FieldOffset(0)]
        public short Year;
        [FieldOffset(2)]
        public short Month;
        [FieldOffset(4)]
        public short Day;
        [FieldOffset(6)]
        public short Hour;
        [FieldOffset(8)]
        public short Minute;
        [FieldOffset(10)]
        public short Second;
        [FieldOffset(12)]
        public short Milliseconds;
        [FieldOffset(14)]
        public short Weekday;
    }
}