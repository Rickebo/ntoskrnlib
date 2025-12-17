using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TIMELINE_BITMAP")]
    public sealed class _TIMELINE_BITMAP : DynamicStructure
    {
        public ulong Value { get; }
        public uint EndTime { get; }
        public uint Bitmap { get; }

        public _TIMELINE_BITMAP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TIMELINE_BITMAP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TIMELINE_BITMAP.Value),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TIMELINE_BITMAP.EndTime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TIMELINE_BITMAP.Bitmap),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_TIMELINE_BITMAP>((mem, ptr) => new _TIMELINE_BITMAP(mem, ptr), offsets);
        }
    }
}