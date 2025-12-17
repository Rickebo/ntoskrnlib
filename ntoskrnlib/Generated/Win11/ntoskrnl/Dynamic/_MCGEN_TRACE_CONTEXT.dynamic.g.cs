using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MCGEN_TRACE_CONTEXT")]
    public sealed class _MCGEN_TRACE_CONTEXT : DynamicStructure
    {
        public ulong RegistrationHandle { get; }
        public ulong Logger { get; }
        public ulong MatchAnyKeyword { get; }
        public ulong MatchAllKeyword { get; }
        public uint Flags { get; }
        public uint IsEnabled { get; }
        public byte Level { get; }
        public byte Reserve { get; }
        public ushort EnableBitsCount { get; }
        public IntPtr EnableBitMask { get; }
        public IntPtr EnableKeyWords { get; }
        public IntPtr EnableLevel { get; }

        public _MCGEN_TRACE_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MCGEN_TRACE_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MCGEN_TRACE_CONTEXT.RegistrationHandle),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCGEN_TRACE_CONTEXT.Logger),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MCGEN_TRACE_CONTEXT.MatchAnyKeyword),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MCGEN_TRACE_CONTEXT.MatchAllKeyword),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MCGEN_TRACE_CONTEXT.Flags),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MCGEN_TRACE_CONTEXT.IsEnabled),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_MCGEN_TRACE_CONTEXT.Level),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MCGEN_TRACE_CONTEXT.Reserve),
                    new ulong[]
                    {
                        41UL
                    }
                },
                {
                    nameof(_MCGEN_TRACE_CONTEXT.EnableBitsCount),
                    new ulong[]
                    {
                        42UL
                    }
                },
                {
                    nameof(_MCGEN_TRACE_CONTEXT.EnableBitMask),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_MCGEN_TRACE_CONTEXT.EnableKeyWords),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_MCGEN_TRACE_CONTEXT.EnableLevel),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_MCGEN_TRACE_CONTEXT>((mem, ptr) => new _MCGEN_TRACE_CONTEXT(mem, ptr), offsets);
        }
    }
}