using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OB_HANDLE_REVOCATION_BLOCK")]
    public sealed class _OB_HANDLE_REVOCATION_BLOCK : DynamicStructure
    {
        public _LIST_ENTRY RevocationInfos { get; }
        public _EX_PUSH_LOCK Lock { get; }
        public _EX_RUNDOWN_REF Rundown { get; }

        public _OB_HANDLE_REVOCATION_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OB_HANDLE_REVOCATION_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OB_HANDLE_REVOCATION_BLOCK.RevocationInfos),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OB_HANDLE_REVOCATION_BLOCK.Lock),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_OB_HANDLE_REVOCATION_BLOCK.Rundown),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_OB_HANDLE_REVOCATION_BLOCK>((mem, ptr) => new _OB_HANDLE_REVOCATION_BLOCK(mem, ptr), offsets);
        }
    }
}