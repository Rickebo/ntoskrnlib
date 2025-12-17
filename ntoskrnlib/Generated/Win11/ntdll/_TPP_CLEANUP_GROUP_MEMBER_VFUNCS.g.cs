#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _TPP_CLEANUP_GROUP_MEMBER_VFUNCS
    {
        [FieldOffset(0)]
        public IntPtr Free;
        [FieldOffset(8)]
        public IntPtr CallbackEpilog;
        [FieldOffset(16)]
        public IntPtr StopCallbackGeneration;
        [FieldOffset(24)]
        public IntPtr CancelPendingCallbacks;
    }
}