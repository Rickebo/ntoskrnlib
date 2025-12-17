using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_TERMINATION_PORT")]
    public sealed class _TERMINATION_PORT : DynamicStructure
    {
        public IntPtr Next { get; }
        public IntPtr Port { get; }

        public _TERMINATION_PORT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TERMINATION_PORT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TERMINATION_PORT.Next),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TERMINATION_PORT.Port),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_TERMINATION_PORT>((mem, ptr) => new _TERMINATION_PORT(mem, ptr), offsets);
        }
    }
}