using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_INTERRUPT_TRACKING_ROOT")]
    public sealed class InterruptTrackingRoot : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public ListEntry TrackingEntryList { get => ReadStructure<ListEntry>(nameof(TrackingEntryList)); set => WriteStructure(nameof(TrackingEntryList), value); }

        [Offset(32UL)]
        public uint Gsiv { get => ReadHere<uint>(nameof(Gsiv)); set => WriteHere(nameof(Gsiv), value); }

        [Offset(40UL)]
        public InterruptVectorData VectorData { get => ReadStructure<InterruptVectorData>(nameof(VectorData)); set => WriteStructure(nameof(VectorData), value); }

        [Offset(128UL)]
        public uint SteeringMode { get => ReadHere<uint>(nameof(SteeringMode)); set => WriteHere(nameof(SteeringMode), value); }

        [Offset(132UL)]
        public byte EnableSteering { get => ReadHere<byte>(nameof(EnableSteering)); set => WriteHere(nameof(EnableSteering), value); }

        [Offset(136UL)]
        public GroupAffinity CpuSetMask { get => ReadStructure<GroupAffinity>(nameof(CpuSetMask)); set => WriteStructure(nameof(CpuSetMask), value); }

        [Offset(152UL)]
        public ulong AffinityEpoch { get => ReadHere<ulong>(nameof(AffinityEpoch)); set => WriteHere(nameof(AffinityEpoch), value); }

        [Offset(160UL)]
        public GroupAffinity CurrentTarget { get => ReadStructure<GroupAffinity>(nameof(CurrentTarget)); set => WriteStructure(nameof(CurrentTarget), value); }

        [Offset(176UL)]
        public GroupAffinity NextTarget { get => ReadStructure<GroupAffinity>(nameof(NextTarget)); set => WriteStructure(nameof(NextTarget), value); }

        [Offset(192UL)]
        public ulong TimeDelta { get => ReadHere<ulong>(nameof(TimeDelta)); set => WriteHere(nameof(TimeDelta), value); }

        [Offset(200UL)]
        public IntPtr RedirectHandle { get => ReadHere<IntPtr>(nameof(RedirectHandle)); set => WriteHere(nameof(RedirectHandle), value); }

        [Offset(208UL)]
        public ListEntry SteerQueueLink { get => ReadStructure<ListEntry>(nameof(SteerQueueLink)); set => WriteStructure(nameof(SteerQueueLink), value); }

        public InterruptTrackingRoot(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<InterruptTrackingRoot>();
        }
    }
}