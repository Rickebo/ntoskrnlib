using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KTHREAD_COUNTERS")]
    public sealed class KthreadCounters : DynamicStructure
    {
        [Offset(0UL)]
        public ulong WaitReasonBitMap { get => ReadHere<ulong>(nameof(WaitReasonBitMap)); set => WriteHere(nameof(WaitReasonBitMap), value); }

        [Offset(8UL)]
        public IntPtr UserData { get => ReadHere<IntPtr>(nameof(UserData)); set => WriteHere(nameof(UserData), value); }

        [Offset(16UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(20UL)]
        public uint ContextSwitches { get => ReadHere<uint>(nameof(ContextSwitches)); set => WriteHere(nameof(ContextSwitches), value); }

        [Offset(24UL)]
        public ulong CycleTimeBias { get => ReadHere<ulong>(nameof(CycleTimeBias)); set => WriteHere(nameof(CycleTimeBias), value); }

        [Offset(32UL)]
        public ulong HardwareCounters { get => ReadHere<ulong>(nameof(HardwareCounters)); set => WriteHere(nameof(HardwareCounters), value); }

        [Offset(40UL)]
        [Length(16)]
        public DynamicArray HwCounter { get => ReadStructure<DynamicArray>(nameof(HwCounter)); set => WriteStructure(nameof(HwCounter), value); }

        public KthreadCounters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KthreadCounters>();
        }
    }
}