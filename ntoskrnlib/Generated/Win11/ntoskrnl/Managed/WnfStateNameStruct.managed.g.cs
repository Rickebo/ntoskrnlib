using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WNF_STATE_NAME_STRUCT")]
    public sealed class WnfStateNameStruct : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Version { get => ReadHere<ulong>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(0UL)]
        public ulong NameLifetime { get => ReadHere<ulong>(nameof(NameLifetime)); set => WriteHere(nameof(NameLifetime), value); }

        [Offset(0UL)]
        public ulong DataScope { get => ReadHere<ulong>(nameof(DataScope)); set => WriteHere(nameof(DataScope), value); }

        [Offset(0UL)]
        public ulong PermanentData { get => ReadHere<ulong>(nameof(PermanentData)); set => WriteHere(nameof(PermanentData), value); }

        [Offset(0UL)]
        public ulong Sequence { get => ReadHere<ulong>(nameof(Sequence)); set => WriteHere(nameof(Sequence), value); }

        public WnfStateNameStruct(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WnfStateNameStruct>();
        }
    }
}