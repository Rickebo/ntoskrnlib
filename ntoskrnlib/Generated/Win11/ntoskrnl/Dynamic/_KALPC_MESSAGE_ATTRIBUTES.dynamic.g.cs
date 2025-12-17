using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KALPC_MESSAGE_ATTRIBUTES")]
    public sealed class _KALPC_MESSAGE_ATTRIBUTES : DynamicStructure
    {
        public IntPtr ClientContext { get; }
        public IntPtr ServerContext { get; }
        public IntPtr PortContext { get; }
        public IntPtr CancelPortContext { get; }
        public IntPtr SecurityData { get; }
        public IntPtr View { get; }
        public IntPtr HandleData { get; }
        public _KALPC_DIRECT_EVENT DirectEvent { get; }
        public _KALPC_WORK_ON_BEHALF_DATA WorkOnBehalfData { get; }

        public _KALPC_MESSAGE_ATTRIBUTES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KALPC_MESSAGE_ATTRIBUTES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KALPC_MESSAGE_ATTRIBUTES.ClientContext),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KALPC_MESSAGE_ATTRIBUTES.ServerContext),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KALPC_MESSAGE_ATTRIBUTES.PortContext),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KALPC_MESSAGE_ATTRIBUTES.CancelPortContext),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KALPC_MESSAGE_ATTRIBUTES.SecurityData),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KALPC_MESSAGE_ATTRIBUTES.View),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KALPC_MESSAGE_ATTRIBUTES.HandleData),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KALPC_MESSAGE_ATTRIBUTES.DirectEvent),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_KALPC_MESSAGE_ATTRIBUTES.WorkOnBehalfData),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_KALPC_MESSAGE_ATTRIBUTES>((mem, ptr) => new _KALPC_MESSAGE_ATTRIBUTES(mem, ptr), offsets);
        }
    }
}