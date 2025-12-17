using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IO_COMPLETION_CONTEXT")]
    public sealed class IoCompletionContext : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Port { get => ReadHere<IntPtr>(nameof(Port)); set => WriteHere(nameof(Port), value); }

        [Offset(8UL)]
        public IntPtr Key { get => ReadHere<IntPtr>(nameof(Key)); set => WriteHere(nameof(Key), value); }

        [Offset(16UL)]
        public long UsageCount { get => ReadHere<long>(nameof(UsageCount)); set => WriteHere(nameof(UsageCount), value); }

        public IoCompletionContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IoCompletionContext>();
        }
    }
}