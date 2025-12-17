using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DUAL")]
    public sealed class _DUAL : DynamicStructure
    {
        public uint Length { get; }
        public IntPtr Map { get; }
        public IntPtr SmallDir { get; }
        public uint Guard { get; }
        public byte[] FreeDisplay { get; }
        public _LIST_ENTRY FreeBins { get; }
        public uint FreeSummary { get; }

        public _DUAL(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DUAL()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DUAL.Length),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DUAL.Map),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DUAL.SmallDir),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DUAL.Guard),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_DUAL.FreeDisplay),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_DUAL.FreeBins),
                    new ulong[]
                    {
                        608UL
                    }
                },
                {
                    nameof(_DUAL.FreeSummary),
                    new ulong[]
                    {
                        624UL
                    }
                }
            };
            Register<_DUAL>((mem, ptr) => new _DUAL(mem, ptr), offsets);
        }
    }
}