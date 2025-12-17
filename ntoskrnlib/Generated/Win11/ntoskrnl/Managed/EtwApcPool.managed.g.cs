using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_APC_POOL")]
    public sealed class EtwApcPool : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr LoggerContext { get => ReadHere<IntPtr>(nameof(LoggerContext)); set => WriteHere(nameof(LoggerContext), value); }

        [Offset(8UL)]
        public ulong ApcSpinLock { get => ReadHere<ulong>(nameof(ApcSpinLock)); set => WriteHere(nameof(ApcSpinLock), value); }

        [Offset(16UL)]
        public SlistHeader ApcGlobalListHead { get => ReadStructure<SlistHeader>(nameof(ApcGlobalListHead)); set => WriteStructure(nameof(ApcGlobalListHead), value); }

        [Offset(32UL)]
        public SlistHeader ApcFreeListHead { get => ReadStructure<SlistHeader>(nameof(ApcFreeListHead)); set => WriteStructure(nameof(ApcFreeListHead), value); }

        [Offset(48UL)]
        public IntPtr DpcContext1 { get => ReadHere<IntPtr>(nameof(DpcContext1)); set => WriteHere(nameof(DpcContext1), value); }

        [Offset(56UL)]
        public IntPtr DpcContext2 { get => ReadHere<IntPtr>(nameof(DpcContext2)); set => WriteHere(nameof(DpcContext2), value); }

        [Offset(64UL)]
        public IntPtr DpcContext3 { get => ReadHere<IntPtr>(nameof(DpcContext3)); set => WriteHere(nameof(DpcContext3), value); }

        [Offset(72UL)]
        public IntPtr DpcNormalRoutine { get => ReadHere<IntPtr>(nameof(DpcNormalRoutine)); set => WriteHere(nameof(DpcNormalRoutine), value); }

        [Offset(80UL)]
        public IntPtr DpcCancelRoutine { get => ReadHere<IntPtr>(nameof(DpcCancelRoutine)); set => WriteHere(nameof(DpcCancelRoutine), value); }

        [Offset(88UL)]
        public IntPtr DpcThread { get => ReadHere<IntPtr>(nameof(DpcThread)); set => WriteHere(nameof(DpcThread), value); }

        [Offset(96UL)]
        public Kdpc Dpc { get => ReadStructure<Kdpc>(nameof(Dpc)); set => WriteStructure(nameof(Dpc), value); }

        [Offset(160UL)]
        public int Flags { get => ReadHere<int>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(164UL)]
        public int ApcCount { get => ReadHere<int>(nameof(ApcCount)); set => WriteHere(nameof(ApcCount), value); }

        [Offset(168UL)]
        public uint MinimumApcCount { get => ReadHere<uint>(nameof(MinimumApcCount)); set => WriteHere(nameof(MinimumApcCount), value); }

        [Offset(172UL)]
        public uint MaximumApcCount { get => ReadHere<uint>(nameof(MaximumApcCount)); set => WriteHere(nameof(MaximumApcCount), value); }

        [Offset(176UL)]
        public int OutstandingApcCount { get => ReadHere<int>(nameof(OutstandingApcCount)); set => WriteHere(nameof(OutstandingApcCount), value); }

        [Offset(180UL)]
        public int MaxOutstandingApcCount { get => ReadHere<int>(nameof(MaxOutstandingApcCount)); set => WriteHere(nameof(MaxOutstandingApcCount), value); }

        public EtwApcPool(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwApcPool>();
        }
    }
}