#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4096)]
    public partial struct _SK_CRASH_MINIDUMP
    {
        [FieldOffset(0)]
        public uint Size;
        [FieldOffset(4)]
        public uint Version;
        [FieldOffset(8)]
        public uint ModuleCount;
        [FieldOffset(12)]
        public uint FrameCount;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public _SK_CRASH_MODULE[] Modules;
        [FieldOffset(1168)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 366)]
        public _SK_CRASH_STACK_FRAME[] StackFrames;
    }
}