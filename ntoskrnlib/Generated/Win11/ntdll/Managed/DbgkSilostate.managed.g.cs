using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_DBGK_SILOSTATE")]
    public sealed class DbgkSilostate : DynamicStructure
    {
        [Offset(0UL)]
        public ExPushLock ErrorPortLock { get => ReadStructure<ExPushLock>(nameof(ErrorPortLock)); set => WriteStructure(nameof(ErrorPortLock), value); }

        [Offset(8UL)]
        public IntPtr ErrorPort { get => ReadHere<IntPtr>(nameof(ErrorPort)); set => WriteHere(nameof(ErrorPort), value); }

        [Offset(16UL)]
        public IntPtr ErrorProcess { get => ReadHere<IntPtr>(nameof(ErrorProcess)); set => WriteHere(nameof(ErrorProcess), value); }

        [Offset(24UL)]
        public IntPtr ErrorPortRegisteredEvent { get => ReadHere<IntPtr>(nameof(ErrorPortRegisteredEvent)); set => WriteHere(nameof(ErrorPortRegisteredEvent), value); }

        public DbgkSilostate(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkSilostate>();
        }
    }
}