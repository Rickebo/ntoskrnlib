using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_STACKTRACE_BUFFER")]
    public sealed class _MI_STACKTRACE_BUFFER : DynamicStructure
    {
        public byte[] CallingFunction { get; }

        public _MI_STACKTRACE_BUFFER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_STACKTRACE_BUFFER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_STACKTRACE_BUFFER.CallingFunction),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_STACKTRACE_BUFFER>((mem, ptr) => new _MI_STACKTRACE_BUFFER(mem, ptr), offsets);
        }
    }
}