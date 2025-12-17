#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _ACTIVATION_CONTEXT_STACK64
    {
        [FieldOffset(0)]
        public ulong ActiveFrame;
        [FieldOffset(8)]
        public LIST_ENTRY64 FrameListCache;
        [FieldOffset(24)]
        public uint Flags;
        [FieldOffset(28)]
        public uint NextCookieSequenceNumber;
        [FieldOffset(32)]
        public uint StackId;
    }
}