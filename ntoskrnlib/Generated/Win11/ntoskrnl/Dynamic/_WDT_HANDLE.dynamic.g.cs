using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WDT_HANDLE")]
    public sealed class _WDT_HANDLE : DynamicStructure
    {
        public sbyte Reserved { get; }

        public _WDT_HANDLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WDT_HANDLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WDT_HANDLE.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_WDT_HANDLE>((mem, ptr) => new _WDT_HANDLE(mem, ptr), offsets);
        }
    }
}