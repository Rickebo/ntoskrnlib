#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _MI_PARTITION_ZEROING
    {
        [FieldOffset(0)]
        public _WORK_QUEUE_ITEM RebalanceZeroFreeWorkItem;
        [FieldOffset(32)]
        public int BackgroundZeroingDisabled;
        [FieldOffset(36)]
        public int BootEnginesCalibrating;
        [FieldOffset(40)]
        public _KEVENT BootEnginesCalibrationWaiters;
        [FieldOffset(64)]
        public int ZeroFreePageSlistMinimum;
        [FieldOffset(68)]
        public uint BackgroundZeroingPreference;
    }
}