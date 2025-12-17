using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_BOOT_ENTROPY_LDR_RESULT")]
    public sealed class BootEntropyLdrResult : DynamicStructure
    {
        [Offset(0UL)]
        public uint maxEntropySources { get => ReadHere<uint>(nameof(maxEntropySources)); set => WriteHere(nameof(maxEntropySources), value); }

        [Offset(8UL)]
        [Length(10)]
        public DynamicArray EntropySourceResult { get => ReadStructure<DynamicArray>(nameof(EntropySourceResult)); set => WriteStructure(nameof(EntropySourceResult), value); }

        [Offset(1048UL)]
        [Length(48)]
        public DynamicArray SeedBytesForCng { get => ReadStructure<DynamicArray>(nameof(SeedBytesForCng)); set => WriteStructure(nameof(SeedBytesForCng), value); }

        [Offset(1096UL)]
        [Length(1024)]
        public DynamicArray RngBytesForNtoskrnl { get => ReadStructure<DynamicArray>(nameof(RngBytesForNtoskrnl)); set => WriteStructure(nameof(RngBytesForNtoskrnl), value); }

        [Offset(2120UL)]
        [Length(32)]
        public DynamicArray KdEntropy { get => ReadStructure<DynamicArray>(nameof(KdEntropy)); set => WriteStructure(nameof(KdEntropy), value); }

        public BootEntropyLdrResult(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<BootEntropyLdrResult>();
        }
    }
}