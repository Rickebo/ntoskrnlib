#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public partial struct _IOV_IRP_TRACE
    {
        [FieldOffset(0)]
        public IntPtr Irp;
        [FieldOffset(8)]
        public IntPtr Thread;
        [FieldOffset(16)]
        public short KernelApcDisable;
        [FieldOffset(18)]
        public short SpecialApcDisable;
        [FieldOffset(16)]
        public uint CombinedApcDisable;
        [FieldOffset(20)]
        public byte Irql;
        [FieldOffset(24)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 13)]
        public IntPtr[] StackTrace;
    }
}