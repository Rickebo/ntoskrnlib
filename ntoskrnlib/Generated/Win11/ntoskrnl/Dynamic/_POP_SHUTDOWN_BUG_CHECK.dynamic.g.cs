using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_SHUTDOWN_BUG_CHECK")]
    public sealed class _POP_SHUTDOWN_BUG_CHECK : DynamicStructure
    {
        public IntPtr InitiatingThread { get; }
        public IntPtr InitiatingProcess { get; }
        public IntPtr ThreadId { get; }
        public IntPtr ProcessId { get; }
        public uint Code { get; }
        public ulong Parameter1 { get; }
        public ulong Parameter2 { get; }
        public ulong Parameter3 { get; }
        public ulong Parameter4 { get; }

        public _POP_SHUTDOWN_BUG_CHECK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_SHUTDOWN_BUG_CHECK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_SHUTDOWN_BUG_CHECK.InitiatingThread),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_SHUTDOWN_BUG_CHECK.InitiatingProcess),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_POP_SHUTDOWN_BUG_CHECK.ThreadId),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POP_SHUTDOWN_BUG_CHECK.ProcessId),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_POP_SHUTDOWN_BUG_CHECK.Code),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_POP_SHUTDOWN_BUG_CHECK.Parameter1),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_POP_SHUTDOWN_BUG_CHECK.Parameter2),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_POP_SHUTDOWN_BUG_CHECK.Parameter3),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_POP_SHUTDOWN_BUG_CHECK.Parameter4),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_POP_SHUTDOWN_BUG_CHECK>((mem, ptr) => new _POP_SHUTDOWN_BUG_CHECK(mem, ptr), offsets);
        }
    }
}