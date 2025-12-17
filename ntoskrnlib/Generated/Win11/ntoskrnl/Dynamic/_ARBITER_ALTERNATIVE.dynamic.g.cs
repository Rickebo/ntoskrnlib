using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ARBITER_ALTERNATIVE")]
    public sealed class _ARBITER_ALTERNATIVE : DynamicStructure
    {
        public ulong Minimum { get; }
        public ulong Maximum { get; }
        public ulong Length { get; }
        public ulong Alignment { get; }
        public int Priority { get; }
        public uint Flags { get; }
        public IntPtr Descriptor { get; }
        public uint[] Reserved { get; }

        public _ARBITER_ALTERNATIVE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ARBITER_ALTERNATIVE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ARBITER_ALTERNATIVE.Minimum),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARBITER_ALTERNATIVE.Maximum),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ARBITER_ALTERNATIVE.Length),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ARBITER_ALTERNATIVE.Alignment),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_ARBITER_ALTERNATIVE.Priority),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_ARBITER_ALTERNATIVE.Flags),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_ARBITER_ALTERNATIVE.Descriptor),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_ARBITER_ALTERNATIVE.Reserved),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_ARBITER_ALTERNATIVE>((mem, ptr) => new _ARBITER_ALTERNATIVE(mem, ptr), offsets);
        }
    }
}