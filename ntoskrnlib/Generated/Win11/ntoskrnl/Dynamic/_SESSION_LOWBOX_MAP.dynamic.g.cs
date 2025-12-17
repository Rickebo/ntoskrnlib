using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SESSION_LOWBOX_MAP")]
    public sealed class _SESSION_LOWBOX_MAP : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public uint SessionId { get; }
        public _SEP_LOWBOX_NUMBER_MAPPING LowboxMap { get; }

        public _SESSION_LOWBOX_MAP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SESSION_LOWBOX_MAP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SESSION_LOWBOX_MAP.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SESSION_LOWBOX_MAP.SessionId),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_SESSION_LOWBOX_MAP.LowboxMap),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_SESSION_LOWBOX_MAP>((mem, ptr) => new _SESSION_LOWBOX_MAP(mem, ptr), offsets);
        }
    }
}