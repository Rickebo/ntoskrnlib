using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EXCEPTION_POINTERS")]
    public sealed class _EXCEPTION_POINTERS : DynamicStructure
    {
        public IntPtr ExceptionRecord { get; }
        public IntPtr ContextRecord { get; }

        public _EXCEPTION_POINTERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXCEPTION_POINTERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXCEPTION_POINTERS.ExceptionRecord),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXCEPTION_POINTERS.ContextRecord),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_EXCEPTION_POINTERS>((mem, ptr) => new _EXCEPTION_POINTERS(mem, ptr), offsets);
        }
    }
}