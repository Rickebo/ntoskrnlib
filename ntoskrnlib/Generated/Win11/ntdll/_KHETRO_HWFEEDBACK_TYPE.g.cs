#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _KHETRO_HWFEEDBACK_TYPE
    {
        [FieldOffset(0)]
        public uint Count;
        [FieldOffset(4)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _KHETERO_HWFEEDBACK_CLASS[] HwFeedbackClass;
    }
}