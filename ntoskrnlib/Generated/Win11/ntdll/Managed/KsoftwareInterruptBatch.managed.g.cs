using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KSOFTWARE_INTERRUPT_BATCH")]
    public sealed class KsoftwareInterruptBatch : DynamicStructure
    {
        [Offset(0UL)]
        public byte Level { get => ReadHere<byte>(nameof(Level)); set => WriteHere(nameof(Level), value); }

        [Offset(1UL)]
        public byte TargetType { get => ReadHere<byte>(nameof(TargetType)); set => WriteHere(nameof(TargetType), value); }

        [Offset(2UL)]
        public byte ReservedBatchInProgress { get => ReadHere<byte>(nameof(ReservedBatchInProgress)); set => WriteHere(nameof(ReservedBatchInProgress), value); }

        [Offset(3UL)]
        public byte Spare { get => ReadHere<byte>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(4UL)]
        public uint SingleTargetIndex { get => ReadHere<uint>(nameof(SingleTargetIndex)); set => WriteHere(nameof(SingleTargetIndex), value); }

        [Offset(8UL)]
        public KaffinityEx MultipleTargetAffinity { get => ReadStructure<KaffinityEx>(nameof(MultipleTargetAffinity)); set => WriteStructure(nameof(MultipleTargetAffinity), value); }

        [Offset(272UL)]
        [Length(32)]
        public DynamicArray Padding { get => ReadStructure<DynamicArray>(nameof(Padding)); set => WriteStructure(nameof(Padding), value); }

        public KsoftwareInterruptBatch(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KsoftwareInterruptBatch>();
        }
    }
}