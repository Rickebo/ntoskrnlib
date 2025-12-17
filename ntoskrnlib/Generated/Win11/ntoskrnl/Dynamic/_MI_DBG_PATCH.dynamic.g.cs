using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_DBG_PATCH")]
    public sealed class _MI_DBG_PATCH : DynamicStructure
    {
        public _unnamed_tag_ u1 { get; }
        public _unnamed_tag_ u2 { get; }
        public uint OriginalBytes { get; }
        public uint NewBytes { get; }
        public uint Padding { get; }

        public _MI_DBG_PATCH(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_DBG_PATCH()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_DBG_PATCH.u1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_DBG_PATCH.u2),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_DBG_PATCH.OriginalBytes),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_MI_DBG_PATCH.NewBytes),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_DBG_PATCH.Padding),
                    new ulong[]
                    {
                        20UL
                    }
                }
            };
            Register<_MI_DBG_PATCH>((mem, ptr) => new _MI_DBG_PATCH(mem, ptr), offsets);
        }
    }
}