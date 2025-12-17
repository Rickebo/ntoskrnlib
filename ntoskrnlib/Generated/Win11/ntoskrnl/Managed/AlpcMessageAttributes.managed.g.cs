using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ALPC_MESSAGE_ATTRIBUTES")]
    public sealed class AlpcMessageAttributes : DynamicStructure
    {
        [Offset(0UL)]
        public uint AllocatedAttributes { get => ReadHere<uint>(nameof(AllocatedAttributes)); set => WriteHere(nameof(AllocatedAttributes), value); }

        [Offset(4UL)]
        public uint ValidAttributes { get => ReadHere<uint>(nameof(ValidAttributes)); set => WriteHere(nameof(ValidAttributes), value); }

        public AlpcMessageAttributes(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<AlpcMessageAttributes>();
        }
    }
}