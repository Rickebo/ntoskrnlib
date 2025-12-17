using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTL_HP_HEAP_VA_CALLBACKS_ENCODED")]
    public sealed class RtlHpHeapVaCallbacksEncoded : DynamicStructure
    {
        [Offset(0UL)]
        public ulong CallbackContext { get => ReadHere<ulong>(nameof(CallbackContext)); set => WriteHere(nameof(CallbackContext), value); }

        [Offset(8UL)]
        public ulong AllocateVirtualMemoryEncoded { get => ReadHere<ulong>(nameof(AllocateVirtualMemoryEncoded)); set => WriteHere(nameof(AllocateVirtualMemoryEncoded), value); }

        [Offset(16UL)]
        public ulong FreeVirtualMemoryEncoded { get => ReadHere<ulong>(nameof(FreeVirtualMemoryEncoded)); set => WriteHere(nameof(FreeVirtualMemoryEncoded), value); }

        [Offset(24UL)]
        public ulong QueryVirtualMemoryEncoded { get => ReadHere<ulong>(nameof(QueryVirtualMemoryEncoded)); set => WriteHere(nameof(QueryVirtualMemoryEncoded), value); }

        public RtlHpHeapVaCallbacksEncoded(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlHpHeapVaCallbacksEncoded>();
        }
    }
}