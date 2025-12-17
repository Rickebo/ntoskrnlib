using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_FUNCTION_OVERRIDE_CAPABILITIES")]
    public sealed class _RTL_FUNCTION_OVERRIDE_CAPABILITIES : DynamicStructure
    {
        public byte[] AMD64Capabilities { get; }
        public byte[] AMD64KernelCapabilities { get; }

        public _RTL_FUNCTION_OVERRIDE_CAPABILITIES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_FUNCTION_OVERRIDE_CAPABILITIES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_FUNCTION_OVERRIDE_CAPABILITIES.AMD64Capabilities),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_FUNCTION_OVERRIDE_CAPABILITIES.AMD64KernelCapabilities),
                    new ulong[]
                    {
                        45UL
                    }
                }
            };
            Register<_RTL_FUNCTION_OVERRIDE_CAPABILITIES>((mem, ptr) => new _RTL_FUNCTION_OVERRIDE_CAPABILITIES(mem, ptr), offsets);
        }
    }
}