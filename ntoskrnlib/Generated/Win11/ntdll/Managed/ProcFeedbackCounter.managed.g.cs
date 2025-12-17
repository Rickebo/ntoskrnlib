using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PROC_FEEDBACK_COUNTER")]
    public sealed class ProcFeedbackCounter : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr InstantaneousRead { get => ReadHere<IntPtr>(nameof(InstantaneousRead)); set => WriteHere(nameof(InstantaneousRead), value); }

        [Offset(0UL)]
        public IntPtr DifferentialRead { get => ReadHere<IntPtr>(nameof(DifferentialRead)); set => WriteHere(nameof(DifferentialRead), value); }

        [Offset(8UL)]
        public ulong LastActualCount { get => ReadHere<ulong>(nameof(LastActualCount)); set => WriteHere(nameof(LastActualCount), value); }

        [Offset(16UL)]
        public ulong LastReferenceCount { get => ReadHere<ulong>(nameof(LastReferenceCount)); set => WriteHere(nameof(LastReferenceCount), value); }

        [Offset(24UL)]
        public uint CachedValue { get => ReadHere<uint>(nameof(CachedValue)); set => WriteHere(nameof(CachedValue), value); }

        [Offset(32UL)]
        public byte Affinitized { get => ReadHere<byte>(nameof(Affinitized)); set => WriteHere(nameof(Affinitized), value); }

        [Offset(33UL)]
        public byte Differential { get => ReadHere<byte>(nameof(Differential)); set => WriteHere(nameof(Differential), value); }

        [Offset(34UL)]
        public byte DiscardIdleTime { get => ReadHere<byte>(nameof(DiscardIdleTime)); set => WriteHere(nameof(DiscardIdleTime), value); }

        [Offset(36UL)]
        public uint Scaling { get => ReadHere<uint>(nameof(Scaling)); set => WriteHere(nameof(Scaling), value); }

        [Offset(40UL)]
        public ulong Context { get => ReadHere<ulong>(nameof(Context)); set => WriteHere(nameof(Context), value); }

        public ProcFeedbackCounter(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcFeedbackCounter>();
        }
    }
}