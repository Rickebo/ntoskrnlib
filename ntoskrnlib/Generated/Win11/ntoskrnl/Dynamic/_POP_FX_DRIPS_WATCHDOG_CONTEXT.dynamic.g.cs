using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_FX_DRIPS_WATCHDOG_CONTEXT")]
    public sealed class _POP_FX_DRIPS_WATCHDOG_CONTEXT : DynamicStructure
    {
        public _LIST_ENTRY Link { get; }
        public uint ComponentIndex { get; }
        public IntPtr ChildDevices { get; }
        public uint ChildDeviceCount { get; }

        public _POP_FX_DRIPS_WATCHDOG_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_FX_DRIPS_WATCHDOG_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_FX_DRIPS_WATCHDOG_CONTEXT.Link),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_DRIPS_WATCHDOG_CONTEXT.ComponentIndex),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POP_FX_DRIPS_WATCHDOG_CONTEXT.ChildDevices),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_POP_FX_DRIPS_WATCHDOG_CONTEXT.ChildDeviceCount),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_POP_FX_DRIPS_WATCHDOG_CONTEXT>((mem, ptr) => new _POP_FX_DRIPS_WATCHDOG_CONTEXT(mem, ptr), offsets);
        }
    }
}