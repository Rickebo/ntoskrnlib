#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 1232)]
    public partial struct _CONTEXT
    {
        [FieldOffset(0)]
        public ulong P1Home;
        [FieldOffset(8)]
        public ulong P2Home;
        [FieldOffset(16)]
        public ulong P3Home;
        [FieldOffset(24)]
        public ulong P4Home;
        [FieldOffset(32)]
        public ulong P5Home;
        [FieldOffset(40)]
        public ulong P6Home;
        [FieldOffset(48)]
        public uint ContextFlags;
        [FieldOffset(52)]
        public uint MxCsr;
        [FieldOffset(56)]
        public ushort SegCs;
        [FieldOffset(58)]
        public ushort SegDs;
        [FieldOffset(60)]
        public ushort SegEs;
        [FieldOffset(62)]
        public ushort SegFs;
        [FieldOffset(64)]
        public ushort SegGs;
        [FieldOffset(66)]
        public ushort SegSs;
        [FieldOffset(68)]
        public uint EFlags;
        [FieldOffset(72)]
        public ulong Dr0;
        [FieldOffset(80)]
        public ulong Dr1;
        [FieldOffset(88)]
        public ulong Dr2;
        [FieldOffset(96)]
        public ulong Dr3;
        [FieldOffset(104)]
        public ulong Dr6;
        [FieldOffset(112)]
        public ulong Dr7;
        [FieldOffset(120)]
        public ulong Rax;
        [FieldOffset(128)]
        public ulong Rcx;
        [FieldOffset(136)]
        public ulong Rdx;
        [FieldOffset(144)]
        public ulong Rbx;
        [FieldOffset(152)]
        public ulong Rsp;
        [FieldOffset(160)]
        public ulong Rbp;
        [FieldOffset(168)]
        public ulong Rsi;
        [FieldOffset(176)]
        public ulong Rdi;
        [FieldOffset(184)]
        public ulong R8;
        [FieldOffset(192)]
        public ulong R9;
        [FieldOffset(200)]
        public ulong R10;
        [FieldOffset(208)]
        public ulong R11;
        [FieldOffset(216)]
        public ulong R12;
        [FieldOffset(224)]
        public ulong R13;
        [FieldOffset(232)]
        public ulong R14;
        [FieldOffset(240)]
        public ulong R15;
        [FieldOffset(248)]
        public ulong Rip;
        [FieldOffset(256)]
        public _XSAVE_FORMAT FltSave;
        [FieldOffset(256)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public _M128A[] Header;
        [FieldOffset(288)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public _M128A[] Legacy;
        [FieldOffset(416)]
        public _M128A Xmm0;
        [FieldOffset(432)]
        public _M128A Xmm1;
        [FieldOffset(448)]
        public _M128A Xmm2;
        [FieldOffset(464)]
        public _M128A Xmm3;
        [FieldOffset(480)]
        public _M128A Xmm4;
        [FieldOffset(496)]
        public _M128A Xmm5;
        [FieldOffset(512)]
        public _M128A Xmm6;
        [FieldOffset(528)]
        public _M128A Xmm7;
        [FieldOffset(544)]
        public _M128A Xmm8;
        [FieldOffset(560)]
        public _M128A Xmm9;
        [FieldOffset(576)]
        public _M128A Xmm10;
        [FieldOffset(592)]
        public _M128A Xmm11;
        [FieldOffset(608)]
        public _M128A Xmm12;
        [FieldOffset(624)]
        public _M128A Xmm13;
        [FieldOffset(640)]
        public _M128A Xmm14;
        [FieldOffset(656)]
        public _M128A Xmm15;
        [FieldOffset(768)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 26)]
        public _M128A[] VectorRegister;
        [FieldOffset(1184)]
        public ulong VectorControl;
        [FieldOffset(1192)]
        public ulong DebugControl;
        [FieldOffset(1200)]
        public ulong LastBranchToRip;
        [FieldOffset(1208)]
        public ulong LastBranchFromRip;
        [FieldOffset(1216)]
        public ulong LastExceptionToRip;
        [FieldOffset(1224)]
        public ulong LastExceptionFromRip;
    }
}