using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEA_RECOVERY_CONTEXT_PAGE_INFO")]
    public sealed class WheaRecoveryContextPageInfo : DynamicStructure
    {
        [Offset(0UL)]
        public uint ComponentTag { get => ReadHere<uint>(nameof(ComponentTag)); set => WriteHere(nameof(ComponentTag), value); }

        [Offset(4UL)]
        public int PageStatus { get => ReadHere<int>(nameof(PageStatus)); set => WriteHere(nameof(PageStatus), value); }

        [Offset(8UL)]
        public uint ActionTaken { get => ReadHere<uint>(nameof(ActionTaken)); set => WriteHere(nameof(ActionTaken), value); }

        [Offset(12UL)]
        public WheaInUsePageNotifyFlags NotifyFlags { get => ReadStructure<WheaInUsePageNotifyFlags>(nameof(NotifyFlags)); set => WriteStructure(nameof(NotifyFlags), value); }

        [Offset(13UL)]
        public byte ImmediateSuccess { get => ReadHere<byte>(nameof(ImmediateSuccess)); set => WriteHere(nameof(ImmediateSuccess), value); }

        [Offset(14UL)]
        public ushort Reserved { get => ReadHere<ushort>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(16UL)]
        public WheaRecoveryContextActionTakenAdditionalInfo ActionTakenAdditionalInfo { get => ReadStructure<WheaRecoveryContextActionTakenAdditionalInfo>(nameof(ActionTakenAdditionalInfo)); set => WriteStructure(nameof(ActionTakenAdditionalInfo), value); }

        public WheaRecoveryContextPageInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaRecoveryContextPageInfo>();
        }
    }
}