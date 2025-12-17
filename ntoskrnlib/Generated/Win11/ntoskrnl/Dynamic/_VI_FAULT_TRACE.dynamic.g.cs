using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VI_FAULT_TRACE")]
    public sealed class _VI_FAULT_TRACE : DynamicStructure
    {
        public IntPtr Thread { get; }
        public byte[] StackTrace { get; }

        public _VI_FAULT_TRACE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VI_FAULT_TRACE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VI_FAULT_TRACE.Thread),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VI_FAULT_TRACE.StackTrace),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_VI_FAULT_TRACE>((mem, ptr) => new _VI_FAULT_TRACE(mem, ptr), offsets);
        }
    }
}