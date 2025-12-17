using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KTRAP_FRAME")]
    public sealed class KtrapFrame : DynamicStructure
    {
        [Offset(0UL)]
        public ulong P1Home { get => ReadHere<ulong>(nameof(P1Home)); set => WriteHere(nameof(P1Home), value); }

        [Offset(8UL)]
        public ulong P2Home { get => ReadHere<ulong>(nameof(P2Home)); set => WriteHere(nameof(P2Home), value); }

        [Offset(16UL)]
        public ulong P3Home { get => ReadHere<ulong>(nameof(P3Home)); set => WriteHere(nameof(P3Home), value); }

        [Offset(24UL)]
        public ulong P4Home { get => ReadHere<ulong>(nameof(P4Home)); set => WriteHere(nameof(P4Home), value); }

        [Offset(32UL)]
        public ulong P5 { get => ReadHere<ulong>(nameof(P5)); set => WriteHere(nameof(P5), value); }

        [Offset(40UL)]
        public sbyte PreviousMode { get => ReadHere<sbyte>(nameof(PreviousMode)); set => WriteHere(nameof(PreviousMode), value); }

        [Offset(40UL)]
        public byte InterruptRetpolineState { get => ReadHere<byte>(nameof(InterruptRetpolineState)); set => WriteHere(nameof(InterruptRetpolineState), value); }

        [Offset(41UL)]
        public byte PreviousIrql { get => ReadHere<byte>(nameof(PreviousIrql)); set => WriteHere(nameof(PreviousIrql), value); }

        [Offset(42UL)]
        public byte FaultIndicator { get => ReadHere<byte>(nameof(FaultIndicator)); set => WriteHere(nameof(FaultIndicator), value); }

        [Offset(42UL)]
        public byte NmiMsrIbrs { get => ReadHere<byte>(nameof(NmiMsrIbrs)); set => WriteHere(nameof(NmiMsrIbrs), value); }

        [Offset(43UL)]
        public byte ExceptionActive { get => ReadHere<byte>(nameof(ExceptionActive)); set => WriteHere(nameof(ExceptionActive), value); }

        [Offset(44UL)]
        public uint MxCsr { get => ReadHere<uint>(nameof(MxCsr)); set => WriteHere(nameof(MxCsr), value); }

        [Offset(48UL)]
        public ulong Rax { get => ReadHere<ulong>(nameof(Rax)); set => WriteHere(nameof(Rax), value); }

        [Offset(56UL)]
        public ulong Rcx { get => ReadHere<ulong>(nameof(Rcx)); set => WriteHere(nameof(Rcx), value); }

        [Offset(64UL)]
        public ulong Rdx { get => ReadHere<ulong>(nameof(Rdx)); set => WriteHere(nameof(Rdx), value); }

        [Offset(72UL)]
        public ulong R8 { get => ReadHere<ulong>(nameof(R8)); set => WriteHere(nameof(R8), value); }

        [Offset(80UL)]
        public ulong R9 { get => ReadHere<ulong>(nameof(R9)); set => WriteHere(nameof(R9), value); }

        [Offset(88UL)]
        public ulong R10 { get => ReadHere<ulong>(nameof(R10)); set => WriteHere(nameof(R10), value); }

        [Offset(96UL)]
        public ulong R11 { get => ReadHere<ulong>(nameof(R11)); set => WriteHere(nameof(R11), value); }

        [Offset(104UL)]
        public ulong GsBase { get => ReadHere<ulong>(nameof(GsBase)); set => WriteHere(nameof(GsBase), value); }

        [Offset(104UL)]
        public ulong GsSwap { get => ReadHere<ulong>(nameof(GsSwap)); set => WriteHere(nameof(GsSwap), value); }

        [Offset(112UL)]
        public M128A Xmm0 { get => ReadStructure<M128A>(nameof(Xmm0)); set => WriteStructure(nameof(Xmm0), value); }

        [Offset(128UL)]
        public M128A Xmm1 { get => ReadStructure<M128A>(nameof(Xmm1)); set => WriteStructure(nameof(Xmm1), value); }

        [Offset(144UL)]
        public M128A Xmm2 { get => ReadStructure<M128A>(nameof(Xmm2)); set => WriteStructure(nameof(Xmm2), value); }

        [Offset(160UL)]
        public M128A Xmm3 { get => ReadStructure<M128A>(nameof(Xmm3)); set => WriteStructure(nameof(Xmm3), value); }

        [Offset(176UL)]
        public M128A Xmm4 { get => ReadStructure<M128A>(nameof(Xmm4)); set => WriteStructure(nameof(Xmm4), value); }

        [Offset(192UL)]
        public M128A Xmm5 { get => ReadStructure<M128A>(nameof(Xmm5)); set => WriteStructure(nameof(Xmm5), value); }

        [Offset(208UL)]
        public ulong FaultAddress { get => ReadHere<ulong>(nameof(FaultAddress)); set => WriteHere(nameof(FaultAddress), value); }

        [Offset(208UL)]
        public ulong ContextRecord { get => ReadHere<ulong>(nameof(ContextRecord)); set => WriteHere(nameof(ContextRecord), value); }

        [Offset(216UL)]
        public ulong Dr0 { get => ReadHere<ulong>(nameof(Dr0)); set => WriteHere(nameof(Dr0), value); }

        [Offset(224UL)]
        public ulong Dr1 { get => ReadHere<ulong>(nameof(Dr1)); set => WriteHere(nameof(Dr1), value); }

        [Offset(232UL)]
        public ulong Dr2 { get => ReadHere<ulong>(nameof(Dr2)); set => WriteHere(nameof(Dr2), value); }

        [Offset(240UL)]
        public ulong Dr3 { get => ReadHere<ulong>(nameof(Dr3)); set => WriteHere(nameof(Dr3), value); }

        [Offset(248UL)]
        public ulong Dr6 { get => ReadHere<ulong>(nameof(Dr6)); set => WriteHere(nameof(Dr6), value); }

        [Offset(256UL)]
        public ulong Dr7 { get => ReadHere<ulong>(nameof(Dr7)); set => WriteHere(nameof(Dr7), value); }

        [Offset(216UL)]
        public ulong ShadowStackFrame { get => ReadHere<ulong>(nameof(ShadowStackFrame)); set => WriteHere(nameof(ShadowStackFrame), value); }

        [Offset(224UL)]
        [Length(5)]
        public DynamicArray Spare { get => ReadStructure<DynamicArray>(nameof(Spare)); set => WriteStructure(nameof(Spare), value); }

        [Offset(264UL)]
        public ulong DebugControl { get => ReadHere<ulong>(nameof(DebugControl)); set => WriteHere(nameof(DebugControl), value); }

        [Offset(272UL)]
        public ulong LastBranchToRip { get => ReadHere<ulong>(nameof(LastBranchToRip)); set => WriteHere(nameof(LastBranchToRip), value); }

        [Offset(280UL)]
        public ulong LastBranchFromRip { get => ReadHere<ulong>(nameof(LastBranchFromRip)); set => WriteHere(nameof(LastBranchFromRip), value); }

        [Offset(288UL)]
        public ulong LastExceptionToRip { get => ReadHere<ulong>(nameof(LastExceptionToRip)); set => WriteHere(nameof(LastExceptionToRip), value); }

        [Offset(296UL)]
        public ulong LastExceptionFromRip { get => ReadHere<ulong>(nameof(LastExceptionFromRip)); set => WriteHere(nameof(LastExceptionFromRip), value); }

        [Offset(304UL)]
        public ushort SegDs { get => ReadHere<ushort>(nameof(SegDs)); set => WriteHere(nameof(SegDs), value); }

        [Offset(306UL)]
        public ushort SegEs { get => ReadHere<ushort>(nameof(SegEs)); set => WriteHere(nameof(SegEs), value); }

        [Offset(308UL)]
        public ushort SegFs { get => ReadHere<ushort>(nameof(SegFs)); set => WriteHere(nameof(SegFs), value); }

        [Offset(310UL)]
        public ushort SegGs { get => ReadHere<ushort>(nameof(SegGs)); set => WriteHere(nameof(SegGs), value); }

        [Offset(312UL)]
        public ulong TrapFrame { get => ReadHere<ulong>(nameof(TrapFrame)); set => WriteHere(nameof(TrapFrame), value); }

        [Offset(320UL)]
        public uint NmiPreviousSpecCtrl { get => ReadHere<uint>(nameof(NmiPreviousSpecCtrl)); set => WriteHere(nameof(NmiPreviousSpecCtrl), value); }

        [Offset(324UL)]
        public uint NmiPreviousSpecCtrlPad { get => ReadHere<uint>(nameof(NmiPreviousSpecCtrlPad)); set => WriteHere(nameof(NmiPreviousSpecCtrlPad), value); }

        [Offset(320UL)]
        public ulong Rbx { get => ReadHere<ulong>(nameof(Rbx)); set => WriteHere(nameof(Rbx), value); }

        [Offset(328UL)]
        public ulong Rdi { get => ReadHere<ulong>(nameof(Rdi)); set => WriteHere(nameof(Rdi), value); }

        [Offset(336UL)]
        public ulong Rsi { get => ReadHere<ulong>(nameof(Rsi)); set => WriteHere(nameof(Rsi), value); }

        [Offset(344UL)]
        public ulong Rbp { get => ReadHere<ulong>(nameof(Rbp)); set => WriteHere(nameof(Rbp), value); }

        [Offset(352UL)]
        public ulong ErrorCode { get => ReadHere<ulong>(nameof(ErrorCode)); set => WriteHere(nameof(ErrorCode), value); }

        [Offset(352UL)]
        public ulong ExceptionFrame { get => ReadHere<ulong>(nameof(ExceptionFrame)); set => WriteHere(nameof(ExceptionFrame), value); }

        [Offset(360UL)]
        public ulong Rip { get => ReadHere<ulong>(nameof(Rip)); set => WriteHere(nameof(Rip), value); }

        [Offset(368UL)]
        public ushort SegCs { get => ReadHere<ushort>(nameof(SegCs)); set => WriteHere(nameof(SegCs), value); }

        [Offset(370UL)]
        public byte Fill0 { get => ReadHere<byte>(nameof(Fill0)); set => WriteHere(nameof(Fill0), value); }

        [Offset(371UL)]
        public byte Logging { get => ReadHere<byte>(nameof(Logging)); set => WriteHere(nameof(Logging), value); }

        [Offset(372UL)]
        [Length(2)]
        public DynamicArray Fill1 { get => ReadStructure<DynamicArray>(nameof(Fill1)); set => WriteStructure(nameof(Fill1), value); }

        [Offset(376UL)]
        public uint EFlags { get => ReadHere<uint>(nameof(EFlags)); set => WriteHere(nameof(EFlags), value); }

        [Offset(380UL)]
        public uint Fill2 { get => ReadHere<uint>(nameof(Fill2)); set => WriteHere(nameof(Fill2), value); }

        [Offset(384UL)]
        public ulong Rsp { get => ReadHere<ulong>(nameof(Rsp)); set => WriteHere(nameof(Rsp), value); }

        [Offset(392UL)]
        public ushort SegSs { get => ReadHere<ushort>(nameof(SegSs)); set => WriteHere(nameof(SegSs), value); }

        [Offset(394UL)]
        public ushort Fill3 { get => ReadHere<ushort>(nameof(Fill3)); set => WriteHere(nameof(Fill3), value); }

        [Offset(396UL)]
        public uint Fill4 { get => ReadHere<uint>(nameof(Fill4)); set => WriteHere(nameof(Fill4), value); }

        public KtrapFrame(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KtrapFrame>();
        }
    }
}