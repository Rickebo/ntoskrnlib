using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_KEY_HASH")]
    public sealed class CmKeyHash : DynamicStructure
    {
        [Offset(0UL)]
        public CmPathHash ConvKey { get => ReadStructure<CmPathHash>(nameof(ConvKey)); set => WriteStructure(nameof(ConvKey), value); }

        [Offset(8UL)]
        public IntPtr NextHash { get => ReadHere<IntPtr>(nameof(NextHash)); set => WriteHere(nameof(NextHash), value); }

        [Offset(16UL)]
        public IntPtr KeyHive { get => ReadHere<IntPtr>(nameof(KeyHive)); set => WriteHere(nameof(KeyHive), value); }

        [Offset(24UL)]
        public uint KeyCell { get => ReadHere<uint>(nameof(KeyCell)); set => WriteHere(nameof(KeyCell), value); }

        public CmKeyHash(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmKeyHash>();
        }
    }
}