using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KIST_LINK_FRAME")]
    public sealed class KistLinkFrame : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr IstBaseFrame { get => ReadHere<IntPtr>(nameof(IstBaseFrame)); set => WriteHere(nameof(IstBaseFrame), value); }

        [Offset(8UL)]
        public uint Signature { get => ReadHere<uint>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(12UL)]
        public uint Reserved0 { get => ReadHere<uint>(nameof(Reserved0)); set => WriteHere(nameof(Reserved0), value); }

        [Offset(16UL)]
        [Length(2)]
        public DynamicArray Reserved { get => ReadStructure<DynamicArray>(nameof(Reserved)); set => WriteStructure(nameof(Reserved), value); }

        public KistLinkFrame(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KistLinkFrame>();
        }
    }
}