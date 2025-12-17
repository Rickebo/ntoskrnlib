using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WAIT_CONTEXT_BLOCK")]
    public sealed class WaitContextBlock : DynamicStructure
    {
        [Offset(0UL)]
        public KdeviceQueueEntry WaitQueueEntry { get => ReadStructure<KdeviceQueueEntry>(nameof(WaitQueueEntry)); set => WriteStructure(nameof(WaitQueueEntry), value); }

        [Offset(0UL)]
        public ListEntry DmaWaitEntry { get => ReadStructure<ListEntry>(nameof(DmaWaitEntry)); set => WriteStructure(nameof(DmaWaitEntry), value); }

        [Offset(16UL)]
        public uint NumberOfChannels { get => ReadHere<uint>(nameof(NumberOfChannels)); set => WriteHere(nameof(NumberOfChannels), value); }

        [Offset(20UL)]
        public uint SyncCallback { get => ReadHere<uint>(nameof(SyncCallback)); set => WriteHere(nameof(SyncCallback), value); }

        [Offset(20UL)]
        public uint DmaContext { get => ReadHere<uint>(nameof(DmaContext)); set => WriteHere(nameof(DmaContext), value); }

        [Offset(20UL)]
        public uint ZeroMapRegisters { get => ReadHere<uint>(nameof(ZeroMapRegisters)); set => WriteHere(nameof(ZeroMapRegisters), value); }

        [Offset(20UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(20UL)]
        public uint NumberOfRemapPages { get => ReadHere<uint>(nameof(NumberOfRemapPages)); set => WriteHere(nameof(NumberOfRemapPages), value); }

        [Offset(24UL)]
        public IntPtr DeviceRoutine { get => ReadHere<IntPtr>(nameof(DeviceRoutine)); set => WriteHere(nameof(DeviceRoutine), value); }

        [Offset(32UL)]
        public IntPtr DeviceContext { get => ReadHere<IntPtr>(nameof(DeviceContext)); set => WriteHere(nameof(DeviceContext), value); }

        [Offset(40UL)]
        public uint NumberOfMapRegisters { get => ReadHere<uint>(nameof(NumberOfMapRegisters)); set => WriteHere(nameof(NumberOfMapRegisters), value); }

        [Offset(48UL)]
        public IntPtr DeviceObject { get => ReadHere<IntPtr>(nameof(DeviceObject)); set => WriteHere(nameof(DeviceObject), value); }

        [Offset(56UL)]
        public IntPtr CurrentIrp { get => ReadHere<IntPtr>(nameof(CurrentIrp)); set => WriteHere(nameof(CurrentIrp), value); }

        [Offset(64UL)]
        public IntPtr BufferChainingDpc { get => ReadHere<IntPtr>(nameof(BufferChainingDpc)); set => WriteHere(nameof(BufferChainingDpc), value); }

        public WaitContextBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WaitContextBlock>();
        }
    }
}