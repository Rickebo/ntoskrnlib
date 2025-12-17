#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 896)]
    public partial struct _KSHARED_READY_QUEUE_HETERO_STATISTICS
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public byte[] ExpectedRuntimeByClass;
    }
}