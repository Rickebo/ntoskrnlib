using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMPAGE_FILE_EXPANSION_FLAGS")]
    public sealed class MmpageFileExpansionFlags : DynamicStructure
    {
        [Offset(0UL)]
        public byte PageFileNumber { get => ReadHere<byte>(nameof(PageFileNumber)); set => WriteHere(nameof(PageFileNumber), value); }

        [Offset(1UL)]
        public byte Spare1 { get => ReadHere<byte>(nameof(Spare1)); set => WriteHere(nameof(Spare1), value); }

        [Offset(2UL)]
        public byte Spare2 { get => ReadHere<byte>(nameof(Spare2)); set => WriteHere(nameof(Spare2), value); }

        [Offset(3UL)]
        public byte IgnoreCurrentCommit { get => ReadHere<byte>(nameof(IgnoreCurrentCommit)); set => WriteHere(nameof(IgnoreCurrentCommit), value); }

        [Offset(3UL)]
        public byte IncreaseMinimumSize { get => ReadHere<byte>(nameof(IncreaseMinimumSize)); set => WriteHere(nameof(IncreaseMinimumSize), value); }

        [Offset(3UL)]
        public byte AttemptForCantExtend { get => ReadHere<byte>(nameof(AttemptForCantExtend)); set => WriteHere(nameof(AttemptForCantExtend), value); }

        [Offset(3UL)]
        public byte UnusedSegmentDeletion { get => ReadHere<byte>(nameof(UnusedSegmentDeletion)); set => WriteHere(nameof(UnusedSegmentDeletion), value); }

        [Offset(3UL)]
        public byte PageFileContract { get => ReadHere<byte>(nameof(PageFileContract)); set => WriteHere(nameof(PageFileContract), value); }

        [Offset(3UL)]
        public byte NoWait { get => ReadHere<byte>(nameof(NoWait)); set => WriteHere(nameof(NoWait), value); }

        [Offset(3UL)]
        public byte BeingProcessed { get => ReadHere<byte>(nameof(BeingProcessed)); set => WriteHere(nameof(BeingProcessed), value); }

        [Offset(3UL)]
        public byte Spare3 { get => ReadHere<byte>(nameof(Spare3)); set => WriteHere(nameof(Spare3), value); }

        public MmpageFileExpansionFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmpageFileExpansionFlags>();
        }
    }
}