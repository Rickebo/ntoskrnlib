#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 288)]
    public partial struct _SEP_TOKEN_DIAG_TRACK_ENTRY
    {
        [FieldOffset(0)]
        public IntPtr ProcessCid;
        [FieldOffset(8)]
        public IntPtr ThreadCid;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] ImageFileName;
        [FieldOffset(32)]
        public uint CreateMethod;
        [FieldOffset(40)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
        public ulong[] CreateTrace;
        [FieldOffset(280)]
        public int Count;
        [FieldOffset(284)]
        public int CaptureCount;
    }
}