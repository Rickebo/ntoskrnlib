using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_INBV_DISPLAY_CONTEXT")]
    public sealed class _INBV_DISPLAY_CONTEXT : DynamicStructure
    {
        public byte FrameBufferValid { get; }
        public byte FrameBufferMapped { get; }
        public byte DisplayRotation { get; }
        public _INBV_MODE_INFORMATION ModeInformation { get; }
        public IntPtr ShadowBuffer { get; }
        public _unnamed_tag_ VideoMemory { get; }

        public _INBV_DISPLAY_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _INBV_DISPLAY_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_INBV_DISPLAY_CONTEXT.FrameBufferValid),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_INBV_DISPLAY_CONTEXT.FrameBufferMapped),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_INBV_DISPLAY_CONTEXT.DisplayRotation),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_INBV_DISPLAY_CONTEXT.ModeInformation),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_INBV_DISPLAY_CONTEXT.ShadowBuffer),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_INBV_DISPLAY_CONTEXT.VideoMemory),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_INBV_DISPLAY_CONTEXT>((mem, ptr) => new _INBV_DISPLAY_CONTEXT(mem, ptr), offsets);
        }
    }
}