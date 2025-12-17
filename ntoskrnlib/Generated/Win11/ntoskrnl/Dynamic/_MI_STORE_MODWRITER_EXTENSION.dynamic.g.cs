using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_STORE_MODWRITER_EXTENSION")]
    public sealed class _MI_STORE_MODWRITER_EXTENSION : DynamicStructure
    {
        public _KAPC WriteCompletionApc { get; }
        public uint WriteRefCount { get; }
        public uint PadSpare { get; }
        public byte[] PagefileInfo { get; }

        public _MI_STORE_MODWRITER_EXTENSION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_STORE_MODWRITER_EXTENSION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_STORE_MODWRITER_EXTENSION.WriteCompletionApc),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_STORE_MODWRITER_EXTENSION.WriteRefCount),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_MI_STORE_MODWRITER_EXTENSION.PadSpare),
                    new ulong[]
                    {
                        92UL
                    }
                },
                {
                    nameof(_MI_STORE_MODWRITER_EXTENSION.PagefileInfo),
                    new ulong[]
                    {
                        96UL
                    }
                }
            };
            Register<_MI_STORE_MODWRITER_EXTENSION>((mem, ptr) => new _MI_STORE_MODWRITER_EXTENSION(mem, ptr), offsets);
        }
    }
}