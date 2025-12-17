using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EXCEPTION_REGISTRATION_RECORD")]
    public sealed class _EXCEPTION_REGISTRATION_RECORD : DynamicStructure
    {
        public IntPtr Next { get; }
        public IntPtr Handler { get; }

        public _EXCEPTION_REGISTRATION_RECORD(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXCEPTION_REGISTRATION_RECORD()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXCEPTION_REGISTRATION_RECORD.Next),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXCEPTION_REGISTRATION_RECORD.Handler),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_EXCEPTION_REGISTRATION_RECORD>((mem, ptr) => new _EXCEPTION_REGISTRATION_RECORD(mem, ptr), offsets);
        }
    }
}