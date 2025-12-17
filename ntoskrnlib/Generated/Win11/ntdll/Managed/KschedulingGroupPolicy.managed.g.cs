using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KSCHEDULING_GROUP_POLICY")]
    public sealed class KschedulingGroupPolicy : DynamicStructure
    {
        [Offset(0UL)]
        public uint Value { get => ReadHere<uint>(nameof(Value)); set => WriteHere(nameof(Value), value); }

        [Offset(0UL)]
        public ushort Weight { get => ReadHere<ushort>(nameof(Weight)); set => WriteHere(nameof(Weight), value); }

        [Offset(0UL)]
        public ushort MinRate { get => ReadHere<ushort>(nameof(MinRate)); set => WriteHere(nameof(MinRate), value); }

        [Offset(2UL)]
        public ushort MaxRate { get => ReadHere<ushort>(nameof(MaxRate)); set => WriteHere(nameof(MaxRate), value); }

        [Offset(4UL)]
        public uint AllFlags { get => ReadHere<uint>(nameof(AllFlags)); set => WriteHere(nameof(AllFlags), value); }

        [Offset(4UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(4UL)]
        public uint Disabled { get => ReadHere<uint>(nameof(Disabled)); set => WriteHere(nameof(Disabled), value); }

        [Offset(4UL)]
        public uint RankBias { get => ReadHere<uint>(nameof(RankBias)); set => WriteHere(nameof(RankBias), value); }

        [Offset(4UL)]
        public uint PerProcessorLimits { get => ReadHere<uint>(nameof(PerProcessorLimits)); set => WriteHere(nameof(PerProcessorLimits), value); }

        [Offset(4UL)]
        public uint Spare1 { get => ReadHere<uint>(nameof(Spare1)); set => WriteHere(nameof(Spare1), value); }

        public KschedulingGroupPolicy(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KschedulingGroupPolicy>();
        }
    }
}