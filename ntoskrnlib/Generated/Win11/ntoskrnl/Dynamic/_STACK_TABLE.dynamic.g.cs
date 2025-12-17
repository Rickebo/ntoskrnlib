using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_STACK_TABLE")]
    public sealed class _STACK_TABLE : DynamicStructure
    {
        public ushort NumStackTraces { get; }
        public ushort TraceCapacity { get; }
        public byte[] StackTrace { get; }
        public ushort[] StackTableHash { get; }

        public _STACK_TABLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _STACK_TABLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_STACK_TABLE.NumStackTraces),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_STACK_TABLE.TraceCapacity),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_STACK_TABLE.StackTrace),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_STACK_TABLE.StackTableHash),
                    new ulong[]
                    {
                        136UL
                    }
                }
            };
            Register<_STACK_TABLE>((mem, ptr) => new _STACK_TABLE(mem, ptr), offsets);
        }
    }
}