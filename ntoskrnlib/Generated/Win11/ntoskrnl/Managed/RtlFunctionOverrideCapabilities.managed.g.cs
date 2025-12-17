using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTL_FUNCTION_OVERRIDE_CAPABILITIES")]
    public sealed class RtlFunctionOverrideCapabilities : DynamicStructure
    {
        [Offset(0UL)]
        [Length(45)]
        public DynamicArray AMD64Capabilities { get => ReadStructure<DynamicArray>(nameof(AMD64Capabilities)); set => WriteStructure(nameof(AMD64Capabilities), value); }

        [Offset(45UL)]
        [Length(45)]
        public DynamicArray AMD64KernelCapabilities { get => ReadStructure<DynamicArray>(nameof(AMD64KernelCapabilities)); set => WriteStructure(nameof(AMD64KernelCapabilities), value); }

        public RtlFunctionOverrideCapabilities(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlFunctionOverrideCapabilities>();
        }
    }
}