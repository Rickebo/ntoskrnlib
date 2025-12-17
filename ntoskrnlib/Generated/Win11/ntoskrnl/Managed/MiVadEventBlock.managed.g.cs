using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_VAD_EVENT_BLOCK")]
    public sealed class MiVadEventBlock : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Next { get => ReadHere<IntPtr>(nameof(Next)); set => WriteHere(nameof(Next), value); }

        [Offset(8UL)]
        public Kgate Gate { get => ReadStructure<Kgate>(nameof(Gate)); set => WriteStructure(nameof(Gate), value); }

        [Offset(8UL)]
        public MmaddressList SecureInfo { get => ReadStructure<MmaddressList>(nameof(SecureInfo)); set => WriteStructure(nameof(SecureInfo), value); }

        [Offset(8UL)]
        public MiWriteWatchBlock WriteWatch { get => ReadStructure<MiWriteWatchBlock>(nameof(WriteWatch)); set => WriteStructure(nameof(WriteWatch), value); }

        [Offset(8UL)]
        public IntPtr InPageSupport { get => ReadHere<IntPtr>(nameof(InPageSupport)); set => WriteHere(nameof(InPageSupport), value); }

        [Offset(8UL)]
        public MiLargepageVadInfo LargePage { get => ReadStructure<MiLargepageVadInfo>(nameof(LargePage)); set => WriteStructure(nameof(LargePage), value); }

        [Offset(8UL)]
        public MiPhysicalView AweView { get => ReadStructure<MiPhysicalView>(nameof(AweView)); set => WriteStructure(nameof(AweView), value); }

        [Offset(8UL)]
        public IntPtr CreatingThread { get => ReadHere<IntPtr>(nameof(CreatingThread)); set => WriteHere(nameof(CreatingThread), value); }

        [Offset(8UL)]
        public MiSUB64KFreeRanges PebTeb { get => ReadStructure<MiSUB64KFreeRanges>(nameof(PebTeb)); set => WriteStructure(nameof(PebTeb), value); }

        [Offset(8UL)]
        public IntPtr PlaceholderVad { get => ReadHere<IntPtr>(nameof(PlaceholderVad)); set => WriteHere(nameof(PlaceholderVad), value); }

        [Offset(8UL)]
        public IntPtr HotPatchEntry { get => ReadHere<IntPtr>(nameof(HotPatchEntry)); set => WriteHere(nameof(HotPatchEntry), value); }

        [Offset(80UL)]
        public uint WaitReason { get => ReadHere<uint>(nameof(WaitReason)); set => WriteHere(nameof(WaitReason), value); }

        [Offset(84UL)]
        public uint CaseSpecificFlags { get => ReadHere<uint>(nameof(CaseSpecificFlags)); set => WriteHere(nameof(CaseSpecificFlags), value); }

        public MiVadEventBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiVadEventBlock>();
        }
    }
}