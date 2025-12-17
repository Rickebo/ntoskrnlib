using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KSWAPPABLE_PAGE")]
    public sealed class KswappablePage : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr RegionStart { get => ReadHere<IntPtr>(nameof(RegionStart)); set => WriteHere(nameof(RegionStart), value); }

        [Offset(8UL)]
        public ulong TransitionLock { get => ReadHere<ulong>(nameof(TransitionLock)); set => WriteHere(nameof(TransitionLock), value); }

        [Offset(16UL)]
        public KswappablePageRefCount LockCount { get => ReadStructure<KswappablePageRefCount>(nameof(LockCount)); set => WriteStructure(nameof(LockCount), value); }

        [Offset(24UL)]
        public Mdl Mdl { get => ReadStructure<Mdl>(nameof(Mdl)); set => WriteStructure(nameof(Mdl), value); }

        [Offset(72UL)]
        public ulong PageNumber { get => ReadHere<ulong>(nameof(PageNumber)); set => WriteHere(nameof(PageNumber), value); }

        public KswappablePage(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KswappablePage>();
        }
    }
}