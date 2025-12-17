using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ECP_LIST")]
    public sealed class EcpList : DynamicStructure
    {
        [Offset(0UL)]
        public uint Signature { get => ReadHere<uint>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(4UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(8UL)]
        public ListEntry BaseEcpList { get => ReadStructure<ListEntry>(nameof(BaseEcpList)); set => WriteStructure(nameof(BaseEcpList), value); }

        public EcpList(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EcpList>();
        }
    }
}