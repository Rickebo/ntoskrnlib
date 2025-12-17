using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PORT_MESSAGE")]
    public sealed class _PORT_MESSAGE : DynamicStructure
    {
        public _unnamed_tag_ u1 { get; }
        public _unnamed_tag_ u2 { get; }
        public _CLIENT_ID ClientId { get; }
        public long DoNotUseThisField { get; }
        public uint MessageId { get; }
        public ulong ClientViewSize { get; }
        public uint CallbackId { get; }

        public _PORT_MESSAGE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PORT_MESSAGE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PORT_MESSAGE.u1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PORT_MESSAGE.u2),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PORT_MESSAGE.ClientId),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PORT_MESSAGE.DoNotUseThisField),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PORT_MESSAGE.MessageId),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PORT_MESSAGE.ClientViewSize),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PORT_MESSAGE.CallbackId),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_PORT_MESSAGE>((mem, ptr) => new _PORT_MESSAGE(mem, ptr), offsets);
        }
    }
}