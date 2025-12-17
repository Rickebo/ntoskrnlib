using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PS_SYSCALL_PROVIDER")]
    public sealed class PsSyscallProvider : DynamicStructure
    {
        public PsSyscallProvider(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PsSyscallProvider>();
        }
    }
}