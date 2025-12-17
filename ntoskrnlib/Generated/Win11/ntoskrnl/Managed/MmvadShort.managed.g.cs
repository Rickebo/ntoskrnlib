using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMVAD_SHORT")]
    public sealed class MmvadShort : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr NextVad { get => ReadHere<IntPtr>(nameof(NextVad)); set => WriteHere(nameof(NextVad), value); }

        [Offset(8UL)]
        public IntPtr ExtraCreateInfo { get => ReadHere<IntPtr>(nameof(ExtraCreateInfo)); set => WriteHere(nameof(ExtraCreateInfo), value); }

        [Offset(0UL)]
        public RtlBalancedNode VadNode { get => ReadStructure<RtlBalancedNode>(nameof(VadNode)); set => WriteStructure(nameof(VadNode), value); }

        [Offset(24UL)]
        public uint StartingVpn { get => ReadHere<uint>(nameof(StartingVpn)); set => WriteHere(nameof(StartingVpn), value); }

        [Offset(28UL)]
        public uint EndingVpn { get => ReadHere<uint>(nameof(EndingVpn)); set => WriteHere(nameof(EndingVpn), value); }

        [Offset(32UL)]
        public byte StartingVpnHigh { get => ReadHere<byte>(nameof(StartingVpnHigh)); set => WriteHere(nameof(StartingVpnHigh), value); }

        [Offset(33UL)]
        public byte EndingVpnHigh { get => ReadHere<byte>(nameof(EndingVpnHigh)); set => WriteHere(nameof(EndingVpnHigh), value); }

        [Offset(34UL)]
        public byte CommitChargeHigh { get => ReadHere<byte>(nameof(CommitChargeHigh)); set => WriteHere(nameof(CommitChargeHigh), value); }

        [Offset(35UL)]
        public byte SpareNT64VadUChar { get => ReadHere<byte>(nameof(SpareNT64VadUChar)); set => WriteHere(nameof(SpareNT64VadUChar), value); }

        [Offset(36UL)]
        public int ReferenceCount { get => ReadHere<int>(nameof(ReferenceCount)); set => WriteHere(nameof(ReferenceCount), value); }

        [Offset(40UL)]
        public ExPushLock PushLock { get => ReadStructure<ExPushLock>(nameof(PushLock)); set => WriteStructure(nameof(PushLock), value); }

        [Offset(48UL)]
        public UnnamedTag u { get => ReadStructure<UnnamedTag>(nameof(u)); set => WriteStructure(nameof(u), value); }

        [Offset(52UL)]
        public uint CommitCharge { get => ReadHere<uint>(nameof(CommitCharge)); set => WriteHere(nameof(CommitCharge), value); }

        [Offset(56UL)]
        public UnnamedTag u5 { get => ReadStructure<UnnamedTag>(nameof(u5)); set => WriteStructure(nameof(u5), value); }

        public MmvadShort(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmvadShort>();
        }
    }
}