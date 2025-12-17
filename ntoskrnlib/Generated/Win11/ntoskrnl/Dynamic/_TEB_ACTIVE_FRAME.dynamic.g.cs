using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_TEB_ACTIVE_FRAME")]
    public sealed class _TEB_ACTIVE_FRAME : DynamicStructure
    {
        public uint Flags { get; }
        public IntPtr Previous { get; }
        public IntPtr Context { get; }

        public _TEB_ACTIVE_FRAME(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TEB_ACTIVE_FRAME()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TEB_ACTIVE_FRAME.Flags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TEB_ACTIVE_FRAME.Previous),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_TEB_ACTIVE_FRAME.Context),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_TEB_ACTIVE_FRAME>((mem, ptr) => new _TEB_ACTIVE_FRAME(mem, ptr), offsets);
        }
    }
}