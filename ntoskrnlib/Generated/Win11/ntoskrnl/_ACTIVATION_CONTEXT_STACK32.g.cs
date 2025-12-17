#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _ACTIVATION_CONTEXT_STACK32
    {
        [FieldOffset(0)]
        public uint ActiveFrame;
        [FieldOffset(4)]
        public LIST_ENTRY32 FrameListCache;
        [FieldOffset(12)]
        public uint Flags;
        [FieldOffset(16)]
        public uint NextCookieSequenceNumber;
        [FieldOffset(20)]
        public uint StackId;
    }
}