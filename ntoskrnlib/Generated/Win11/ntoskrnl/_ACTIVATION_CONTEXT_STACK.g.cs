#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _ACTIVATION_CONTEXT_STACK
    {
        [FieldOffset(0)]
        public IntPtr ActiveFrame;
        [FieldOffset(8)]
        public _LIST_ENTRY FrameListCache;
        [FieldOffset(24)]
        public uint Flags;
        [FieldOffset(28)]
        public uint NextCookieSequenceNumber;
        [FieldOffset(32)]
        public uint StackId;
    }
}