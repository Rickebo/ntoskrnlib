using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_CLIENT_ID")]
    public sealed class ClientId : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr UniqueProcess { get => ReadHere<IntPtr>(nameof(UniqueProcess)); set => WriteHere(nameof(UniqueProcess), value); }

        [Offset(8UL)]
        public IntPtr UniqueThread { get => ReadHere<IntPtr>(nameof(UniqueThread)); set => WriteHere(nameof(UniqueThread), value); }

        public ClientId(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ClientId>();
        }
    }
}