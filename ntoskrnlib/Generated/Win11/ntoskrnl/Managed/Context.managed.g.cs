using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CONTEXT")]
    public sealed class Context : DynamicStructure
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
        public ulong P5Home { get => ReadHere<ulong>(nameof(P5Home)); set => WriteHere(nameof(P5Home), value); }

        [Offset(40UL)]
        public ulong P6Home { get => ReadHere<ulong>(nameof(P6Home)); set => WriteHere(nameof(P6Home), value); }

        [Offset(48UL)]
        public uint ContextFlags { get => ReadHere<uint>(nameof(ContextFlags)); set => WriteHere(nameof(ContextFlags), value); }

        [Offset(52UL)]
        public uint MxCsr { get => ReadHere<uint>(nameof(MxCsr)); set => WriteHere(nameof(MxCsr), value); }

        [Offset(56UL)]
        public ushort SegCs { get => ReadHere<ushort>(nameof(SegCs)); set => WriteHere(nameof(SegCs), value); }

        [Offset(58UL)]
        public ushort SegDs { get => ReadHere<ushort>(nameof(SegDs)); set => WriteHere(nameof(SegDs), value); }

        [Offset(60UL)]
        public ushort SegEs { get => ReadHere<ushort>(nameof(SegEs)); set => WriteHere(nameof(SegEs), value); }

        [Offset(62UL)]
        public ushort SegFs { get => ReadHere<ushort>(nameof(SegFs)); set => WriteHere(nameof(SegFs), value); }

        [Offset(64UL)]
        public ushort SegGs { get => ReadHere<ushort>(nameof(SegGs)); set => WriteHere(nameof(SegGs), value); }

        [Offset(66UL)]
        public ushort SegSs { get => ReadHere<ushort>(nameof(SegSs)); set => WriteHere(nameof(SegSs), value); }

        [Offset(68UL)]
        public uint EFlags { get => ReadHere<uint>(nameof(EFlags)); set => WriteHere(nameof(EFlags), value); }

        [Offset(72UL)]
        public ulong Dr0 { get => ReadHere<ulong>(nameof(Dr0)); set => WriteHere(nameof(Dr0), value); }

        [Offset(80UL)]
        public ulong Dr1 { get => ReadHere<ulong>(nameof(Dr1)); set => WriteHere(nameof(Dr1), value); }

        [Offset(88UL)]
        public ulong Dr2 { get => ReadHere<ulong>(nameof(Dr2)); set => WriteHere(nameof(Dr2), value); }

        [Offset(96UL)]
        public ulong Dr3 { get => ReadHere<ulong>(nameof(Dr3)); set => WriteHere(nameof(Dr3), value); }

        [Offset(104UL)]
        public ulong Dr6 { get => ReadHere<ulong>(nameof(Dr6)); set => WriteHere(nameof(Dr6), value); }

        [Offset(112UL)]
        public ulong Dr7 { get => ReadHere<ulong>(nameof(Dr7)); set => WriteHere(nameof(Dr7), value); }

        [Offset(120UL)]
        public ulong Rax { get => ReadHere<ulong>(nameof(Rax)); set => WriteHere(nameof(Rax), value); }

        [Offset(128UL)]
        public ulong Rcx { get => ReadHere<ulong>(nameof(Rcx)); set => WriteHere(nameof(Rcx), value); }

        [Offset(136UL)]
        public ulong Rdx { get => ReadHere<ulong>(nameof(Rdx)); set => WriteHere(nameof(Rdx), value); }

        [Offset(144UL)]
        public ulong Rbx { get => ReadHere<ulong>(nameof(Rbx)); set => WriteHere(nameof(Rbx), value); }

        [Offset(152UL)]
        public ulong Rsp { get => ReadHere<ulong>(nameof(Rsp)); set => WriteHere(nameof(Rsp), value); }

        [Offset(160UL)]
        public ulong Rbp { get => ReadHere<ulong>(nameof(Rbp)); set => WriteHere(nameof(Rbp), value); }

        [Offset(168UL)]
        public ulong Rsi { get => ReadHere<ulong>(nameof(Rsi)); set => WriteHere(nameof(Rsi), value); }

        [Offset(176UL)]
        public ulong Rdi { get => ReadHere<ulong>(nameof(Rdi)); set => WriteHere(nameof(Rdi), value); }

        [Offset(184UL)]
        public ulong R8 { get => ReadHere<ulong>(nameof(R8)); set => WriteHere(nameof(R8), value); }

        [Offset(192UL)]
        public ulong R9 { get => ReadHere<ulong>(nameof(R9)); set => WriteHere(nameof(R9), value); }

        [Offset(200UL)]
        public ulong R10 { get => ReadHere<ulong>(nameof(R10)); set => WriteHere(nameof(R10), value); }

        [Offset(208UL)]
        public ulong R11 { get => ReadHere<ulong>(nameof(R11)); set => WriteHere(nameof(R11), value); }

        [Offset(216UL)]
        public ulong R12 { get => ReadHere<ulong>(nameof(R12)); set => WriteHere(nameof(R12), value); }

        [Offset(224UL)]
        public ulong R13 { get => ReadHere<ulong>(nameof(R13)); set => WriteHere(nameof(R13), value); }

        [Offset(232UL)]
        public ulong R14 { get => ReadHere<ulong>(nameof(R14)); set => WriteHere(nameof(R14), value); }

        [Offset(240UL)]
        public ulong R15 { get => ReadHere<ulong>(nameof(R15)); set => WriteHere(nameof(R15), value); }

        [Offset(248UL)]
        public ulong Rip { get => ReadHere<ulong>(nameof(Rip)); set => WriteHere(nameof(Rip), value); }

        [Offset(256UL)]
        public XsaveFormat FltSave { get => ReadStructure<XsaveFormat>(nameof(FltSave)); set => WriteStructure(nameof(FltSave), value); }

        [Offset(256UL)]
        [Length(2)]
        public DynamicArray Header { get => ReadStructure<DynamicArray>(nameof(Header)); set => WriteStructure(nameof(Header), value); }

        [Offset(288UL)]
        [Length(8)]
        public DynamicArray Legacy { get => ReadStructure<DynamicArray>(nameof(Legacy)); set => WriteStructure(nameof(Legacy), value); }

        [Offset(416UL)]
        public M128A Xmm0 { get => ReadStructure<M128A>(nameof(Xmm0)); set => WriteStructure(nameof(Xmm0), value); }

        [Offset(432UL)]
        public M128A Xmm1 { get => ReadStructure<M128A>(nameof(Xmm1)); set => WriteStructure(nameof(Xmm1), value); }

        [Offset(448UL)]
        public M128A Xmm2 { get => ReadStructure<M128A>(nameof(Xmm2)); set => WriteStructure(nameof(Xmm2), value); }

        [Offset(464UL)]
        public M128A Xmm3 { get => ReadStructure<M128A>(nameof(Xmm3)); set => WriteStructure(nameof(Xmm3), value); }

        [Offset(480UL)]
        public M128A Xmm4 { get => ReadStructure<M128A>(nameof(Xmm4)); set => WriteStructure(nameof(Xmm4), value); }

        [Offset(496UL)]
        public M128A Xmm5 { get => ReadStructure<M128A>(nameof(Xmm5)); set => WriteStructure(nameof(Xmm5), value); }

        [Offset(512UL)]
        public M128A Xmm6 { get => ReadStructure<M128A>(nameof(Xmm6)); set => WriteStructure(nameof(Xmm6), value); }

        [Offset(528UL)]
        public M128A Xmm7 { get => ReadStructure<M128A>(nameof(Xmm7)); set => WriteStructure(nameof(Xmm7), value); }

        [Offset(544UL)]
        public M128A Xmm8 { get => ReadStructure<M128A>(nameof(Xmm8)); set => WriteStructure(nameof(Xmm8), value); }

        [Offset(560UL)]
        public M128A Xmm9 { get => ReadStructure<M128A>(nameof(Xmm9)); set => WriteStructure(nameof(Xmm9), value); }

        [Offset(576UL)]
        public M128A Xmm10 { get => ReadStructure<M128A>(nameof(Xmm10)); set => WriteStructure(nameof(Xmm10), value); }

        [Offset(592UL)]
        public M128A Xmm11 { get => ReadStructure<M128A>(nameof(Xmm11)); set => WriteStructure(nameof(Xmm11), value); }

        [Offset(608UL)]
        public M128A Xmm12 { get => ReadStructure<M128A>(nameof(Xmm12)); set => WriteStructure(nameof(Xmm12), value); }

        [Offset(624UL)]
        public M128A Xmm13 { get => ReadStructure<M128A>(nameof(Xmm13)); set => WriteStructure(nameof(Xmm13), value); }

        [Offset(640UL)]
        public M128A Xmm14 { get => ReadStructure<M128A>(nameof(Xmm14)); set => WriteStructure(nameof(Xmm14), value); }

        [Offset(656UL)]
        public M128A Xmm15 { get => ReadStructure<M128A>(nameof(Xmm15)); set => WriteStructure(nameof(Xmm15), value); }

        [Offset(768UL)]
        [Length(26)]
        public DynamicArray VectorRegister { get => ReadStructure<DynamicArray>(nameof(VectorRegister)); set => WriteStructure(nameof(VectorRegister), value); }

        [Offset(1184UL)]
        public ulong VectorControl { get => ReadHere<ulong>(nameof(VectorControl)); set => WriteHere(nameof(VectorControl), value); }

        [Offset(1192UL)]
        public ulong DebugControl { get => ReadHere<ulong>(nameof(DebugControl)); set => WriteHere(nameof(DebugControl), value); }

        [Offset(1200UL)]
        public ulong LastBranchToRip { get => ReadHere<ulong>(nameof(LastBranchToRip)); set => WriteHere(nameof(LastBranchToRip), value); }

        [Offset(1208UL)]
        public ulong LastBranchFromRip { get => ReadHere<ulong>(nameof(LastBranchFromRip)); set => WriteHere(nameof(LastBranchFromRip), value); }

        [Offset(1216UL)]
        public ulong LastExceptionToRip { get => ReadHere<ulong>(nameof(LastExceptionToRip)); set => WriteHere(nameof(LastExceptionToRip), value); }

        [Offset(1224UL)]
        public ulong LastExceptionFromRip { get => ReadHere<ulong>(nameof(LastExceptionFromRip)); set => WriteHere(nameof(LastExceptionFromRip), value); }

        public Context(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Context>();
        }
    }
}