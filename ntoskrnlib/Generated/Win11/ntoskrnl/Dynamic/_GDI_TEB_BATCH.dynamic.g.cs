using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_GDI_TEB_BATCH")]
    public sealed class _GDI_TEB_BATCH : DynamicStructure
    {
        public uint Offset { get; }
        public uint InProcessing { get; }
        public uint HasRenderingCommand { get; }
        public ulong HDC { get; }
        public uint[] Buffer { get; }

        public _GDI_TEB_BATCH(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _GDI_TEB_BATCH()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_GDI_TEB_BATCH.Offset),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_GDI_TEB_BATCH.InProcessing),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_GDI_TEB_BATCH.HasRenderingCommand),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_GDI_TEB_BATCH.HDC),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_GDI_TEB_BATCH.Buffer),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_GDI_TEB_BATCH>((mem, ptr) => new _GDI_TEB_BATCH(mem, ptr), offsets);
        }
    }
}