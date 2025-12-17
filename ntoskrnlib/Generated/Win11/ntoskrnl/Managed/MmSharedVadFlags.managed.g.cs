using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MM_SHARED_VAD_FLAGS")]
    public sealed class MmSharedVadFlags : DynamicStructure
    {
        [Offset(0UL)]
        public uint Lock { get => ReadHere<uint>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(0UL)]
        public uint LockContended { get => ReadHere<uint>(nameof(LockContended)); set => WriteHere(nameof(LockContended), value); }

        [Offset(0UL)]
        public uint DeleteInProgress { get => ReadHere<uint>(nameof(DeleteInProgress)); set => WriteHere(nameof(DeleteInProgress), value); }

        [Offset(0UL)]
        public uint NoChange { get => ReadHere<uint>(nameof(NoChange)); set => WriteHere(nameof(NoChange), value); }

        [Offset(0UL)]
        public uint VadType { get => ReadHere<uint>(nameof(VadType)); set => WriteHere(nameof(VadType), value); }

        [Offset(0UL)]
        public uint Protection { get => ReadHere<uint>(nameof(Protection)); set => WriteHere(nameof(Protection), value); }

        [Offset(0UL)]
        public uint PreferredNode { get => ReadHere<uint>(nameof(PreferredNode)); set => WriteHere(nameof(PreferredNode), value); }

        [Offset(0UL)]
        public uint PageSize { get => ReadHere<uint>(nameof(PageSize)); set => WriteHere(nameof(PageSize), value); }

        [Offset(0UL)]
        public uint PrivateMemoryAlwaysClear { get => ReadHere<uint>(nameof(PrivateMemoryAlwaysClear)); set => WriteHere(nameof(PrivateMemoryAlwaysClear), value); }

        [Offset(0UL)]
        public uint PrivateFixup { get => ReadHere<uint>(nameof(PrivateFixup)); set => WriteHere(nameof(PrivateFixup), value); }

        [Offset(0UL)]
        public uint HotPatchState { get => ReadHere<uint>(nameof(HotPatchState)); set => WriteHere(nameof(HotPatchState), value); }

        public MmSharedVadFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmSharedVadFlags>();
        }
    }
}