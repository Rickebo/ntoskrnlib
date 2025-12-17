using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CALL_HASH_ENTRY")]
    public sealed class CallHashEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public IntPtr CallersAddress { get => ReadHere<IntPtr>(nameof(CallersAddress)); set => WriteHere(nameof(CallersAddress), value); }

        [Offset(24UL)]
        public IntPtr CallersCaller { get => ReadHere<IntPtr>(nameof(CallersCaller)); set => WriteHere(nameof(CallersCaller), value); }

        [Offset(32UL)]
        public uint CallCount { get => ReadHere<uint>(nameof(CallCount)); set => WriteHere(nameof(CallCount), value); }

        public CallHashEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CallHashEntry>();
        }
    }
}