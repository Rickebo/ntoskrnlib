using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KSPECIAL_REGISTERS")]
    public sealed class KspecialRegisters : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Cr0 { get => ReadHere<ulong>(nameof(Cr0)); set => WriteHere(nameof(Cr0), value); }

        [Offset(8UL)]
        public ulong Cr2 { get => ReadHere<ulong>(nameof(Cr2)); set => WriteHere(nameof(Cr2), value); }

        [Offset(16UL)]
        public ulong Cr3 { get => ReadHere<ulong>(nameof(Cr3)); set => WriteHere(nameof(Cr3), value); }

        [Offset(24UL)]
        public ulong Cr4 { get => ReadHere<ulong>(nameof(Cr4)); set => WriteHere(nameof(Cr4), value); }

        [Offset(32UL)]
        public ulong KernelDr0 { get => ReadHere<ulong>(nameof(KernelDr0)); set => WriteHere(nameof(KernelDr0), value); }

        [Offset(40UL)]
        public ulong KernelDr1 { get => ReadHere<ulong>(nameof(KernelDr1)); set => WriteHere(nameof(KernelDr1), value); }

        [Offset(48UL)]
        public ulong KernelDr2 { get => ReadHere<ulong>(nameof(KernelDr2)); set => WriteHere(nameof(KernelDr2), value); }

        [Offset(56UL)]
        public ulong KernelDr3 { get => ReadHere<ulong>(nameof(KernelDr3)); set => WriteHere(nameof(KernelDr3), value); }

        [Offset(64UL)]
        public ulong KernelDr6 { get => ReadHere<ulong>(nameof(KernelDr6)); set => WriteHere(nameof(KernelDr6), value); }

        [Offset(72UL)]
        public ulong KernelDr7 { get => ReadHere<ulong>(nameof(KernelDr7)); set => WriteHere(nameof(KernelDr7), value); }

        [Offset(80UL)]
        public Kdescriptor Gdtr { get => ReadStructure<Kdescriptor>(nameof(Gdtr)); set => WriteStructure(nameof(Gdtr), value); }

        [Offset(96UL)]
        public Kdescriptor Idtr { get => ReadStructure<Kdescriptor>(nameof(Idtr)); set => WriteStructure(nameof(Idtr), value); }

        [Offset(112UL)]
        public ushort Tr { get => ReadHere<ushort>(nameof(Tr)); set => WriteHere(nameof(Tr), value); }

        [Offset(114UL)]
        public ushort Ldtr { get => ReadHere<ushort>(nameof(Ldtr)); set => WriteHere(nameof(Ldtr), value); }

        [Offset(116UL)]
        public uint MxCsr { get => ReadHere<uint>(nameof(MxCsr)); set => WriteHere(nameof(MxCsr), value); }

        [Offset(120UL)]
        public ulong DebugControl { get => ReadHere<ulong>(nameof(DebugControl)); set => WriteHere(nameof(DebugControl), value); }

        [Offset(128UL)]
        public ulong LastBranchToRip { get => ReadHere<ulong>(nameof(LastBranchToRip)); set => WriteHere(nameof(LastBranchToRip), value); }

        [Offset(136UL)]
        public ulong LastBranchFromRip { get => ReadHere<ulong>(nameof(LastBranchFromRip)); set => WriteHere(nameof(LastBranchFromRip), value); }

        [Offset(144UL)]
        public ulong LastExceptionToRip { get => ReadHere<ulong>(nameof(LastExceptionToRip)); set => WriteHere(nameof(LastExceptionToRip), value); }

        [Offset(152UL)]
        public ulong LastExceptionFromRip { get => ReadHere<ulong>(nameof(LastExceptionFromRip)); set => WriteHere(nameof(LastExceptionFromRip), value); }

        [Offset(160UL)]
        public ulong Cr8 { get => ReadHere<ulong>(nameof(Cr8)); set => WriteHere(nameof(Cr8), value); }

        [Offset(168UL)]
        public ulong MsrGsBase { get => ReadHere<ulong>(nameof(MsrGsBase)); set => WriteHere(nameof(MsrGsBase), value); }

        [Offset(176UL)]
        public ulong MsrGsSwap { get => ReadHere<ulong>(nameof(MsrGsSwap)); set => WriteHere(nameof(MsrGsSwap), value); }

        [Offset(184UL)]
        public ulong MsrStar { get => ReadHere<ulong>(nameof(MsrStar)); set => WriteHere(nameof(MsrStar), value); }

        [Offset(192UL)]
        public ulong MsrLStar { get => ReadHere<ulong>(nameof(MsrLStar)); set => WriteHere(nameof(MsrLStar), value); }

        [Offset(200UL)]
        public ulong MsrCStar { get => ReadHere<ulong>(nameof(MsrCStar)); set => WriteHere(nameof(MsrCStar), value); }

        [Offset(208UL)]
        public ulong MsrSyscallMask { get => ReadHere<ulong>(nameof(MsrSyscallMask)); set => WriteHere(nameof(MsrSyscallMask), value); }

        [Offset(216UL)]
        public ulong Xcr0 { get => ReadHere<ulong>(nameof(Xcr0)); set => WriteHere(nameof(Xcr0), value); }

        [Offset(224UL)]
        public ulong MsrFsBase { get => ReadHere<ulong>(nameof(MsrFsBase)); set => WriteHere(nameof(MsrFsBase), value); }

        [Offset(232UL)]
        public ulong SpecialPadding0 { get => ReadHere<ulong>(nameof(SpecialPadding0)); set => WriteHere(nameof(SpecialPadding0), value); }

        public KspecialRegisters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KspecialRegisters>();
        }
    }
}