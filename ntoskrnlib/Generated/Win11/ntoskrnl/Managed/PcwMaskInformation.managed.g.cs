using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PCW_MASK_INFORMATION")]
    public sealed class PcwMaskInformation : DynamicStructure
    {
        [Offset(0UL)]
        public ulong CounterMask { get => ReadHere<ulong>(nameof(CounterMask)); set => WriteHere(nameof(CounterMask), value); }

        [Offset(8UL)]
        public IntPtr InstanceMask { get => ReadHere<IntPtr>(nameof(InstanceMask)); set => WriteHere(nameof(InstanceMask), value); }

        [Offset(16UL)]
        public uint InstanceId { get => ReadHere<uint>(nameof(InstanceId)); set => WriteHere(nameof(InstanceId), value); }

        [Offset(20UL)]
        public byte CollectMultiple { get => ReadHere<byte>(nameof(CollectMultiple)); set => WriteHere(nameof(CollectMultiple), value); }

        [Offset(24UL)]
        public IntPtr Buffer { get => ReadHere<IntPtr>(nameof(Buffer)); set => WriteHere(nameof(Buffer), value); }

        [Offset(32UL)]
        public IntPtr CancelEvent { get => ReadHere<IntPtr>(nameof(CancelEvent)); set => WriteHere(nameof(CancelEvent), value); }

        public PcwMaskInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PcwMaskInformation>();
        }
    }
}