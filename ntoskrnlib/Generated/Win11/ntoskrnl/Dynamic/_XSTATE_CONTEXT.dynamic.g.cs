using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_XSTATE_CONTEXT")]
    public sealed class _XSTATE_CONTEXT : DynamicStructure
    {
        public ulong Mask { get; }
        public uint Length { get; }
        public byte Flags { get; }
        public byte[] Reserved0 { get; }
        public IntPtr Area { get; }
        public IntPtr Buffer { get; }

        public _XSTATE_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _XSTATE_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_XSTATE_CONTEXT.Mask),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_XSTATE_CONTEXT.Length),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_XSTATE_CONTEXT.Flags),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_XSTATE_CONTEXT.Reserved0),
                    new ulong[]
                    {
                        13UL
                    }
                },
                {
                    nameof(_XSTATE_CONTEXT.Area),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_XSTATE_CONTEXT.Buffer),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_XSTATE_CONTEXT>((mem, ptr) => new _XSTATE_CONTEXT(mem, ptr), offsets);
        }
    }
}