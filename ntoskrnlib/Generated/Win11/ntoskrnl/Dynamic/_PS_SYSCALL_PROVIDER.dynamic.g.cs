using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PS_SYSCALL_PROVIDER")]
    public sealed class _PS_SYSCALL_PROVIDER : DynamicStructure
    {
        public _PS_SYSCALL_PROVIDER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PS_SYSCALL_PROVIDER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_PS_SYSCALL_PROVIDER>((mem, ptr) => new _PS_SYSCALL_PROVIDER(mem, ptr), offsets);
        }
    }
}