using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PENDING_RELATIONS_LIST_ENTRY")]
    public sealed class PendingRelationsListEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry Link { get => ReadStructure<ListEntry>(nameof(Link)); set => WriteStructure(nameof(Link), value); }

        [Offset(16UL)]
        public WorkQueueItem WorkItem { get => ReadStructure<WorkQueueItem>(nameof(WorkItem)); set => WriteStructure(nameof(WorkItem), value); }

        [Offset(48UL)]
        public IntPtr DeviceEvent { get => ReadHere<IntPtr>(nameof(DeviceEvent)); set => WriteHere(nameof(DeviceEvent), value); }

        [Offset(56UL)]
        public IntPtr DeviceObject { get => ReadHere<IntPtr>(nameof(DeviceObject)); set => WriteHere(nameof(DeviceObject), value); }

        [Offset(64UL)]
        public IntPtr RelationsList { get => ReadHere<IntPtr>(nameof(RelationsList)); set => WriteHere(nameof(RelationsList), value); }

        [Offset(72UL)]
        public IntPtr EjectIrp { get => ReadHere<IntPtr>(nameof(EjectIrp)); set => WriteHere(nameof(EjectIrp), value); }

        [Offset(80UL)]
        public uint Lock { get => ReadHere<uint>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(84UL)]
        public uint Problem { get => ReadHere<uint>(nameof(Problem)); set => WriteHere(nameof(Problem), value); }

        [Offset(88UL)]
        public byte ProfileChangingEject { get => ReadHere<byte>(nameof(ProfileChangingEject)); set => WriteHere(nameof(ProfileChangingEject), value); }

        [Offset(89UL)]
        public byte DisplaySafeRemovalDialog { get => ReadHere<byte>(nameof(DisplaySafeRemovalDialog)); set => WriteHere(nameof(DisplaySafeRemovalDialog), value); }

        [Offset(92UL)]
        public uint LightestSleepState { get => ReadHere<uint>(nameof(LightestSleepState)); set => WriteHere(nameof(LightestSleepState), value); }

        [Offset(96UL)]
        public IntPtr DockInterface { get => ReadHere<IntPtr>(nameof(DockInterface)); set => WriteHere(nameof(DockInterface), value); }

        [Offset(104UL)]
        public byte DequeuePending { get => ReadHere<byte>(nameof(DequeuePending)); set => WriteHere(nameof(DequeuePending), value); }

        [Offset(108UL)]
        public uint DeleteType { get => ReadHere<uint>(nameof(DeleteType)); set => WriteHere(nameof(DeleteType), value); }

        public PendingRelationsListEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PendingRelationsListEntry>();
        }
    }
}