using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_SYSTEM_LOGGER")]
    public sealed class _ETW_SYSTEM_LOGGER : DynamicStructure
    {
        public byte LoggerId { get; }
        public byte ClockType { get; }

        public _ETW_SYSTEM_LOGGER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_SYSTEM_LOGGER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_SYSTEM_LOGGER.LoggerId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_SYSTEM_LOGGER.ClockType),
                    new ulong[]
                    {
                        1UL
                    }
                }
            };
            Register<_ETW_SYSTEM_LOGGER>((mem, ptr) => new _ETW_SYSTEM_LOGGER(mem, ptr), offsets);
        }
    }
}