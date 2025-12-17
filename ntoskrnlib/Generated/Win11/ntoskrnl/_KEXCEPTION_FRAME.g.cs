#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 320)]
    public partial struct _KEXCEPTION_FRAME
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
        public ulong P5;
        [FieldOffset(40)]
        public ulong Spare1;
        [FieldOffset(48)]
        public _M128A Xmm6;
        [FieldOffset(64)]
        public _M128A Xmm7;
        [FieldOffset(80)]
        public _M128A Xmm8;
        [FieldOffset(96)]
        public _M128A Xmm9;
        [FieldOffset(112)]
        public _M128A Xmm10;
        [FieldOffset(128)]
        public _M128A Xmm11;
        [FieldOffset(144)]
        public _M128A Xmm12;
        [FieldOffset(160)]
        public _M128A Xmm13;
        [FieldOffset(176)]
        public _M128A Xmm14;
        [FieldOffset(192)]
        public _M128A Xmm15;
        [FieldOffset(208)]
        public ulong TrapFrame;
        [FieldOffset(216)]
        public ulong OutputBuffer;
        [FieldOffset(224)]
        public ulong OutputLength;
        [FieldOffset(232)]
        public ulong Spare2;
        [FieldOffset(240)]
        public ulong MxCsr;
        [FieldOffset(248)]
        public ulong Rbp;
        [FieldOffset(256)]
        public ulong Rbx;
        [FieldOffset(264)]
        public ulong Rdi;
        [FieldOffset(272)]
        public ulong Rsi;
        [FieldOffset(280)]
        public ulong R12;
        [FieldOffset(288)]
        public ulong R13;
        [FieldOffset(296)]
        public ulong R14;
        [FieldOffset(304)]
        public ulong R15;
        [FieldOffset(312)]
        public ulong Return;
    }
}