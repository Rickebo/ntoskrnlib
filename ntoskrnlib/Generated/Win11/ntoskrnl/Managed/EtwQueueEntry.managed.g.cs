using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_QUEUE_ENTRY")]
    public sealed class EtwQueueEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public IntPtr DataBlock { get => ReadHere<IntPtr>(nameof(DataBlock)); set => WriteHere(nameof(DataBlock), value); }

        [Offset(24UL)]
        public IntPtr RegEntry { get => ReadHere<IntPtr>(nameof(RegEntry)); set => WriteHere(nameof(RegEntry), value); }

        [Offset(32UL)]
        public IntPtr ReplyObject { get => ReadHere<IntPtr>(nameof(ReplyObject)); set => WriteHere(nameof(ReplyObject), value); }

        [Offset(40UL)]
        public IntPtr WakeReference { get => ReadHere<IntPtr>(nameof(WakeReference)); set => WriteHere(nameof(WakeReference), value); }

        [Offset(48UL)]
        public ushort RegIndex { get => ReadHere<ushort>(nameof(RegIndex)); set => WriteHere(nameof(RegIndex), value); }

        [Offset(50UL)]
        public ushort ReplyIndex { get => ReadHere<ushort>(nameof(ReplyIndex)); set => WriteHere(nameof(ReplyIndex), value); }

        [Offset(52UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        public EtwQueueEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwQueueEntry>();
        }
    }
}