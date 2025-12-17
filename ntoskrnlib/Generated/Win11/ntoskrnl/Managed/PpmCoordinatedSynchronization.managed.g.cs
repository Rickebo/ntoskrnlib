using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PPM_COORDINATED_SYNCHRONIZATION")]
    public sealed class PpmCoordinatedSynchronization : DynamicStructure
    {
        [Offset(0UL)]
        public int AsLong { get => ReadHere<int>(nameof(AsLong)); set => WriteHere(nameof(AsLong), value); }

        [Offset(0UL)]
        public uint EnterProcessor { get => ReadHere<uint>(nameof(EnterProcessor)); set => WriteHere(nameof(EnterProcessor), value); }

        [Offset(0UL)]
        public uint ExitProcessor { get => ReadHere<uint>(nameof(ExitProcessor)); set => WriteHere(nameof(ExitProcessor), value); }

        [Offset(0UL)]
        public uint Transition { get => ReadHere<uint>(nameof(Transition)); set => WriteHere(nameof(Transition), value); }

        [Offset(0UL)]
        public uint Entered { get => ReadHere<uint>(nameof(Entered)); set => WriteHere(nameof(Entered), value); }

        [Offset(0UL)]
        public uint EntryPriority { get => ReadHere<uint>(nameof(EntryPriority)); set => WriteHere(nameof(EntryPriority), value); }

        public PpmCoordinatedSynchronization(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PpmCoordinatedSynchronization>();
        }
    }
}