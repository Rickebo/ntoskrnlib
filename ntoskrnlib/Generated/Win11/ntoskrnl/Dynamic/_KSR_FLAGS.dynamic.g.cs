using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KSR_FLAGS")]
    public sealed class _KSR_FLAGS : DynamicStructure
    {
        public uint MpwrResume { get; }
        public uint Reserved { get; }
        public uint AsULong { get; }

        public _KSR_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KSR_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KSR_FLAGS.MpwrResume),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSR_FLAGS.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSR_FLAGS.AsULong),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KSR_FLAGS>((mem, ptr) => new _KSR_FLAGS(mem, ptr), offsets);
        }
    }
}