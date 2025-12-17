using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_INBV_GRAPHICS_RECTANGLE")]
    public sealed class _INBV_GRAPHICS_RECTANGLE : DynamicStructure
    {
        public uint Height { get; }
        public uint Width { get; }
        public uint PixelFormat { get; }
        public uint Size { get; }
        public IntPtr Data { get; }

        public _INBV_GRAPHICS_RECTANGLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _INBV_GRAPHICS_RECTANGLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_INBV_GRAPHICS_RECTANGLE.Height),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_INBV_GRAPHICS_RECTANGLE.Width),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_INBV_GRAPHICS_RECTANGLE.PixelFormat),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_INBV_GRAPHICS_RECTANGLE.Size),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_INBV_GRAPHICS_RECTANGLE.Data),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_INBV_GRAPHICS_RECTANGLE>((mem, ptr) => new _INBV_GRAPHICS_RECTANGLE(mem, ptr), offsets);
        }
    }
}