using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ARBITER_QUERY_ALLOCATED_RESOURCES_PARAMETERS")]
    public sealed class ArbiterQueryAllocatedResourcesParameters : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr AllocatedResources { get => ReadHere<IntPtr>(nameof(AllocatedResources)); set => WriteHere(nameof(AllocatedResources), value); }

        public ArbiterQueryAllocatedResourcesParameters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ArbiterQueryAllocatedResourcesParameters>();
        }
    }
}