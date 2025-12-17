using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KFLOATING_SAVE")]
    public sealed class KfloatingSave : DynamicStructure
    {
        [Offset(0UL)]
        public uint Dummy { get => ReadHere<uint>(nameof(Dummy)); set => WriteHere(nameof(Dummy), value); }

        public KfloatingSave(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KfloatingSave>();
        }
    }
}