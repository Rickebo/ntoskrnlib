using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_STORE_MODWRITER_EXTENSION")]
    public sealed class MiStoreModwriterExtension : DynamicStructure
    {
        [Offset(0UL)]
        public Kapc WriteCompletionApc { get => ReadStructure<Kapc>(nameof(WriteCompletionApc)); set => WriteStructure(nameof(WriteCompletionApc), value); }

        [Offset(88UL)]
        public uint WriteRefCount { get => ReadHere<uint>(nameof(WriteRefCount)); set => WriteHere(nameof(WriteRefCount), value); }

        [Offset(92UL)]
        public uint PadSpare { get => ReadHere<uint>(nameof(PadSpare)); set => WriteHere(nameof(PadSpare), value); }

        [Offset(96UL)]
        [Length(1)]
        public DynamicArray PagefileInfo { get => ReadStructure<DynamicArray>(nameof(PagefileInfo)); set => WriteStructure(nameof(PagefileInfo), value); }

        public MiStoreModwriterExtension(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiStoreModwriterExtension>();
        }
    }
}