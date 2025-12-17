using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KALPC_RESERVE")]
    public sealed class _KALPC_RESERVE : DynamicStructure
    {
        public IntPtr OwnerPort { get; }
        public IntPtr HandleTable { get; }
        public IntPtr Handle { get; }
        public IntPtr Message { get; }
        public ulong Size { get; }
        public int Active { get; }

        public _KALPC_RESERVE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KALPC_RESERVE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KALPC_RESERVE.OwnerPort),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KALPC_RESERVE.HandleTable),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KALPC_RESERVE.Handle),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KALPC_RESERVE.Message),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KALPC_RESERVE.Size),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KALPC_RESERVE.Active),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_KALPC_RESERVE>((mem, ptr) => new _KALPC_RESERVE(mem, ptr), offsets);
        }
    }
}