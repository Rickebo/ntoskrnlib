using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_GDI_TEB_BATCH32")]
    public sealed class _GDI_TEB_BATCH32 : DynamicStructure
    {
        public uint Offset { get; }
        public uint InProcessing { get; }
        public uint HasRenderingCommand { get; }
        public uint HDC { get; }
        public uint[] Buffer { get; }

        public _GDI_TEB_BATCH32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _GDI_TEB_BATCH32()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_GDI_TEB_BATCH32.Offset),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_GDI_TEB_BATCH32.InProcessing),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_GDI_TEB_BATCH32.HasRenderingCommand),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_GDI_TEB_BATCH32.HDC),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_GDI_TEB_BATCH32.Buffer),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_GDI_TEB_BATCH32>((mem, ptr) => new _GDI_TEB_BATCH32(mem, ptr), offsets);
        }
    }
}