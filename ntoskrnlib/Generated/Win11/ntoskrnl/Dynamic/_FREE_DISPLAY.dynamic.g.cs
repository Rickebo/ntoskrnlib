using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_FREE_DISPLAY")]
    public sealed class _FREE_DISPLAY : DynamicStructure
    {
        public uint RealVectorSize { get; }
        public uint Hint { get; }
        public _RTL_BITMAP Display { get; }

        public _FREE_DISPLAY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _FREE_DISPLAY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_FREE_DISPLAY.RealVectorSize),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FREE_DISPLAY.Hint),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_FREE_DISPLAY.Display),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_FREE_DISPLAY>((mem, ptr) => new _FREE_DISPLAY(mem, ptr), offsets);
        }
    }
}