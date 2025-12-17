using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VF_KE_CRITICAL_REGION_TRACE")]
    public sealed class _VF_KE_CRITICAL_REGION_TRACE : DynamicStructure
    {
        public IntPtr Thread { get; }
        public byte[] StackTrace { get; }

        public _VF_KE_CRITICAL_REGION_TRACE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VF_KE_CRITICAL_REGION_TRACE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VF_KE_CRITICAL_REGION_TRACE.Thread),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VF_KE_CRITICAL_REGION_TRACE.StackTrace),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_VF_KE_CRITICAL_REGION_TRACE>((mem, ptr) => new _VF_KE_CRITICAL_REGION_TRACE(mem, ptr), offsets);
        }
    }
}