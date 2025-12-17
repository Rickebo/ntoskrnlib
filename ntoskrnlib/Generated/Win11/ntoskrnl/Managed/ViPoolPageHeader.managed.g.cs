using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VI_POOL_PAGE_HEADER")]
    public sealed class ViPoolPageHeader : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr NextPage { get => ReadHere<IntPtr>(nameof(NextPage)); set => WriteHere(nameof(NextPage), value); }

        [Offset(8UL)]
        public IntPtr VerifierEntry { get => ReadHere<IntPtr>(nameof(VerifierEntry)); set => WriteHere(nameof(VerifierEntry), value); }

        [Offset(16UL)]
        public ulong Signature { get => ReadHere<ulong>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        public ViPoolPageHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ViPoolPageHeader>();
        }
    }
}