using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_DBG_PATCH")]
    public sealed class MiDbgPatch : DynamicStructure
    {
        [Offset(0UL)]
        public UnnamedTag u1 { get => ReadStructure<UnnamedTag>(nameof(u1)); set => WriteStructure(nameof(u1), value); }

        [Offset(8UL)]
        public UnnamedTag u2 { get => ReadStructure<UnnamedTag>(nameof(u2)); set => WriteStructure(nameof(u2), value); }

        [Offset(12UL)]
        public uint OriginalBytes { get => ReadHere<uint>(nameof(OriginalBytes)); set => WriteHere(nameof(OriginalBytes), value); }

        [Offset(16UL)]
        public uint NewBytes { get => ReadHere<uint>(nameof(NewBytes)); set => WriteHere(nameof(NewBytes), value); }

        [Offset(20UL)]
        public uint Padding { get => ReadHere<uint>(nameof(Padding)); set => WriteHere(nameof(Padding), value); }

        public MiDbgPatch(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiDbgPatch>();
        }
    }
}