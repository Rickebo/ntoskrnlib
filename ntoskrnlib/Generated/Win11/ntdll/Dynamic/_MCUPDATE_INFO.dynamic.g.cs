using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_MCUPDATE_INFO")]
    public sealed class _MCUPDATE_INFO : DynamicStructure
    {
        public _LIST_ENTRY List { get; }
        public uint Status { get; }
        public ulong Id { get; }
        public ulong[] VendorScratch { get; }

        public _MCUPDATE_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MCUPDATE_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MCUPDATE_INFO.List),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCUPDATE_INFO.Status),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MCUPDATE_INFO.Id),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MCUPDATE_INFO.VendorScratch),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_MCUPDATE_INFO>((mem, ptr) => new _MCUPDATE_INFO(mem, ptr), offsets);
        }
    }
}