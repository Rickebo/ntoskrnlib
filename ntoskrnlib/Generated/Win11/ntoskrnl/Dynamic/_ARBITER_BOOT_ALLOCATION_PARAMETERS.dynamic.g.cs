using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ARBITER_BOOT_ALLOCATION_PARAMETERS")]
    public sealed class _ARBITER_BOOT_ALLOCATION_PARAMETERS : DynamicStructure
    {
        public IntPtr ArbitrationList { get; }

        public _ARBITER_BOOT_ALLOCATION_PARAMETERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ARBITER_BOOT_ALLOCATION_PARAMETERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ARBITER_BOOT_ALLOCATION_PARAMETERS.ArbitrationList),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_ARBITER_BOOT_ALLOCATION_PARAMETERS>((mem, ptr) => new _ARBITER_BOOT_ALLOCATION_PARAMETERS(mem, ptr), offsets);
        }
    }
}