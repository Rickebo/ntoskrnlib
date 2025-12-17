using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_SYSTEM_VA_ASSIGNMENT")]
    public sealed class _MI_SYSTEM_VA_ASSIGNMENT : DynamicStructure
    {
        public IntPtr BaseAddress { get; }
        public ulong NumberOfBytes { get; }

        public _MI_SYSTEM_VA_ASSIGNMENT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_SYSTEM_VA_ASSIGNMENT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_SYSTEM_VA_ASSIGNMENT.BaseAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_VA_ASSIGNMENT.NumberOfBytes),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_MI_SYSTEM_VA_ASSIGNMENT>((mem, ptr) => new _MI_SYSTEM_VA_ASSIGNMENT(mem, ptr), offsets);
        }
    }
}