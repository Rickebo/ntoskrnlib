using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_GENERIC_MAPPING")]
    public sealed class GenericMapping : DynamicStructure
    {
        [Offset(0UL)]
        public uint GenericRead { get => ReadHere<uint>(nameof(GenericRead)); set => WriteHere(nameof(GenericRead), value); }

        [Offset(4UL)]
        public uint GenericWrite { get => ReadHere<uint>(nameof(GenericWrite)); set => WriteHere(nameof(GenericWrite), value); }

        [Offset(8UL)]
        public uint GenericExecute { get => ReadHere<uint>(nameof(GenericExecute)); set => WriteHere(nameof(GenericExecute), value); }

        [Offset(12UL)]
        public uint GenericAll { get => ReadHere<uint>(nameof(GenericAll)); set => WriteHere(nameof(GenericAll), value); }

        public GenericMapping(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<GenericMapping>();
        }
    }
}