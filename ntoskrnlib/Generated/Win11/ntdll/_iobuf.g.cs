#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _iobuf
    {
        [FieldOffset(0)]
        public IntPtr _ptr;
        [FieldOffset(8)]
        public int _cnt;
        [FieldOffset(16)]
        public IntPtr _base;
        [FieldOffset(24)]
        public int _flag;
        [FieldOffset(28)]
        public int _file;
        [FieldOffset(32)]
        public int _charbuf;
        [FieldOffset(36)]
        public int _bufsiz;
        [FieldOffset(40)]
        public IntPtr _tmpfname;
    }
}