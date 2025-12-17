using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_BOOT_CONFIG")]
    public sealed class _ETW_BOOT_CONFIG : DynamicStructure
    {
        public uint MaxLoggers { get; }
        public _LIST_ENTRY BootLoggersList { get; }

        public _ETW_BOOT_CONFIG(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_BOOT_CONFIG()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_BOOT_CONFIG.MaxLoggers),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_BOOT_CONFIG.BootLoggersList),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_ETW_BOOT_CONFIG>((mem, ptr) => new _ETW_BOOT_CONFIG(mem, ptr), offsets);
        }
    }
}