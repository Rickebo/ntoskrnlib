using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMSECTION_FLAGS")]
    public sealed class MmsectionFlags : DynamicStructure
    {
        [Offset(0UL)]
        public uint BeingDeleted { get => ReadHere<uint>(nameof(BeingDeleted)); set => WriteHere(nameof(BeingDeleted), value); }

        [Offset(0UL)]
        public uint BeingCreated { get => ReadHere<uint>(nameof(BeingCreated)); set => WriteHere(nameof(BeingCreated), value); }

        [Offset(0UL)]
        public uint BeingPurged { get => ReadHere<uint>(nameof(BeingPurged)); set => WriteHere(nameof(BeingPurged), value); }

        [Offset(0UL)]
        public uint NoModifiedWriting { get => ReadHere<uint>(nameof(NoModifiedWriting)); set => WriteHere(nameof(NoModifiedWriting), value); }

        [Offset(0UL)]
        public uint FailAllIo { get => ReadHere<uint>(nameof(FailAllIo)); set => WriteHere(nameof(FailAllIo), value); }

        [Offset(0UL)]
        public uint Image { get => ReadHere<uint>(nameof(Image)); set => WriteHere(nameof(Image), value); }

        [Offset(0UL)]
        public uint Based { get => ReadHere<uint>(nameof(Based)); set => WriteHere(nameof(Based), value); }

        [Offset(0UL)]
        public uint File { get => ReadHere<uint>(nameof(File)); set => WriteHere(nameof(File), value); }

        [Offset(0UL)]
        public uint SectionOfInterest { get => ReadHere<uint>(nameof(SectionOfInterest)); set => WriteHere(nameof(SectionOfInterest), value); }

        [Offset(0UL)]
        public uint PrefetchCreated { get => ReadHere<uint>(nameof(PrefetchCreated)); set => WriteHere(nameof(PrefetchCreated), value); }

        [Offset(0UL)]
        public uint PhysicalMemory { get => ReadHere<uint>(nameof(PhysicalMemory)); set => WriteHere(nameof(PhysicalMemory), value); }

        [Offset(0UL)]
        public uint ImageControlAreaOnRemovableMedia { get => ReadHere<uint>(nameof(ImageControlAreaOnRemovableMedia)); set => WriteHere(nameof(ImageControlAreaOnRemovableMedia), value); }

        [Offset(0UL)]
        public uint Reserve { get => ReadHere<uint>(nameof(Reserve)); set => WriteHere(nameof(Reserve), value); }

        [Offset(0UL)]
        public uint Commit { get => ReadHere<uint>(nameof(Commit)); set => WriteHere(nameof(Commit), value); }

        [Offset(0UL)]
        public uint NoChange { get => ReadHere<uint>(nameof(NoChange)); set => WriteHere(nameof(NoChange), value); }

        [Offset(0UL)]
        public uint WasPurged { get => ReadHere<uint>(nameof(WasPurged)); set => WriteHere(nameof(WasPurged), value); }

        [Offset(0UL)]
        public uint UserReference { get => ReadHere<uint>(nameof(UserReference)); set => WriteHere(nameof(UserReference), value); }

        [Offset(0UL)]
        public uint GlobalMemory { get => ReadHere<uint>(nameof(GlobalMemory)); set => WriteHere(nameof(GlobalMemory), value); }

        [Offset(0UL)]
        public uint DeleteOnClose { get => ReadHere<uint>(nameof(DeleteOnClose)); set => WriteHere(nameof(DeleteOnClose), value); }

        [Offset(0UL)]
        public uint FilePointerNull { get => ReadHere<uint>(nameof(FilePointerNull)); set => WriteHere(nameof(FilePointerNull), value); }

        [Offset(0UL)]
        public uint PreferredNode { get => ReadHere<uint>(nameof(PreferredNode)); set => WriteHere(nameof(PreferredNode), value); }

        [Offset(0UL)]
        public uint GlobalOnlyPerSession { get => ReadHere<uint>(nameof(GlobalOnlyPerSession)); set => WriteHere(nameof(GlobalOnlyPerSession), value); }

        [Offset(0UL)]
        public uint ControlAreaOnUnusedList { get => ReadHere<uint>(nameof(ControlAreaOnUnusedList)); set => WriteHere(nameof(ControlAreaOnUnusedList), value); }

        [Offset(0UL)]
        public uint SystemVaAllocated { get => ReadHere<uint>(nameof(SystemVaAllocated)); set => WriteHere(nameof(SystemVaAllocated), value); }

        [Offset(0UL)]
        public uint NotBeingUsed { get => ReadHere<uint>(nameof(NotBeingUsed)); set => WriteHere(nameof(NotBeingUsed), value); }

        [Offset(0UL)]
        public uint PageSize64K { get => ReadHere<uint>(nameof(PageSize64K)); set => WriteHere(nameof(PageSize64K), value); }

        public MmsectionFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmsectionFlags>();
        }
    }
}