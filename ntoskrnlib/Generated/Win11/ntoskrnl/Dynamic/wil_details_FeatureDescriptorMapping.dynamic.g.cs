using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!wil_details_FeatureDescriptorMapping")]
    public sealed class wil_details_FeatureDescriptorMapping : DynamicStructure
    {
        public uint featureId { get; }
        public IntPtr descriptor { get; }

        public wil_details_FeatureDescriptorMapping(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static wil_details_FeatureDescriptorMapping()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(wil_details_FeatureDescriptorMapping.featureId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_FeatureDescriptorMapping.descriptor),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<wil_details_FeatureDescriptorMapping>((mem, ptr) => new wil_details_FeatureDescriptorMapping(mem, ptr), offsets);
        }
    }
}