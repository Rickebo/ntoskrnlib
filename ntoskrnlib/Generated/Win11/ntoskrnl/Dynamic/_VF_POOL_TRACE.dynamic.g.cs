using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VF_POOL_TRACE")]
    public sealed class _VF_POOL_TRACE : DynamicStructure
    {
        public IntPtr Address { get; }
        public ulong Size { get; }
        public IntPtr Thread { get; }
        public byte[] StackTrace { get; }

        public _VF_POOL_TRACE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VF_POOL_TRACE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VF_POOL_TRACE.Address),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VF_POOL_TRACE.Size),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_VF_POOL_TRACE.Thread),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_VF_POOL_TRACE.StackTrace),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_VF_POOL_TRACE>((mem, ptr) => new _VF_POOL_TRACE(mem, ptr), offsets);
        }
    }
}