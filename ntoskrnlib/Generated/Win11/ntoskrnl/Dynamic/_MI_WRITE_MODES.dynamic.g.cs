using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_WRITE_MODES")]
    public sealed class _MI_WRITE_MODES : DynamicStructure
    {
        public ulong[] WriteType { get; }

        public _MI_WRITE_MODES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_WRITE_MODES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_WRITE_MODES.WriteType),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_WRITE_MODES>((mem, ptr) => new _MI_WRITE_MODES(mem, ptr), offsets);
        }
    }
}