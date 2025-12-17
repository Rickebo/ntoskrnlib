using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_LOGGER_HANDLE")]
    public sealed class _ETW_LOGGER_HANDLE : DynamicStructure
    {
        public byte DereferenceAndLeave { get; }

        public _ETW_LOGGER_HANDLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_LOGGER_HANDLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_LOGGER_HANDLE.DereferenceAndLeave),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_ETW_LOGGER_HANDLE>((mem, ptr) => new _ETW_LOGGER_HANDLE(mem, ptr), offsets);
        }
    }
}