using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=400)]
public struct _KTRAP_FRAME
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
    public sbyte PreviousMode;
    [FieldOffset(40)]
    public byte InterruptRetpolineState;
    [FieldOffset(41)]
    public byte PreviousIrql;
    [FieldOffset(42)]
    public byte FaultIndicator;
    [FieldOffset(42)]
    public byte NmiMsrIbrs;
    [FieldOffset(43)]
    public byte ExceptionActive;
    [FieldOffset(44)]
    public uint MxCsr;
    [FieldOffset(48)]
    public ulong Rax;
    [FieldOffset(56)]
    public ulong Rcx;
    [FieldOffset(64)]
    public ulong Rdx;
    [FieldOffset(72)]
    public ulong R8;
    [FieldOffset(80)]
    public ulong R9;
    [FieldOffset(88)]
    public ulong R10;
    [FieldOffset(96)]
    public ulong R11;
    [FieldOffset(104)]
    public ulong GsBase;
    [FieldOffset(104)]
    public ulong GsSwap;
    [FieldOffset(112)]
    public _M128A Xmm0;
    [FieldOffset(128)]
    public _M128A Xmm1;
    [FieldOffset(144)]
    public _M128A Xmm2;
    [FieldOffset(160)]
    public _M128A Xmm3;
    [FieldOffset(176)]
    public _M128A Xmm4;
    [FieldOffset(192)]
    public _M128A Xmm5;
    [FieldOffset(208)]
    public ulong FaultAddress;
    [FieldOffset(208)]
    public ulong ContextRecord;
    [FieldOffset(216)]
    public ulong Dr0;
    [FieldOffset(224)]
    public ulong Dr1;
    [FieldOffset(232)]
    public ulong Dr2;
    [FieldOffset(240)]
    public ulong Dr3;
    [FieldOffset(248)]
    public ulong Dr6;
    [FieldOffset(256)]
    public ulong Dr7;
    [FieldOffset(216)]
    public ulong ShadowStackFrame;
    [FieldOffset(224)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=5)]
    public ulong[] Spare;
    [FieldOffset(264)]
    public ulong DebugControl;
    [FieldOffset(272)]
    public ulong LastBranchToRip;
    [FieldOffset(280)]
    public ulong LastBranchFromRip;
    [FieldOffset(288)]
    public ulong LastExceptionToRip;
    [FieldOffset(296)]
    public ulong LastExceptionFromRip;
    [FieldOffset(304)]
    public ushort SegDs;
    [FieldOffset(306)]
    public ushort SegEs;
    [FieldOffset(308)]
    public ushort SegFs;
    [FieldOffset(310)]
    public ushort SegGs;
    [FieldOffset(312)]
    public ulong TrapFrame;
    [FieldOffset(320)]
    public uint NmiPreviousSpecCtrl;
    [FieldOffset(324)]
    public uint NmiPreviousSpecCtrlPad;
    [FieldOffset(320)]
    public ulong Rbx;
    [FieldOffset(328)]
    public ulong Rdi;
    [FieldOffset(336)]
    public ulong Rsi;
    [FieldOffset(344)]
    public ulong Rbp;
    [FieldOffset(352)]
    public ulong ErrorCode;
    [FieldOffset(352)]
    public ulong ExceptionFrame;
    [FieldOffset(360)]
    public ulong Rip;
    [FieldOffset(368)]
    public ushort SegCs;
    [FieldOffset(370)]
    public byte Fill0;
    [FieldOffset(371)]
    public byte Logging;
    [FieldOffset(372)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]
    public ushort[] Fill1;
    [FieldOffset(376)]
    public uint EFlags;
    [FieldOffset(380)]
    public uint Fill2;
    [FieldOffset(384)]
    public ulong Rsp;
    [FieldOffset(392)]
    public ushort SegSs;
    [FieldOffset(394)]
    public ushort Fill3;
    [FieldOffset(396)]
    public uint Fill4;
}
