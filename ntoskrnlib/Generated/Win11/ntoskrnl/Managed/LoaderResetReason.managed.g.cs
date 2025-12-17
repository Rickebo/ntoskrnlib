using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_LOADER_RESET_REASON")]
    public sealed class LoaderResetReason : DynamicStructure
    {
        [Offset(0UL)]
        public byte Supplied { get => ReadHere<byte>(nameof(Supplied)); set => WriteHere(nameof(Supplied), value); }

        [Offset(8UL)]
        public UnnamedTag Basic { get => ReadStructure<UnnamedTag>(nameof(Basic)); set => WriteStructure(nameof(Basic), value); }

        [Offset(16UL)]
        [Length(8)]
        public DynamicArray AdditionalInfo { get => ReadStructure<DynamicArray>(nameof(AdditionalInfo)); set => WriteStructure(nameof(AdditionalInfo), value); }

        public LoaderResetReason(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LoaderResetReason>();
        }
    }
}