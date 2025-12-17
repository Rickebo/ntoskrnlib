using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMCLONE_DESCRIPTOR")]
    public sealed class MmcloneDescriptor : DynamicStructure
    {
        [Offset(0UL)]
        public RtlBalancedNode CloneNode { get => ReadStructure<RtlBalancedNode>(nameof(CloneNode)); set => WriteStructure(nameof(CloneNode), value); }

        [Offset(0UL)]
        public IntPtr Next { get => ReadHere<IntPtr>(nameof(Next)); set => WriteHere(nameof(Next), value); }

        [Offset(24UL)]
        public IntPtr StartingCloneBlock { get => ReadHere<IntPtr>(nameof(StartingCloneBlock)); set => WriteHere(nameof(StartingCloneBlock), value); }

        [Offset(32UL)]
        public IntPtr EndingCloneBlock { get => ReadHere<IntPtr>(nameof(EndingCloneBlock)); set => WriteHere(nameof(EndingCloneBlock), value); }

        [Offset(40UL)]
        public ulong NumberOfPtes { get => ReadHere<ulong>(nameof(NumberOfPtes)); set => WriteHere(nameof(NumberOfPtes), value); }

        [Offset(48UL)]
        public ulong NumberOfReferences { get => ReadHere<ulong>(nameof(NumberOfReferences)); set => WriteHere(nameof(NumberOfReferences), value); }

        [Offset(56UL)]
        public IntPtr CloneHeader { get => ReadHere<IntPtr>(nameof(CloneHeader)); set => WriteHere(nameof(CloneHeader), value); }

        [Offset(64UL)]
        public ulong NonPagedPoolQuotaCharge { get => ReadHere<ulong>(nameof(NonPagedPoolQuotaCharge)); set => WriteHere(nameof(NonPagedPoolQuotaCharge), value); }

        [Offset(80UL)]
        public SlistEntry DeleteList { get => ReadStructure<SlistEntry>(nameof(DeleteList)); set => WriteStructure(nameof(DeleteList), value); }

        [Offset(96UL)]
        public ulong NestingLevel { get => ReadHere<ulong>(nameof(NestingLevel)); set => WriteHere(nameof(NestingLevel), value); }

        public MmcloneDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmcloneDescriptor>();
        }
    }
}