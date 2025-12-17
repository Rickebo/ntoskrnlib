using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PCW_CALLBACK_INFORMATION")]
    public sealed class PcwCallbackInformation : DynamicStructure
    {
        [Offset(0UL)]
        public PcwCounterInformation AddCounter { get => ReadStructure<PcwCounterInformation>(nameof(AddCounter)); set => WriteStructure(nameof(AddCounter), value); }

        [Offset(0UL)]
        public PcwCounterInformation RemoveCounter { get => ReadStructure<PcwCounterInformation>(nameof(RemoveCounter)); set => WriteStructure(nameof(RemoveCounter), value); }

        [Offset(0UL)]
        public PcwMaskInformation EnumerateInstances { get => ReadStructure<PcwMaskInformation>(nameof(EnumerateInstances)); set => WriteStructure(nameof(EnumerateInstances), value); }

        [Offset(0UL)]
        public PcwMaskInformation CollectData { get => ReadStructure<PcwMaskInformation>(nameof(CollectData)); set => WriteStructure(nameof(CollectData), value); }

        public PcwCallbackInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PcwCallbackInformation>();
        }
    }
}