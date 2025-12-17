using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!wil_details_FeatureDescriptorMapping")]
    public sealed class WilDetailsFeatureDescriptorMapping : DynamicStructure
    {
        [Offset(0UL)]
        public uint featureId { get => ReadHere<uint>(nameof(featureId)); set => WriteHere(nameof(featureId), value); }

        [Offset(8UL)]
        public IntPtr descriptor { get => ReadHere<IntPtr>(nameof(descriptor)); set => WriteHere(nameof(descriptor), value); }

        public WilDetailsFeatureDescriptorMapping(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WilDetailsFeatureDescriptorMapping>();
        }
    }
}