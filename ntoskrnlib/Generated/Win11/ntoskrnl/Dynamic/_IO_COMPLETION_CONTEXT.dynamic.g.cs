using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IO_COMPLETION_CONTEXT")]
    public sealed class _IO_COMPLETION_CONTEXT : DynamicStructure
    {
        public IntPtr Port { get; }
        public IntPtr Key { get; }
        public long UsageCount { get; }

        public _IO_COMPLETION_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IO_COMPLETION_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IO_COMPLETION_CONTEXT.Port),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IO_COMPLETION_CONTEXT.Key),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IO_COMPLETION_CONTEXT.UsageCount),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_IO_COMPLETION_CONTEXT>((mem, ptr) => new _IO_COMPLETION_CONTEXT(mem, ptr), offsets);
        }
    }
}