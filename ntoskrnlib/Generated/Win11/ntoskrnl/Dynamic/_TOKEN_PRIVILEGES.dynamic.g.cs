using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_TOKEN_PRIVILEGES")]
    public sealed class _TOKEN_PRIVILEGES : DynamicStructure
    {
        public uint PrivilegeCount { get; }
        public byte[] Privileges { get; }

        public _TOKEN_PRIVILEGES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TOKEN_PRIVILEGES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TOKEN_PRIVILEGES.PrivilegeCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TOKEN_PRIVILEGES.Privileges),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_TOKEN_PRIVILEGES>((mem, ptr) => new _TOKEN_PRIVILEGES(mem, ptr), offsets);
        }
    }
}