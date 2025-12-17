#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _MI_LARGEPAGE_VAD_INFO
    {
        [FieldOffset(0)]
        public byte LargeImageBias;
        [FieldOffset(1)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] Spare;
        [FieldOffset(8)]
        public ulong ActualImageViewSize;
        [FieldOffset(16)]
        public IntPtr ReferencedPartition;
    }
}