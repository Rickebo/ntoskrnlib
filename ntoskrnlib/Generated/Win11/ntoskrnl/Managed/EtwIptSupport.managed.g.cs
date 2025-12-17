using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_IPT_SUPPORT")]
    public sealed class EtwIptSupport : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr IptHandle { get => ReadHere<IntPtr>(nameof(IptHandle)); set => WriteHere(nameof(IptHandle), value); }

        [Offset(8UL)]
        public ulong IptOption { get => ReadHere<ulong>(nameof(IptOption)); set => WriteHere(nameof(IptOption), value); }

        [Offset(16UL)]
        public IntPtr EtwHwTraceExtInterface { get => ReadHere<IntPtr>(nameof(EtwHwTraceExtInterface)); set => WriteHere(nameof(EtwHwTraceExtInterface), value); }

        [Offset(24UL)]
        public uint HookIdCount { get => ReadHere<uint>(nameof(HookIdCount)); set => WriteHere(nameof(HookIdCount), value); }

        [Offset(28UL)]
        [Length(4)]
        public DynamicArray HookId { get => ReadStructure<DynamicArray>(nameof(HookId)); set => WriteStructure(nameof(HookId), value); }

        public EtwIptSupport(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwIptSupport>();
        }
    }
}