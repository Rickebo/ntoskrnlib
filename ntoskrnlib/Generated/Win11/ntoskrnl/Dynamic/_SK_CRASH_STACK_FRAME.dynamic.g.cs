using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SK_CRASH_STACK_FRAME")]
    public sealed class _SK_CRASH_STACK_FRAME : DynamicStructure
    {
        public uint ModuleId { get; }
        public uint Rva { get; }
        public ulong Pc { get; }

        public _SK_CRASH_STACK_FRAME(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SK_CRASH_STACK_FRAME()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SK_CRASH_STACK_FRAME.ModuleId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SK_CRASH_STACK_FRAME.Rva),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_SK_CRASH_STACK_FRAME.Pc),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_SK_CRASH_STACK_FRAME>((mem, ptr) => new _SK_CRASH_STACK_FRAME(mem, ptr), offsets);
        }
    }
}