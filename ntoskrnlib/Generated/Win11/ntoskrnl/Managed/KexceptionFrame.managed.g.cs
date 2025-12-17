using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KEXCEPTION_FRAME")]
    public sealed class KexceptionFrame : DynamicStructure
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
        public ulong Spare1 { get => ReadHere<ulong>(nameof(Spare1)); set => WriteHere(nameof(Spare1), value); }

        [Offset(48UL)]
        public M128A Xmm6 { get => ReadStructure<M128A>(nameof(Xmm6)); set => WriteStructure(nameof(Xmm6), value); }

        [Offset(64UL)]
        public M128A Xmm7 { get => ReadStructure<M128A>(nameof(Xmm7)); set => WriteStructure(nameof(Xmm7), value); }

        [Offset(80UL)]
        public M128A Xmm8 { get => ReadStructure<M128A>(nameof(Xmm8)); set => WriteStructure(nameof(Xmm8), value); }

        [Offset(96UL)]
        public M128A Xmm9 { get => ReadStructure<M128A>(nameof(Xmm9)); set => WriteStructure(nameof(Xmm9), value); }

        [Offset(112UL)]
        public M128A Xmm10 { get => ReadStructure<M128A>(nameof(Xmm10)); set => WriteStructure(nameof(Xmm10), value); }

        [Offset(128UL)]
        public M128A Xmm11 { get => ReadStructure<M128A>(nameof(Xmm11)); set => WriteStructure(nameof(Xmm11), value); }

        [Offset(144UL)]
        public M128A Xmm12 { get => ReadStructure<M128A>(nameof(Xmm12)); set => WriteStructure(nameof(Xmm12), value); }

        [Offset(160UL)]
        public M128A Xmm13 { get => ReadStructure<M128A>(nameof(Xmm13)); set => WriteStructure(nameof(Xmm13), value); }

        [Offset(176UL)]
        public M128A Xmm14 { get => ReadStructure<M128A>(nameof(Xmm14)); set => WriteStructure(nameof(Xmm14), value); }

        [Offset(192UL)]
        public M128A Xmm15 { get => ReadStructure<M128A>(nameof(Xmm15)); set => WriteStructure(nameof(Xmm15), value); }

        [Offset(208UL)]
        public ulong TrapFrame { get => ReadHere<ulong>(nameof(TrapFrame)); set => WriteHere(nameof(TrapFrame), value); }

        [Offset(216UL)]
        public ulong OutputBuffer { get => ReadHere<ulong>(nameof(OutputBuffer)); set => WriteHere(nameof(OutputBuffer), value); }

        [Offset(224UL)]
        public ulong OutputLength { get => ReadHere<ulong>(nameof(OutputLength)); set => WriteHere(nameof(OutputLength), value); }

        [Offset(232UL)]
        public ulong Spare2 { get => ReadHere<ulong>(nameof(Spare2)); set => WriteHere(nameof(Spare2), value); }

        [Offset(240UL)]
        public ulong MxCsr { get => ReadHere<ulong>(nameof(MxCsr)); set => WriteHere(nameof(MxCsr), value); }

        [Offset(248UL)]
        public ulong Rbp { get => ReadHere<ulong>(nameof(Rbp)); set => WriteHere(nameof(Rbp), value); }

        [Offset(256UL)]
        public ulong Rbx { get => ReadHere<ulong>(nameof(Rbx)); set => WriteHere(nameof(Rbx), value); }

        [Offset(264UL)]
        public ulong Rdi { get => ReadHere<ulong>(nameof(Rdi)); set => WriteHere(nameof(Rdi), value); }

        [Offset(272UL)]
        public ulong Rsi { get => ReadHere<ulong>(nameof(Rsi)); set => WriteHere(nameof(Rsi), value); }

        [Offset(280UL)]
        public ulong R12 { get => ReadHere<ulong>(nameof(R12)); set => WriteHere(nameof(R12), value); }

        [Offset(288UL)]
        public ulong R13 { get => ReadHere<ulong>(nameof(R13)); set => WriteHere(nameof(R13), value); }

        [Offset(296UL)]
        public ulong R14 { get => ReadHere<ulong>(nameof(R14)); set => WriteHere(nameof(R14), value); }

        [Offset(304UL)]
        public ulong R15 { get => ReadHere<ulong>(nameof(R15)); set => WriteHere(nameof(R15), value); }

        [Offset(312UL)]
        public ulong Return { get => ReadHere<ulong>(nameof(Return)); set => WriteHere(nameof(Return), value); }

        public KexceptionFrame(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KexceptionFrame>();
        }
    }
}