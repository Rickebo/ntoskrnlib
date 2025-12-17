using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_SHUTDOWN_STATE")]
    public sealed class MiShutdownState : DynamicStructure
    {
        [Offset(0UL)]
        public byte CrashDumpInitialized { get => ReadHere<byte>(nameof(CrashDumpInitialized)); set => WriteHere(nameof(CrashDumpInitialized), value); }

        [Offset(1UL)]
        public byte ConnectedStandbyActive { get => ReadHere<byte>(nameof(ConnectedStandbyActive)); set => WriteHere(nameof(ConnectedStandbyActive), value); }

        [Offset(2UL)]
        public byte ZeroPageFileAtShutdown { get => ReadHere<byte>(nameof(ZeroPageFileAtShutdown)); set => WriteHere(nameof(ZeroPageFileAtShutdown), value); }

        [Offset(3UL)]
        public byte CacheConflictsAllowed { get => ReadHere<byte>(nameof(CacheConflictsAllowed)); set => WriteHere(nameof(CacheConflictsAllowed), value); }

        [Offset(4UL)]
        public uint SystemShutdown { get => ReadHere<uint>(nameof(SystemShutdown)); set => WriteHere(nameof(SystemShutdown), value); }

        [Offset(8UL)]
        public int ShutdownFlushInProgress { get => ReadHere<int>(nameof(ShutdownFlushInProgress)); set => WriteHere(nameof(ShutdownFlushInProgress), value); }

        [Offset(12UL)]
        public uint MirroringActive { get => ReadHere<uint>(nameof(MirroringActive)); set => WriteHere(nameof(MirroringActive), value); }

        [Offset(16UL)]
        public MiResumeWorkitem ResumeItem { get => ReadStructure<MiResumeWorkitem>(nameof(ResumeItem)); set => WriteStructure(nameof(ResumeItem), value); }

        [Offset(72UL)]
        public IntPtr MirrorHoldsPfn { get => ReadHere<IntPtr>(nameof(MirrorHoldsPfn)); set => WriteHere(nameof(MirrorHoldsPfn), value); }

        [Offset(80UL)]
        [Length(2)]
        public DynamicArray MirrorBitMaps { get => ReadStructure<DynamicArray>(nameof(MirrorBitMaps)); set => WriteStructure(nameof(MirrorBitMaps), value); }

        [Offset(112UL)]
        public uint MirrorBitMapState { get => ReadHere<uint>(nameof(MirrorBitMapState)); set => WriteHere(nameof(MirrorBitMapState), value); }

        [Offset(120UL)]
        public IntPtr CrashDumpPte { get => ReadHere<IntPtr>(nameof(CrashDumpPte)); set => WriteHere(nameof(CrashDumpPte), value); }

        public MiShutdownState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiShutdownState>();
        }
    }
}