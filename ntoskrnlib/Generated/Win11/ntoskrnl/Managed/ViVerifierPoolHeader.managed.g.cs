using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VI_VERIFIER_POOL_HEADER")]
    public sealed class ViVerifierPoolHeader : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr VerifierPoolEntry { get => ReadHere<IntPtr>(nameof(VerifierPoolEntry)); set => WriteHere(nameof(VerifierPoolEntry), value); }

        public ViVerifierPoolHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ViVerifierPoolHeader>();
        }
    }
}