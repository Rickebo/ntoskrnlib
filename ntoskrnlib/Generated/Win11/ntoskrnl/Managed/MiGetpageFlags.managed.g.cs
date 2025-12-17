using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_GETPAGE_FLAGS")]
    public sealed class MiGetpageFlags : DynamicStructure
    {
        [Offset(0UL)]
        public uint EntireField { get => ReadHere<uint>(nameof(EntireField)); set => WriteHere(nameof(EntireField), value); }

        [Offset(0UL)]
        public uint AtDpc { get => ReadHere<uint>(nameof(AtDpc)); set => WriteHere(nameof(AtDpc), value); }

        [Offset(0UL)]
        public uint PageLockHeld { get => ReadHere<uint>(nameof(PageLockHeld)); set => WriteHere(nameof(PageLockHeld), value); }

        [Offset(0UL)]
        public uint RecursingToDemote { get => ReadHere<uint>(nameof(RecursingToDemote)); set => WriteHere(nameof(RecursingToDemote), value); }

        [Offset(0UL)]
        public uint PageAttributeOptional { get => ReadHere<uint>(nameof(PageAttributeOptional)); set => WriteHere(nameof(PageAttributeOptional), value); }

        [Offset(0UL)]
        public uint PreferZero { get => ReadHere<uint>(nameof(PreferZero)); set => WriteHere(nameof(PreferZero), value); }

        [Offset(0UL)]
        public uint RequireZero { get => ReadHere<uint>(nameof(RequireZero)); set => WriteHere(nameof(RequireZero), value); }

        [Offset(0UL)]
        public uint ColorAlignment { get => ReadHere<uint>(nameof(ColorAlignment)); set => WriteHere(nameof(ColorAlignment), value); }

        [Offset(0UL)]
        public uint SystemUse { get => ReadHere<uint>(nameof(SystemUse)); set => WriteHere(nameof(SystemUse), value); }

        [Offset(0UL)]
        public uint PreserveAvailable { get => ReadHere<uint>(nameof(PreserveAvailable)); set => WriteHere(nameof(PreserveAvailable), value); }

        [Offset(0UL)]
        public uint IgnoreAvailable { get => ReadHere<uint>(nameof(IgnoreAvailable)); set => WriteHere(nameof(IgnoreAvailable), value); }

        [Offset(0UL)]
        public uint ContendForListLocks { get => ReadHere<uint>(nameof(ContendForListLocks)); set => WriteHere(nameof(ContendForListLocks), value); }

        [Offset(0UL)]
        public uint DontDemoteLargePages { get => ReadHere<uint>(nameof(DontDemoteLargePages)); set => WriteHere(nameof(DontDemoteLargePages), value); }

        [Offset(0UL)]
        public uint NodeMandatory { get => ReadHere<uint>(nameof(NodeMandatory)); set => WriteHere(nameof(NodeMandatory), value); }

        [Offset(0UL)]
        public uint ChannelMandatory { get => ReadHere<uint>(nameof(ChannelMandatory)); set => WriteHere(nameof(ChannelMandatory), value); }

        [Offset(0UL)]
        public uint DontDemote { get => ReadHere<uint>(nameof(DontDemote)); set => WriteHere(nameof(DontDemote), value); }

        [Offset(0UL)]
        public uint DontDemote64KPages { get => ReadHere<uint>(nameof(DontDemote64KPages)); set => WriteHere(nameof(DontDemote64KPages), value); }

        [Offset(0UL)]
        public uint NoStandby { get => ReadHere<uint>(nameof(NoStandby)); set => WriteHere(nameof(NoStandby), value); }

        [Offset(0UL)]
        public uint NoStandbySwap { get => ReadHere<uint>(nameof(NoStandbySwap)); set => WriteHere(nameof(NoStandbySwap), value); }

        [Offset(0UL)]
        public uint OnlyStandby { get => ReadHere<uint>(nameof(OnlyStandby)); set => WriteHere(nameof(OnlyStandby), value); }

        [Offset(0UL)]
        public uint FreeZeroQueryIncludeLarge { get => ReadHere<uint>(nameof(FreeZeroQueryIncludeLarge)); set => WriteHere(nameof(FreeZeroQueryIncludeLarge), value); }

        [Offset(0UL)]
        public uint MustBeZero { get => ReadHere<uint>(nameof(MustBeZero)); set => WriteHere(nameof(MustBeZero), value); }

        public MiGetpageFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiGetpageFlags>();
        }
    }
}