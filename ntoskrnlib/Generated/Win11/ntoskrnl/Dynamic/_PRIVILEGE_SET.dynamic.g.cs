using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PRIVILEGE_SET")]
    public sealed class _PRIVILEGE_SET : DynamicStructure
    {
        public uint PrivilegeCount { get; }
        public uint Control { get; }
        public byte[] Privilege { get; }

        public _PRIVILEGE_SET(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PRIVILEGE_SET()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PRIVILEGE_SET.PrivilegeCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PRIVILEGE_SET.Control),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PRIVILEGE_SET.Privilege),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PRIVILEGE_SET>((mem, ptr) => new _PRIVILEGE_SET(mem, ptr), offsets);
        }
    }
}