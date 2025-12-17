using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_CLIENT_ID64")]
    public sealed class ClientID64 : DynamicStructure
    {
        [Offset(0UL)]
        public ulong UniqueProcess { get => ReadHere<ulong>(nameof(UniqueProcess)); set => WriteHere(nameof(UniqueProcess), value); }

        [Offset(8UL)]
        public ulong UniqueThread { get => ReadHere<ulong>(nameof(UniqueThread)); set => WriteHere(nameof(UniqueThread), value); }

        public ClientID64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ClientID64>();
        }
    }
}