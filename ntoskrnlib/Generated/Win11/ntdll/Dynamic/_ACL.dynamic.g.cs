using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_ACL")]
    public sealed class _ACL : DynamicStructure
    {
        public byte AclRevision { get; }
        public byte Sbz1 { get; }
        public ushort AclSize { get; }
        public ushort AceCount { get; }
        public ushort Sbz2 { get; }

        public _ACL(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ACL()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ACL.AclRevision),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ACL.Sbz1),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_ACL.AclSize),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_ACL.AceCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_ACL.Sbz2),
                    new ulong[]
                    {
                        6UL
                    }
                }
            };
            Register<_ACL>((mem, ptr) => new _ACL(mem, ptr), offsets);
        }
    }
}