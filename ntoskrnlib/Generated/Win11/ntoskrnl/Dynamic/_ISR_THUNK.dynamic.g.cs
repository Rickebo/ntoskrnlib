using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ISR_THUNK")]
    public sealed class _ISR_THUNK : DynamicStructure
    {
        public byte PushImm { get; }
        public byte Vector { get; }
        public byte PushRbp { get; }
        public byte JmpOp { get; }
        public int JmpOffset { get; }

        public _ISR_THUNK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ISR_THUNK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ISR_THUNK.PushImm),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ISR_THUNK.Vector),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_ISR_THUNK.PushRbp),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_ISR_THUNK.JmpOp),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_ISR_THUNK.JmpOffset),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_ISR_THUNK>((mem, ptr) => new _ISR_THUNK(mem, ptr), offsets);
        }
    }
}