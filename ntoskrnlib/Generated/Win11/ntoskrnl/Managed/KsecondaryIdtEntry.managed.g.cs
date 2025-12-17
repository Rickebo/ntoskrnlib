using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KSECONDARY_IDT_ENTRY")]
    public sealed class KsecondaryIdtEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ulong SpinLock { get => ReadHere<ulong>(nameof(SpinLock)); set => WriteHere(nameof(SpinLock), value); }

        [Offset(8UL)]
        public Kevent ConnectLock { get => ReadStructure<Kevent>(nameof(ConnectLock)); set => WriteStructure(nameof(ConnectLock), value); }

        [Offset(32UL)]
        public byte LineMasked { get => ReadHere<byte>(nameof(LineMasked)); set => WriteHere(nameof(LineMasked), value); }

        [Offset(40UL)]
        public IntPtr InterruptList { get => ReadHere<IntPtr>(nameof(InterruptList)); set => WriteHere(nameof(InterruptList), value); }

        public KsecondaryIdtEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KsecondaryIdtEntry>();
        }
    }
}