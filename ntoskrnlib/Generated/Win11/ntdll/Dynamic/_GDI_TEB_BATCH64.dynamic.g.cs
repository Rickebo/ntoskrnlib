using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_GDI_TEB_BATCH64")]
    public sealed class _GDI_TEB_BATCH64 : DynamicStructure
    {
        public uint Offset { get; }
        public uint InProcessing { get; }
        public uint HasRenderingCommand { get; }
        public ulong HDC { get; }
        public uint[] Buffer { get; }

        public _GDI_TEB_BATCH64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _GDI_TEB_BATCH64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_GDI_TEB_BATCH64.Offset),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_GDI_TEB_BATCH64.InProcessing),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_GDI_TEB_BATCH64.HasRenderingCommand),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_GDI_TEB_BATCH64.HDC),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_GDI_TEB_BATCH64.Buffer),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_GDI_TEB_BATCH64>((mem, ptr) => new _GDI_TEB_BATCH64(mem, ptr), offsets);
        }
    }
}