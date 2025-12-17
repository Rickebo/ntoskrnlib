using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_STANDBY_STATE")]
    public sealed class MiStandbyState : DynamicStructure
    {
        [Offset(0UL)]
        public ulong FirstDecayPage { get => ReadHere<ulong>(nameof(FirstDecayPage)); set => WriteHere(nameof(FirstDecayPage), value); }

        [Offset(16UL)]
        public SlistHeader PfnDecayFreeSList { get => ReadStructure<SlistHeader>(nameof(PfnDecayFreeSList)); set => WriteStructure(nameof(PfnDecayFreeSList), value); }

        [Offset(32UL)]
        public int DecayPfnLock { get => ReadHere<int>(nameof(DecayPfnLock)); set => WriteHere(nameof(DecayPfnLock), value); }

        [Offset(40UL)]
        public RtlBitmap DecayPfnsToBeFreed { get => ReadStructure<RtlBitmap>(nameof(DecayPfnsToBeFreed)); set => WriteStructure(nameof(DecayPfnsToBeFreed), value); }

        [Offset(56UL)]
        [Length(64)]
        public DynamicArray DecayPfnsToBeFreedBuffer { get => ReadStructure<DynamicArray>(nameof(DecayPfnsToBeFreedBuffer)); set => WriteStructure(nameof(DecayPfnsToBeFreedBuffer), value); }

        [Offset(320UL)]
        public SlistHeader PageHeatListSlist { get => ReadStructure<SlistHeader>(nameof(PageHeatListSlist)); set => WriteStructure(nameof(PageHeatListSlist), value); }

        [Offset(336UL)]
        public int PageHeatListDisableAllocation { get => ReadHere<int>(nameof(PageHeatListDisableAllocation)); set => WriteHere(nameof(PageHeatListDisableAllocation), value); }

        [Offset(340UL)]
        public uint TransitionPagesMadeCold { get => ReadHere<uint>(nameof(TransitionPagesMadeCold)); set => WriteHere(nameof(TransitionPagesMadeCold), value); }

        public MiStandbyState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiStandbyState>();
        }
    }
}