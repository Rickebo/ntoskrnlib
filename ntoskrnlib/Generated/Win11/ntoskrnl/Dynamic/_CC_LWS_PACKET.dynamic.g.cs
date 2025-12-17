using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CC_LWS_PACKET")]
    public sealed class _CC_LWS_PACKET : DynamicStructure
    {
        public uint Type { get; }
        public byte Active { get; }
        public _unnamed_tag_ Overlay { get; }

        public _CC_LWS_PACKET(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CC_LWS_PACKET()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CC_LWS_PACKET.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CC_LWS_PACKET.Active),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_CC_LWS_PACKET.Overlay),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_CC_LWS_PACKET>((mem, ptr) => new _CC_LWS_PACKET(mem, ptr), offsets);
        }
    }
}