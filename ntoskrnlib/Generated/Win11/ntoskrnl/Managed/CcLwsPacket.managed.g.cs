using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CC_LWS_PACKET")]
    public sealed class CcLwsPacket : DynamicStructure
    {
        [Offset(0UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(4UL)]
        public byte Active { get => ReadHere<byte>(nameof(Active)); set => WriteHere(nameof(Active), value); }

        [Offset(8UL)]
        public UnnamedTag Overlay { get => ReadStructure<UnnamedTag>(nameof(Overlay)); set => WriteStructure(nameof(Overlay), value); }

        public CcLwsPacket(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CcLwsPacket>();
        }
    }
}