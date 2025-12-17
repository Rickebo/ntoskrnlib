using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CLIENT_ID32")]
    public sealed class ClientID32 : DynamicStructure
    {
        [Offset(0UL)]
        public uint UniqueProcess { get => ReadHere<uint>(nameof(UniqueProcess)); set => WriteHere(nameof(UniqueProcess), value); }

        [Offset(4UL)]
        public uint UniqueThread { get => ReadHere<uint>(nameof(UniqueThread)); set => WriteHere(nameof(UniqueThread), value); }

        public ClientID32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ClientID32>();
        }
    }
}