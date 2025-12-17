using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_IOP_IRP_STACK_PROFILER")]
    public sealed class _IOP_IRP_STACK_PROFILER : DynamicStructure
    {
        public uint[] Profile { get; }
        public uint TotalIrps { get; }

        public _IOP_IRP_STACK_PROFILER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOP_IRP_STACK_PROFILER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOP_IRP_STACK_PROFILER.Profile),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOP_IRP_STACK_PROFILER.TotalIrps),
                    new ulong[]
                    {
                        80UL
                    }
                }
            };
            Register<_IOP_IRP_STACK_PROFILER>((mem, ptr) => new _IOP_IRP_STACK_PROFILER(mem, ptr), offsets);
        }
    }
}