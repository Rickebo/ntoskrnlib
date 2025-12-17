using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_XSTATE_CONFIGURATION")]
    public sealed class XstateConfiguration : DynamicStructure
    {
        [Offset(0UL)]
        public ulong EnabledFeatures { get => ReadHere<ulong>(nameof(EnabledFeatures)); set => WriteHere(nameof(EnabledFeatures), value); }

        [Offset(8UL)]
        public ulong EnabledVolatileFeatures { get => ReadHere<ulong>(nameof(EnabledVolatileFeatures)); set => WriteHere(nameof(EnabledVolatileFeatures), value); }

        [Offset(16UL)]
        public uint Size { get => ReadHere<uint>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(20UL)]
        public uint ControlFlags { get => ReadHere<uint>(nameof(ControlFlags)); set => WriteHere(nameof(ControlFlags), value); }

        [Offset(20UL)]
        public uint OptimizedSave { get => ReadHere<uint>(nameof(OptimizedSave)); set => WriteHere(nameof(OptimizedSave), value); }

        [Offset(20UL)]
        public uint CompactionEnabled { get => ReadHere<uint>(nameof(CompactionEnabled)); set => WriteHere(nameof(CompactionEnabled), value); }

        [Offset(20UL)]
        public uint ExtendedFeatureDisable { get => ReadHere<uint>(nameof(ExtendedFeatureDisable)); set => WriteHere(nameof(ExtendedFeatureDisable), value); }

        [Offset(24UL)]
        [Length(64)]
        public DynamicArray Features { get => ReadStructure<DynamicArray>(nameof(Features)); set => WriteStructure(nameof(Features), value); }

        [Offset(536UL)]
        public ulong EnabledSupervisorFeatures { get => ReadHere<ulong>(nameof(EnabledSupervisorFeatures)); set => WriteHere(nameof(EnabledSupervisorFeatures), value); }

        [Offset(544UL)]
        public ulong AlignedFeatures { get => ReadHere<ulong>(nameof(AlignedFeatures)); set => WriteHere(nameof(AlignedFeatures), value); }

        [Offset(552UL)]
        public uint AllFeatureSize { get => ReadHere<uint>(nameof(AllFeatureSize)); set => WriteHere(nameof(AllFeatureSize), value); }

        [Offset(556UL)]
        [Length(64)]
        public DynamicArray AllFeatures { get => ReadStructure<DynamicArray>(nameof(AllFeatures)); set => WriteStructure(nameof(AllFeatures), value); }

        [Offset(816UL)]
        public ulong EnabledUserVisibleSupervisorFeatures { get => ReadHere<ulong>(nameof(EnabledUserVisibleSupervisorFeatures)); set => WriteHere(nameof(EnabledUserVisibleSupervisorFeatures), value); }

        [Offset(824UL)]
        public ulong ExtendedFeatureDisableFeatures { get => ReadHere<ulong>(nameof(ExtendedFeatureDisableFeatures)); set => WriteHere(nameof(ExtendedFeatureDisableFeatures), value); }

        [Offset(832UL)]
        public uint AllNonLargeFeatureSize { get => ReadHere<uint>(nameof(AllNonLargeFeatureSize)); set => WriteHere(nameof(AllNonLargeFeatureSize), value); }

        [Offset(836UL)]
        public ushort MaxSveVectorLength { get => ReadHere<ushort>(nameof(MaxSveVectorLength)); set => WriteHere(nameof(MaxSveVectorLength), value); }

        [Offset(838UL)]
        public ushort Spare1 { get => ReadHere<ushort>(nameof(Spare1)); set => WriteHere(nameof(Spare1), value); }

        public XstateConfiguration(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<XstateConfiguration>();
        }
    }
}