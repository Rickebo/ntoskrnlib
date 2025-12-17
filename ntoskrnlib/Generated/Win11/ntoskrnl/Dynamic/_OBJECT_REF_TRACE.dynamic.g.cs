using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OBJECT_REF_TRACE")]
    public sealed class _OBJECT_REF_TRACE : DynamicStructure
    {
        public byte[] StackTrace { get; }

        public _OBJECT_REF_TRACE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OBJECT_REF_TRACE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OBJECT_REF_TRACE.StackTrace),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_OBJECT_REF_TRACE>((mem, ptr) => new _OBJECT_REF_TRACE(mem, ptr), offsets);
        }
    }
}