using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_FS_FILTER_CALLBACKS")]
    public sealed class FsFilterCallbacks : DynamicStructure
    {
        [Offset(0UL)]
        public uint SizeOfFsFilterCallbacks { get => ReadHere<uint>(nameof(SizeOfFsFilterCallbacks)); set => WriteHere(nameof(SizeOfFsFilterCallbacks), value); }

        [Offset(4UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(8UL)]
        public IntPtr PreAcquireForSectionSynchronization { get => ReadHere<IntPtr>(nameof(PreAcquireForSectionSynchronization)); set => WriteHere(nameof(PreAcquireForSectionSynchronization), value); }

        [Offset(16UL)]
        public IntPtr PostAcquireForSectionSynchronization { get => ReadHere<IntPtr>(nameof(PostAcquireForSectionSynchronization)); set => WriteHere(nameof(PostAcquireForSectionSynchronization), value); }

        [Offset(24UL)]
        public IntPtr PreReleaseForSectionSynchronization { get => ReadHere<IntPtr>(nameof(PreReleaseForSectionSynchronization)); set => WriteHere(nameof(PreReleaseForSectionSynchronization), value); }

        [Offset(32UL)]
        public IntPtr PostReleaseForSectionSynchronization { get => ReadHere<IntPtr>(nameof(PostReleaseForSectionSynchronization)); set => WriteHere(nameof(PostReleaseForSectionSynchronization), value); }

        [Offset(40UL)]
        public IntPtr PreAcquireForCcFlush { get => ReadHere<IntPtr>(nameof(PreAcquireForCcFlush)); set => WriteHere(nameof(PreAcquireForCcFlush), value); }

        [Offset(48UL)]
        public IntPtr PostAcquireForCcFlush { get => ReadHere<IntPtr>(nameof(PostAcquireForCcFlush)); set => WriteHere(nameof(PostAcquireForCcFlush), value); }

        [Offset(56UL)]
        public IntPtr PreReleaseForCcFlush { get => ReadHere<IntPtr>(nameof(PreReleaseForCcFlush)); set => WriteHere(nameof(PreReleaseForCcFlush), value); }

        [Offset(64UL)]
        public IntPtr PostReleaseForCcFlush { get => ReadHere<IntPtr>(nameof(PostReleaseForCcFlush)); set => WriteHere(nameof(PostReleaseForCcFlush), value); }

        [Offset(72UL)]
        public IntPtr PreAcquireForModifiedPageWriter { get => ReadHere<IntPtr>(nameof(PreAcquireForModifiedPageWriter)); set => WriteHere(nameof(PreAcquireForModifiedPageWriter), value); }

        [Offset(80UL)]
        public IntPtr PostAcquireForModifiedPageWriter { get => ReadHere<IntPtr>(nameof(PostAcquireForModifiedPageWriter)); set => WriteHere(nameof(PostAcquireForModifiedPageWriter), value); }

        [Offset(88UL)]
        public IntPtr PreReleaseForModifiedPageWriter { get => ReadHere<IntPtr>(nameof(PreReleaseForModifiedPageWriter)); set => WriteHere(nameof(PreReleaseForModifiedPageWriter), value); }

        [Offset(96UL)]
        public IntPtr PostReleaseForModifiedPageWriter { get => ReadHere<IntPtr>(nameof(PostReleaseForModifiedPageWriter)); set => WriteHere(nameof(PostReleaseForModifiedPageWriter), value); }

        [Offset(104UL)]
        public IntPtr PreQueryOpen { get => ReadHere<IntPtr>(nameof(PreQueryOpen)); set => WriteHere(nameof(PreQueryOpen), value); }

        [Offset(112UL)]
        public IntPtr PostQueryOpen { get => ReadHere<IntPtr>(nameof(PostQueryOpen)); set => WriteHere(nameof(PostQueryOpen), value); }

        public FsFilterCallbacks(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<FsFilterCallbacks>();
        }
    }
}