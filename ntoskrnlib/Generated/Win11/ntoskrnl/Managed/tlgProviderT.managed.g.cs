using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_tlgProvider_t")]
    public sealed class tlgProviderT : DynamicStructure
    {
        [Offset(0UL)]
        public uint LevelPlus1 { get => ReadHere<uint>(nameof(LevelPlus1)); set => WriteHere(nameof(LevelPlus1), value); }

        [Offset(8UL)]
        public IntPtr ProviderMetadataPtr { get => ReadHere<IntPtr>(nameof(ProviderMetadataPtr)); set => WriteHere(nameof(ProviderMetadataPtr), value); }

        [Offset(16UL)]
        public ulong KeywordAny { get => ReadHere<ulong>(nameof(KeywordAny)); set => WriteHere(nameof(KeywordAny), value); }

        [Offset(24UL)]
        public ulong KeywordAll { get => ReadHere<ulong>(nameof(KeywordAll)); set => WriteHere(nameof(KeywordAll), value); }

        [Offset(32UL)]
        public ulong RegHandle { get => ReadHere<ulong>(nameof(RegHandle)); set => WriteHere(nameof(RegHandle), value); }

        [Offset(40UL)]
        public IntPtr EnableCallback { get => ReadHere<IntPtr>(nameof(EnableCallback)); set => WriteHere(nameof(EnableCallback), value); }

        [Offset(48UL)]
        public IntPtr CallbackContext { get => ReadHere<IntPtr>(nameof(CallbackContext)); set => WriteHere(nameof(CallbackContext), value); }

        public tlgProviderT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<tlgProviderT>();
        }
    }
}