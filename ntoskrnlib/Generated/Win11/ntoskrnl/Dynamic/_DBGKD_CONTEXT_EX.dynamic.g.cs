using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_CONTEXT_EX")]
    public sealed class _DBGKD_CONTEXT_EX : DynamicStructure
    {
        public uint Offset { get; }
        public uint ByteCount { get; }
        public uint BytesCopied { get; }

        public _DBGKD_CONTEXT_EX(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_CONTEXT_EX()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_CONTEXT_EX.Offset),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_CONTEXT_EX.ByteCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DBGKD_CONTEXT_EX.BytesCopied),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_DBGKD_CONTEXT_EX>((mem, ptr) => new _DBGKD_CONTEXT_EX(mem, ptr), offsets);
        }
    }
}