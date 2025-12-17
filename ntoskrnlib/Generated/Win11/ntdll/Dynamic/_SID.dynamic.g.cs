using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_SID")]
    public sealed class _SID : DynamicStructure
    {
        public byte Revision { get; }
        public byte SubAuthorityCount { get; }
        public _SID_IDENTIFIER_AUTHORITY IdentifierAuthority { get; }
        public uint[] SubAuthority { get; }

        public _SID(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SID()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SID.Revision),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SID.SubAuthorityCount),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_SID.IdentifierAuthority),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_SID.SubAuthority),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_SID>((mem, ptr) => new _SID(mem, ptr), offsets);
        }
    }
}