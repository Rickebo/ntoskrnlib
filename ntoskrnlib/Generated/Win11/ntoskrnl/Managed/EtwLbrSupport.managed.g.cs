using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_LBR_SUPPORT")]
    public sealed class EtwLbrSupport : DynamicStructure
    {
        [Offset(0UL)]
        public uint LbrHandle { get => ReadHere<uint>(nameof(LbrHandle)); set => WriteHere(nameof(LbrHandle), value); }

        [Offset(4UL)]
        public uint LbrOptions { get => ReadHere<uint>(nameof(LbrOptions)); set => WriteHere(nameof(LbrOptions), value); }

        [Offset(8UL)]
        public uint HookIdCount { get => ReadHere<uint>(nameof(HookIdCount)); set => WriteHere(nameof(HookIdCount), value); }

        [Offset(12UL)]
        [Length(4)]
        public DynamicArray HookId { get => ReadStructure<DynamicArray>(nameof(HookId)); set => WriteStructure(nameof(HookId), value); }

        public EtwLbrSupport(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwLbrSupport>();
        }
    }
}