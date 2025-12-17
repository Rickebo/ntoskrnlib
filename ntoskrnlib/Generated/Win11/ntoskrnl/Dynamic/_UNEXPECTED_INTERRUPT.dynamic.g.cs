using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_UNEXPECTED_INTERRUPT")]
    public sealed class _UNEXPECTED_INTERRUPT : DynamicStructure
    {
        public byte PushImm { get; }
        public byte Vector { get; }
        public byte PushRbp { get; }
        public byte JmpOp { get; }
        public int JmpOffset { get; }

        public _UNEXPECTED_INTERRUPT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _UNEXPECTED_INTERRUPT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_UNEXPECTED_INTERRUPT.PushImm),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_UNEXPECTED_INTERRUPT.Vector),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_UNEXPECTED_INTERRUPT.PushRbp),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_UNEXPECTED_INTERRUPT.JmpOp),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_UNEXPECTED_INTERRUPT.JmpOffset),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_UNEXPECTED_INTERRUPT>((mem, ptr) => new _UNEXPECTED_INTERRUPT(mem, ptr), offsets);
        }
    }
}