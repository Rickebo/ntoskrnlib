using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_INBV_MODE_INFORMATION")]
    public sealed class _INBV_MODE_INFORMATION : DynamicStructure
    {
        public uint Height { get; }
        public uint Width { get; }
        public uint Stride { get; }
        public uint PixelFormat { get; }

        public _INBV_MODE_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _INBV_MODE_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_INBV_MODE_INFORMATION.Height),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_INBV_MODE_INFORMATION.Width),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_INBV_MODE_INFORMATION.Stride),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_INBV_MODE_INFORMATION.PixelFormat),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_INBV_MODE_INFORMATION>((mem, ptr) => new _INBV_MODE_INFORMATION(mem, ptr), offsets);
        }
    }
}