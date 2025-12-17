using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PCW_COUNTER_INFORMATION")]
    public sealed class _PCW_COUNTER_INFORMATION : DynamicStructure
    {
        public ulong CounterMask { get; }
        public IntPtr InstanceMask { get; }

        public _PCW_COUNTER_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PCW_COUNTER_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PCW_COUNTER_INFORMATION.CounterMask),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PCW_COUNTER_INFORMATION.InstanceMask),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PCW_COUNTER_INFORMATION>((mem, ptr) => new _PCW_COUNTER_INFORMATION(mem, ptr), offsets);
        }
    }
}