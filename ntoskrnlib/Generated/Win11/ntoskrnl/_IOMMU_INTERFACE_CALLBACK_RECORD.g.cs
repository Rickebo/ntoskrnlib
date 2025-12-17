#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _IOMMU_INTERFACE_CALLBACK_RECORD
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(16)]
        public IntPtr CallbackRoutine;
        [FieldOffset(24)]
        public IntPtr CallbackContext;
        [FieldOffset(32)]
        public IntPtr DmaDevice;
        [FieldOffset(40)]
        public _IOMMU_INTERFACE_STATE_CHANGE LastReportedState;
    }
}