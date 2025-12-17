using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KCLOCK_INCREMENT_TRACE")]
    public sealed class KclockIncrementTrace : DynamicStructure
    {
        [Offset(0UL)]
        public uint ActualIncrement { get => ReadHere<uint>(nameof(ActualIncrement)); set => WriteHere(nameof(ActualIncrement), value); }

        [Offset(4UL)]
        public uint RequestedIncrement { get => ReadHere<uint>(nameof(RequestedIncrement)); set => WriteHere(nameof(RequestedIncrement), value); }

        [Offset(8UL)]
        public ulong InterruptTime { get => ReadHere<ulong>(nameof(InterruptTime)); set => WriteHere(nameof(InterruptTime), value); }

        [Offset(16UL)]
        public ulong PerformanceCounter { get => ReadHere<ulong>(nameof(PerformanceCounter)); set => WriteHere(nameof(PerformanceCounter), value); }

        [Offset(24UL)]
        public byte OneShot { get => ReadHere<byte>(nameof(OneShot)); set => WriteHere(nameof(OneShot), value); }

        public KclockIncrementTrace(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KclockIncrementTrace>();
        }
    }
}