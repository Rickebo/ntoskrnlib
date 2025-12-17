#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _IOMMU_PAGE_HANDLING_DATA
    {
        [FieldOffset(0)]
        public _EX_PUSH_LOCK ResetLock;
        [FieldOffset(8)]
        public ulong Lock;
        [FieldOffset(16)]
        public uint ValidGroupFaultSequenceNumber;
        [FieldOffset(24)]
        public IntPtr GetPageFault;
        [FieldOffset(32)]
        public IntPtr DismissPageFault;
    }
}