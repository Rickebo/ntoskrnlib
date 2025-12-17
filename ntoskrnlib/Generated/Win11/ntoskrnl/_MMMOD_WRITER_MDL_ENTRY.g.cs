#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public partial struct _MMMOD_WRITER_MDL_ENTRY
    {
        [FieldOffset(0)]
        public _LIST_ENTRY Links;
        [FieldOffset(16)]
        public IntPtr Irp;
        [FieldOffset(24)]
        public _IO_STATUS_BLOCK IoStatus;
        [FieldOffset(40)]
        public _MODWRITER_FLAGS u1;
        [FieldOffset(44)]
        public uint ByteCount;
        [FieldOffset(48)]
        public uint ChargedPages;
        [FieldOffset(56)]
        public IntPtr Partition;
        [FieldOffset(64)]
        public _unnamed_tag_ Pf;
        [FieldOffset(64)]
        public _unnamed_tag_ Fs;
        [FieldOffset(88)]
        public _LARGE_INTEGER WriteOffset;
        [FieldOffset(96)]
        public IntPtr PointerMdl;
        [FieldOffset(104)]
        public _MDL Mdl;
        [FieldOffset(152)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public ulong[] Page;
    }
}