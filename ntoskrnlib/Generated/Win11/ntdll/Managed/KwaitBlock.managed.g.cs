using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KWAIT_BLOCK")]
    public sealed class KwaitBlock : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry WaitListEntry { get => ReadStructure<ListEntry>(nameof(WaitListEntry)); set => WriteStructure(nameof(WaitListEntry), value); }

        [Offset(16UL)]
        public byte WaitType { get => ReadHere<byte>(nameof(WaitType)); set => WriteHere(nameof(WaitType), value); }

        [Offset(17UL)]
        public byte BlockState { get => ReadHere<byte>(nameof(BlockState)); set => WriteHere(nameof(BlockState), value); }

        [Offset(18UL)]
        public ushort WaitKey { get => ReadHere<ushort>(nameof(WaitKey)); set => WriteHere(nameof(WaitKey), value); }

        [Offset(20UL)]
        public int SpareLong { get => ReadHere<int>(nameof(SpareLong)); set => WriteHere(nameof(SpareLong), value); }

        [Offset(24UL)]
        public IntPtr Thread { get => ReadHere<IntPtr>(nameof(Thread)); set => WriteHere(nameof(Thread), value); }

        [Offset(24UL)]
        public IntPtr NotificationQueue { get => ReadHere<IntPtr>(nameof(NotificationQueue)); set => WriteHere(nameof(NotificationQueue), value); }

        [Offset(24UL)]
        public IntPtr Dpc { get => ReadHere<IntPtr>(nameof(Dpc)); set => WriteHere(nameof(Dpc), value); }

        [Offset(32UL)]
        public IntPtr Object { get => ReadHere<IntPtr>(nameof(Object)); set => WriteHere(nameof(Object), value); }

        [Offset(40UL)]
        public IntPtr SparePtr { get => ReadHere<IntPtr>(nameof(SparePtr)); set => WriteHere(nameof(SparePtr), value); }

        public KwaitBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KwaitBlock>();
        }
    }
}