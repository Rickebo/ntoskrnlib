using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_KEY_REFERENCE")]
    public sealed class CmKeyReference : DynamicStructure
    {
        [Offset(0UL)]
        public uint KeyCell { get => ReadHere<uint>(nameof(KeyCell)); set => WriteHere(nameof(KeyCell), value); }

        [Offset(8UL)]
        public IntPtr KeyHive { get => ReadHere<IntPtr>(nameof(KeyHive)); set => WriteHere(nameof(KeyHive), value); }

        public CmKeyReference(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmKeyReference>();
        }
    }
}