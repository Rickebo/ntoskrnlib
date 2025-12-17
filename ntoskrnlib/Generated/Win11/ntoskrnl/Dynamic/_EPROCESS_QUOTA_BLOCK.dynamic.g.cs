using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EPROCESS_QUOTA_BLOCK")]
    public sealed class _EPROCESS_QUOTA_BLOCK : DynamicStructure
    {
        public _EPROCESS_QUOTA_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EPROCESS_QUOTA_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_EPROCESS_QUOTA_BLOCK>((mem, ptr) => new _EPROCESS_QUOTA_BLOCK(mem, ptr), offsets);
        }
    }
}