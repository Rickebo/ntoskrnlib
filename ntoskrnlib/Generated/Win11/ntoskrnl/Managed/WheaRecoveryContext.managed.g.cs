using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEA_RECOVERY_CONTEXT")]
    public sealed class WheaRecoveryContext : DynamicStructure
    {
        [Offset(0UL)]
        public UnnamedTag MemoryError { get => ReadStructure<UnnamedTag>(nameof(MemoryError)); set => WriteStructure(nameof(MemoryError), value); }

        [Offset(0UL)]
        public UnnamedTag PmemError { get => ReadStructure<UnnamedTag>(nameof(PmemError)); set => WriteStructure(nameof(PmemError), value); }

        [Offset(16UL)]
        public ulong PartitionId { get => ReadHere<ulong>(nameof(PartitionId)); set => WriteHere(nameof(PartitionId), value); }

        [Offset(24UL)]
        public uint VpIndex { get => ReadHere<uint>(nameof(VpIndex)); set => WriteHere(nameof(VpIndex), value); }

        [Offset(28UL)]
        public uint ErrorType { get => ReadHere<uint>(nameof(ErrorType)); set => WriteHere(nameof(ErrorType), value); }

        [Offset(32UL)]
        public uint PageCount { get => ReadHere<uint>(nameof(PageCount)); set => WriteHere(nameof(PageCount), value); }

        [Offset(36UL)]
        [Length(256)]
        public DynamicArray PageInfo { get => ReadStructure<DynamicArray>(nameof(PageInfo)); set => WriteStructure(nameof(PageInfo), value); }

        public WheaRecoveryContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaRecoveryContext>();
        }
    }
}