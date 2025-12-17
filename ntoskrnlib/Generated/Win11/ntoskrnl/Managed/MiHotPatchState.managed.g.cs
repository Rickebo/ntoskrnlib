using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_HOT_PATCH_STATE")]
    public sealed class MiHotPatchState : DynamicStructure
    {
        [Offset(0UL)]
        public RtlAvlTree UserSidPatchLists { get => ReadStructure<RtlAvlTree>(nameof(UserSidPatchLists)); set => WriteStructure(nameof(UserSidPatchLists), value); }

        [Offset(8UL)]
        public RtlAvlTree GlobalHotPatchList { get => ReadStructure<RtlAvlTree>(nameof(GlobalHotPatchList)); set => WriteStructure(nameof(GlobalHotPatchList), value); }

        [Offset(16UL)]
        public RtlAvlTree PreviouslyRegisteredHotPatchList { get => ReadStructure<RtlAvlTree>(nameof(PreviouslyRegisteredHotPatchList)); set => WriteStructure(nameof(PreviouslyRegisteredHotPatchList), value); }

        [Offset(24UL)]
        public RtlAvlTree SecureImageActivePatches { get => ReadStructure<RtlAvlTree>(nameof(SecureImageActivePatches)); set => WriteStructure(nameof(SecureImageActivePatches), value); }

        [Offset(32UL)]
        public ExPushLock HotPatchListLock { get => ReadStructure<ExPushLock>(nameof(HotPatchListLock)); set => WriteStructure(nameof(HotPatchListLock), value); }

        [Offset(40UL)]
        public IntPtr InProgressPatchTableEntry { get => ReadHere<IntPtr>(nameof(InProgressPatchTableEntry)); set => WriteHere(nameof(InProgressPatchTableEntry), value); }

        [Offset(48UL)]
        public IntPtr InProgressBaseTableEntry { get => ReadHere<IntPtr>(nameof(InProgressBaseTableEntry)); set => WriteHere(nameof(InProgressBaseTableEntry), value); }

        [Offset(56UL)]
        public sbyte ReadyForPatchOperations { get => ReadHere<sbyte>(nameof(ReadyForPatchOperations)); set => WriteHere(nameof(ReadyForPatchOperations), value); }

        [Offset(60UL)]
        public uint HotPatchReserveSize { get => ReadHere<uint>(nameof(HotPatchReserveSize)); set => WriteHere(nameof(HotPatchReserveSize), value); }

        [Offset(64UL)]
        public uint DriverProxyReserveSize { get => ReadHere<uint>(nameof(DriverProxyReserveSize)); set => WriteHere(nameof(DriverProxyReserveSize), value); }

        [Offset(68UL)]
        public uint HotPatchingEnabled { get => ReadHere<uint>(nameof(HotPatchingEnabled)); set => WriteHere(nameof(HotPatchingEnabled), value); }

        [Offset(68UL)]
        public uint Spare { get => ReadHere<uint>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        public MiHotPatchState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiHotPatchState>();
        }
    }
}