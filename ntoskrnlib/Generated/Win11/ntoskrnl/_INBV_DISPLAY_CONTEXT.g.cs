#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _INBV_DISPLAY_CONTEXT
    {
        [FieldOffset(0)]
        public byte FrameBufferValid;
        [FieldOffset(1)]
        public byte FrameBufferMapped;
        [FieldOffset(2)]
        public byte DisplayRotation;
        [FieldOffset(4)]
        public _INBV_MODE_INFORMATION ModeInformation;
        [FieldOffset(24)]
        public IntPtr ShadowBuffer;
        [FieldOffset(32)]
        public _unnamed_tag_ VideoMemory;
    }
}