using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_TEB_ACTIVE_FRAME_CONTEXT")]
    public sealed class _TEB_ACTIVE_FRAME_CONTEXT : DynamicStructure
    {
        public uint Flags { get; }
        public IntPtr FrameName { get; }

        public _TEB_ACTIVE_FRAME_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TEB_ACTIVE_FRAME_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TEB_ACTIVE_FRAME_CONTEXT.Flags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TEB_ACTIVE_FRAME_CONTEXT.FrameName),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_TEB_ACTIVE_FRAME_CONTEXT>((mem, ptr) => new _TEB_ACTIVE_FRAME_CONTEXT(mem, ptr), offsets);
        }
    }
}