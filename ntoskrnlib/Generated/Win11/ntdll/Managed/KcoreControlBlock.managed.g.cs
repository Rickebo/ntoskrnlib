using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KCORE_CONTROL_BLOCK")]
    public sealed class KcoreControlBlock : DynamicStructure
    {
        [Offset(0UL)]
        public byte ProcessorCount { get => ReadHere<byte>(nameof(ProcessorCount)); set => WriteHere(nameof(ProcessorCount), value); }

        [Offset(1UL)]
        public byte ScanStartIndex { get => ReadHere<byte>(nameof(ScanStartIndex)); set => WriteHere(nameof(ScanStartIndex), value); }

        [Offset(2UL)]
        [Length(6)]
        public DynamicArray Spare { get => ReadStructure<DynamicArray>(nameof(Spare)); set => WriteStructure(nameof(Spare), value); }

        [Offset(8UL)]
        [Length(4)]
        public DynamicArray Prcbs { get => ReadStructure<DynamicArray>(nameof(Prcbs)); set => WriteStructure(nameof(Prcbs), value); }

        [Offset(40UL)]
        public IntPtr CoreControlBlockShadow { get => ReadHere<IntPtr>(nameof(CoreControlBlockShadow)); set => WriteHere(nameof(CoreControlBlockShadow), value); }

        public KcoreControlBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KcoreControlBlock>();
        }
    }
}