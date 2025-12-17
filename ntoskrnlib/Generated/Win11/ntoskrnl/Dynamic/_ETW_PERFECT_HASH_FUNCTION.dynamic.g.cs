using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_PERFECT_HASH_FUNCTION")]
    public sealed class _ETW_PERFECT_HASH_FUNCTION : DynamicStructure
    {
        public _ETW_PERFECT_HASH_FUNCTION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_PERFECT_HASH_FUNCTION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_ETW_PERFECT_HASH_FUNCTION>((mem, ptr) => new _ETW_PERFECT_HASH_FUNCTION(mem, ptr), offsets);
        }
    }
}