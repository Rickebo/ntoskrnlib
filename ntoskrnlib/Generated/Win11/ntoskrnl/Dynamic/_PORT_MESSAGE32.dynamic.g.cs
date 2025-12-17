using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PORT_MESSAGE32")]
    public sealed class _PORT_MESSAGE32 : DynamicStructure
    {
        public _unnamed_tag_ u1 { get; }
        public _unnamed_tag_ u2 { get; }
        public _CLIENT_ID32 ClientId { get; }
        public long DoNotUseThisField { get; }
        public uint MessageId { get; }
        public uint ClientViewSize { get; }
        public uint CallbackId { get; }

        public _PORT_MESSAGE32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PORT_MESSAGE32()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PORT_MESSAGE32.u1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PORT_MESSAGE32.u2),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PORT_MESSAGE32.ClientId),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PORT_MESSAGE32.DoNotUseThisField),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PORT_MESSAGE32.MessageId),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PORT_MESSAGE32.ClientViewSize),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_PORT_MESSAGE32.CallbackId),
                    new ulong[]
                    {
                        20UL
                    }
                }
            };
            Register<_PORT_MESSAGE32>((mem, ptr) => new _PORT_MESSAGE32(mem, ptr), offsets);
        }
    }
}