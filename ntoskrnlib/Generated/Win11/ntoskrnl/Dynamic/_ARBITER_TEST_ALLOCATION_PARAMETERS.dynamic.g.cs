using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ARBITER_TEST_ALLOCATION_PARAMETERS")]
    public sealed class _ARBITER_TEST_ALLOCATION_PARAMETERS : DynamicStructure
    {
        public IntPtr ArbitrationList { get; }
        public uint AllocateFromCount { get; }
        public IntPtr AllocateFrom { get; }

        public _ARBITER_TEST_ALLOCATION_PARAMETERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ARBITER_TEST_ALLOCATION_PARAMETERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ARBITER_TEST_ALLOCATION_PARAMETERS.ArbitrationList),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARBITER_TEST_ALLOCATION_PARAMETERS.AllocateFromCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ARBITER_TEST_ALLOCATION_PARAMETERS.AllocateFrom),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_ARBITER_TEST_ALLOCATION_PARAMETERS>((mem, ptr) => new _ARBITER_TEST_ALLOCATION_PARAMETERS(mem, ptr), offsets);
        }
    }
}