using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMWSL_INSTANCE")]
    public sealed class MmwslInstance : DynamicStructure
    {
        [Offset(0UL)]
        [Length(3)]
        public DynamicArray PteResumePoint { get => ReadStructure<DynamicArray>(nameof(PteResumePoint)); set => WriteStructure(nameof(PteResumePoint), value); }

        [Offset(24UL)]
        public uint LastAccessClearingRemainder { get => ReadHere<uint>(nameof(LastAccessClearingRemainder)); set => WriteHere(nameof(LastAccessClearingRemainder), value); }

        [Offset(28UL)]
        public uint LastAgingRemainder { get => ReadHere<uint>(nameof(LastAgingRemainder)); set => WriteHere(nameof(LastAgingRemainder), value); }

        [Offset(32UL)]
        public ulong LockedEntries { get => ReadHere<ulong>(nameof(LockedEntries)); set => WriteHere(nameof(LockedEntries), value); }

        [Offset(64UL)]
        [Length(8)]
        public DynamicArray ActivePageTableLinks { get => ReadStructure<DynamicArray>(nameof(ActivePageTableLinks)); set => WriteStructure(nameof(ActivePageTableLinks), value); }

        public MmwslInstance(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmwslInstance>();
        }
    }
}