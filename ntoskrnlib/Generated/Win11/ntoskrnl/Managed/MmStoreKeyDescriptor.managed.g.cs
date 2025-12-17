using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MM_STORE_KEY_DESCRIPTOR")]
    public sealed class MmStoreKeyDescriptor : DynamicStructure
    {
        [Offset(0UL)]
        public ulong ContainerKey { get => ReadHere<ulong>(nameof(ContainerKey)); set => WriteHere(nameof(ContainerKey), value); }

        [Offset(8UL)]
        public MmStoreSubKeyDescriptor SubKey { get => ReadStructure<MmStoreSubKeyDescriptor>(nameof(SubKey)); set => WriteStructure(nameof(SubKey), value); }

        public MmStoreKeyDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmStoreKeyDescriptor>();
        }
    }
}