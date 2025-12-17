using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SECTION")]
    public sealed class _SECTION : DynamicStructure
    {
        public _RTL_BALANCED_NODE SectionNode { get; }
        public ulong StartingVpn { get; }
        public ulong EndingVpn { get; }
        public _unnamed_tag_ u1 { get; }
        public ulong SizeOfSection { get; }
        public _unnamed_tag_ u { get; }
        public uint InitialPageProtection { get; }
        public uint SessionId { get; }
        public uint NoValidationNeeded { get; }

        public _SECTION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SECTION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SECTION.SectionNode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SECTION.StartingVpn),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_SECTION.EndingVpn),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_SECTION.u1),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_SECTION.SizeOfSection),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_SECTION.u),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_SECTION.InitialPageProtection),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_SECTION.SessionId),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_SECTION.NoValidationNeeded),
                    new ulong[]
                    {
                        60UL
                    }
                }
            };
            Register<_SECTION>((mem, ptr) => new _SECTION(mem, ptr), offsets);
        }
    }
}