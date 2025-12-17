using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KAB_UM_PROCESS_CONTEXT")]
    public sealed class KabUmProcessContext : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Trees { get => ReadHere<IntPtr>(nameof(Trees)); set => WriteHere(nameof(Trees), value); }

        [Offset(8UL)]
        public uint TreeCount { get => ReadHere<uint>(nameof(TreeCount)); set => WriteHere(nameof(TreeCount), value); }

        public KabUmProcessContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KabUmProcessContext>();
        }
    }
}