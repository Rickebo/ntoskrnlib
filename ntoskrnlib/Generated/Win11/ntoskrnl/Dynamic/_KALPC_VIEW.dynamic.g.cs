using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KALPC_VIEW")]
    public sealed class _KALPC_VIEW : DynamicStructure
    {
        public _LIST_ENTRY ViewListEntry { get; }
        public IntPtr Region { get; }
        public IntPtr OwnerPort { get; }
        public IntPtr OwnerProcess { get; }
        public IntPtr Address { get; }
        public ulong Size { get; }
        public IntPtr SecureViewHandle { get; }
        public IntPtr WriteAccessHandle { get; }
        public _unnamed_tag_ u1 { get; }
        public uint NumberOfOwnerMessages { get; }
        public _LIST_ENTRY ProcessViewListEntry { get; }

        public _KALPC_VIEW(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KALPC_VIEW()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KALPC_VIEW.ViewListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KALPC_VIEW.Region),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KALPC_VIEW.OwnerPort),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KALPC_VIEW.OwnerProcess),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KALPC_VIEW.Address),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KALPC_VIEW.Size),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KALPC_VIEW.SecureViewHandle),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_KALPC_VIEW.WriteAccessHandle),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_KALPC_VIEW.u1),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_KALPC_VIEW.NumberOfOwnerMessages),
                    new ulong[]
                    {
                        76UL
                    }
                },
                {
                    nameof(_KALPC_VIEW.ProcessViewListEntry),
                    new ulong[]
                    {
                        80UL
                    }
                }
            };
            Register<_KALPC_VIEW>((mem, ptr) => new _KALPC_VIEW(mem, ptr), offsets);
        }
    }
}