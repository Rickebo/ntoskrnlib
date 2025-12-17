using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CI_NGEN_PATHS")]
    public sealed class _CI_NGEN_PATHS : DynamicStructure
    {
        public _CI_NGEN_PATHS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CI_NGEN_PATHS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_CI_NGEN_PATHS>((mem, ptr) => new _CI_NGEN_PATHS(mem, ptr), offsets);
        }
    }
}