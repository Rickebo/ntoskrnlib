#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 1248)]
    public partial struct _GDI_TEB_BATCH32
    {
        [FieldOffset(0)]
        public uint Offset;
        [FieldOffset(0)]
        public uint InProcessing;
        [FieldOffset(0)]
        public uint HasRenderingCommand;
        [FieldOffset(4)]
        public uint HDC;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 310)]
        public uint[] Buffer;
    }
}