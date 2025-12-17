using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_CURRENT_BROADCAST")]
    public sealed class _POP_CURRENT_BROADCAST : DynamicStructure
    {
        public byte InProgress { get; }
        public _SYSTEM_POWER_STATE_CONTEXT SystemContext { get; }
        public uint PowerAction { get; }
        public IntPtr DeviceState { get; }

        public _POP_CURRENT_BROADCAST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_CURRENT_BROADCAST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_CURRENT_BROADCAST.InProgress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_CURRENT_BROADCAST.SystemContext),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_POP_CURRENT_BROADCAST.PowerAction),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_POP_CURRENT_BROADCAST.DeviceState),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_POP_CURRENT_BROADCAST>((mem, ptr) => new _POP_CURRENT_BROADCAST(mem, ptr), offsets);
        }
    }
}