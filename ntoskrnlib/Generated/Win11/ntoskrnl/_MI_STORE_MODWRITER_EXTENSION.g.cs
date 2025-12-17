#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public partial struct _MI_STORE_MODWRITER_EXTENSION
    {
        [FieldOffset(0)]
        public _KAPC WriteCompletionApc;
        [FieldOffset(88)]
        public uint WriteRefCount;
        [FieldOffset(92)]
        public uint PadSpare;
        [FieldOffset(96)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _MMPTE[] PagefileInfo;
    }
}