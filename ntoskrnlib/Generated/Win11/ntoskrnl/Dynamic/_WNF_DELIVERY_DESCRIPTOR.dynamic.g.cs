using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WNF_DELIVERY_DESCRIPTOR")]
    public sealed class _WNF_DELIVERY_DESCRIPTOR : DynamicStructure
    {
        public ulong SubscriptionId { get; }
        public _WNF_STATE_NAME StateName { get; }
        public uint ChangeStamp { get; }
        public uint StateDataSize { get; }
        public uint EventMask { get; }
        public _WNF_TYPE_ID TypeId { get; }
        public uint StateDataOffset { get; }

        public _WNF_DELIVERY_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WNF_DELIVERY_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WNF_DELIVERY_DESCRIPTOR.SubscriptionId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WNF_DELIVERY_DESCRIPTOR.StateName),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WNF_DELIVERY_DESCRIPTOR.ChangeStamp),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WNF_DELIVERY_DESCRIPTOR.StateDataSize),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_WNF_DELIVERY_DESCRIPTOR.EventMask),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_WNF_DELIVERY_DESCRIPTOR.TypeId),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_WNF_DELIVERY_DESCRIPTOR.StateDataOffset),
                    new ulong[]
                    {
                        44UL
                    }
                }
            };
            Register<_WNF_DELIVERY_DESCRIPTOR>((mem, ptr) => new _WNF_DELIVERY_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}