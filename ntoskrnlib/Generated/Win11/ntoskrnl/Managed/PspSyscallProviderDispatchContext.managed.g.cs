using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PSP_SYSCALL_PROVIDER_DISPATCH_CONTEXT")]
    public sealed class PspSyscallProviderDispatchContext : DynamicStructure
    {
        [Offset(0UL)]
        public uint Level { get => ReadHere<uint>(nameof(Level)); set => WriteHere(nameof(Level), value); }

        [Offset(4UL)]
        public uint Slot { get => ReadHere<uint>(nameof(Slot)); set => WriteHere(nameof(Slot), value); }

        public PspSyscallProviderDispatchContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PspSyscallProviderDispatchContext>();
        }
    }
}