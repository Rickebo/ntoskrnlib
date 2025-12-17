using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_IO_CLIENT_EXTENSION")]
    public sealed class IoClientExtension : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr NextExtension { get => ReadHere<IntPtr>(nameof(NextExtension)); set => WriteHere(nameof(NextExtension), value); }

        [Offset(8UL)]
        public IntPtr ClientIdentificationAddress { get => ReadHere<IntPtr>(nameof(ClientIdentificationAddress)); set => WriteHere(nameof(ClientIdentificationAddress), value); }

        public IoClientExtension(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IoClientExtension>();
        }
    }
}