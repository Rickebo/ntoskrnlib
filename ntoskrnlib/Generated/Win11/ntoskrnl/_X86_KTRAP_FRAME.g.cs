#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 140)]
    public partial struct _X86_KTRAP_FRAME
    {
        [FieldOffset(0)]
        public uint DbgEbp;
        [FieldOffset(4)]
        public uint DbgEip;
        [FieldOffset(8)]
        public uint DbgArgMark;
        [FieldOffset(12)]
        public uint DbgArgPointer;
        [FieldOffset(16)]
        public uint TempSegCs;
        [FieldOffset(20)]
        public uint TempEsp;
        [FieldOffset(24)]
        public uint Dr0;
        [FieldOffset(28)]
        public uint Dr1;
        [FieldOffset(32)]
        public uint Dr2;
        [FieldOffset(36)]
        public uint Dr3;
        [FieldOffset(40)]
        public uint Dr6;
        [FieldOffset(44)]
        public uint Dr7;
        [FieldOffset(48)]
        public uint SegGs;
        [FieldOffset(52)]
        public uint SegEs;
        [FieldOffset(56)]
        public uint SegDs;
        [FieldOffset(60)]
        public uint Edx;
        [FieldOffset(64)]
        public uint Ecx;
        [FieldOffset(68)]
        public uint Eax;
        [FieldOffset(72)]
        public byte PreviousPreviousMode;
        [FieldOffset(73)]
        public byte EntropyQueueDpc;
        [FieldOffset(74)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] Reserved;
        [FieldOffset(76)]
        public uint ExceptionList;
        [FieldOffset(80)]
        public uint SegFs;
        [FieldOffset(84)]
        public uint Edi;
        [FieldOffset(88)]
        public uint Esi;
        [FieldOffset(92)]
        public uint Ebx;
        [FieldOffset(96)]
        public uint Ebp;
        [FieldOffset(100)]
        public uint ErrCode;
        [FieldOffset(104)]
        public uint Eip;
        [FieldOffset(108)]
        public uint SegCs;
        [FieldOffset(112)]
        public uint EFlags;
        [FieldOffset(116)]
        public uint HardwareEsp;
        [FieldOffset(120)]
        public uint HardwareSegSs;
        [FieldOffset(124)]
        public uint V86Es;
        [FieldOffset(128)]
        public uint V86Ds;
        [FieldOffset(132)]
        public uint V86Fs;
        [FieldOffset(136)]
        public uint V86Gs;
    }
}