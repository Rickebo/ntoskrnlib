using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HIVE_WRITE_WAIT_QUEUE")]
    public sealed class _HIVE_WRITE_WAIT_QUEUE : DynamicStructure
    {
        public IntPtr ActiveThread { get; }
        public IntPtr WaitList { get; }

        public _HIVE_WRITE_WAIT_QUEUE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HIVE_WRITE_WAIT_QUEUE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HIVE_WRITE_WAIT_QUEUE.ActiveThread),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HIVE_WRITE_WAIT_QUEUE.WaitList),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_HIVE_WRITE_WAIT_QUEUE>((mem, ptr) => new _HIVE_WRITE_WAIT_QUEUE(mem, ptr), offsets);
        }
    }
}