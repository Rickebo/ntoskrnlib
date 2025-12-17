using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMVAD_FLAGS")]
    public sealed class MmvadFlags : DynamicStructure
    {
        [Offset(0UL)]
        public uint Lock { get => ReadHere<uint>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(0UL)]
        public uint LockContended { get => ReadHere<uint>(nameof(LockContended)); set => WriteHere(nameof(LockContended), value); }

        [Offset(0UL)]
        public uint DeleteInProgress { get => ReadHere<uint>(nameof(DeleteInProgress)); set => WriteHere(nameof(DeleteInProgress), value); }

        [Offset(0UL)]
        public uint NoChange { get => ReadHere<uint>(nameof(NoChange)); set => WriteHere(nameof(NoChange), value); }

        [Offset(0UL)]
        public uint VadType { get => ReadHere<uint>(nameof(VadType)); set => WriteHere(nameof(VadType), value); }

        [Offset(0UL)]
        public uint Protection { get => ReadHere<uint>(nameof(Protection)); set => WriteHere(nameof(Protection), value); }

        [Offset(0UL)]
        public uint PreferredNode { get => ReadHere<uint>(nameof(PreferredNode)); set => WriteHere(nameof(PreferredNode), value); }

        [Offset(0UL)]
        public uint PageSize { get => ReadHere<uint>(nameof(PageSize)); set => WriteHere(nameof(PageSize), value); }

        [Offset(0UL)]
        public uint PrivateMemory { get => ReadHere<uint>(nameof(PrivateMemory)); set => WriteHere(nameof(PrivateMemory), value); }

        [Offset(0UL)]
        public uint EntireField { get => ReadHere<uint>(nameof(EntireField)); set => WriteHere(nameof(EntireField), value); }

        public MmvadFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmvadFlags>();
        }
    }
}