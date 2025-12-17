using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POOL_LIMIT_INFO")]
    public sealed class _POOL_LIMIT_INFO : DynamicStructure
    {
        public ulong HardMemoryLimit { get; }
        public ulong NotificationLimit { get; }
        public ulong MemoryIssued { get; }

        public _POOL_LIMIT_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POOL_LIMIT_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POOL_LIMIT_INFO.HardMemoryLimit),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POOL_LIMIT_INFO.NotificationLimit),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_POOL_LIMIT_INFO.MemoryIssued),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_POOL_LIMIT_INFO>((mem, ptr) => new _POOL_LIMIT_INFO(mem, ptr), offsets);
        }
    }
}