using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOSAPIC")]
    public sealed class _IOSAPIC : DynamicStructure
    {
        public byte Type { get; }
        public byte Length { get; }
        public byte IOSAPICID { get; }
        public byte Reserved { get; }
        public uint SystemVectorBase { get; }
        public ulong IOSAPICAddress { get; }

        public _IOSAPIC(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOSAPIC()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOSAPIC.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOSAPIC.Length),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_IOSAPIC.IOSAPICID),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_IOSAPIC.Reserved),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_IOSAPIC.SystemVectorBase),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_IOSAPIC.IOSAPICAddress),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_IOSAPIC>((mem, ptr) => new _IOSAPIC(mem, ptr), offsets);
        }
    }
}