using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_INITIAL_PRIVILEGE_SET")]
    public sealed class _INITIAL_PRIVILEGE_SET : DynamicStructure
    {
        public uint PrivilegeCount { get; }
        public uint Control { get; }
        public byte[] Privilege { get; }

        public _INITIAL_PRIVILEGE_SET(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _INITIAL_PRIVILEGE_SET()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_INITIAL_PRIVILEGE_SET.PrivilegeCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_INITIAL_PRIVILEGE_SET.Control),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_INITIAL_PRIVILEGE_SET.Privilege),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_INITIAL_PRIVILEGE_SET>((mem, ptr) => new _INITIAL_PRIVILEGE_SET(mem, ptr), offsets);
        }
    }
}