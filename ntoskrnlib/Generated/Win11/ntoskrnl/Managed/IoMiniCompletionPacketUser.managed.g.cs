using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IO_MINI_COMPLETION_PACKET_USER")]
    public sealed class IoMiniCompletionPacketUser : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public uint PacketType { get => ReadHere<uint>(nameof(PacketType)); set => WriteHere(nameof(PacketType), value); }

        [Offset(24UL)]
        public IntPtr KeyContext { get => ReadHere<IntPtr>(nameof(KeyContext)); set => WriteHere(nameof(KeyContext), value); }

        [Offset(32UL)]
        public IntPtr ApcContext { get => ReadHere<IntPtr>(nameof(ApcContext)); set => WriteHere(nameof(ApcContext), value); }

        [Offset(40UL)]
        public int IoStatus { get => ReadHere<int>(nameof(IoStatus)); set => WriteHere(nameof(IoStatus), value); }

        [Offset(48UL)]
        public ulong IoStatusInformation { get => ReadHere<ulong>(nameof(IoStatusInformation)); set => WriteHere(nameof(IoStatusInformation), value); }

        [Offset(56UL)]
        public IntPtr MiniPacketCallback { get => ReadHere<IntPtr>(nameof(MiniPacketCallback)); set => WriteHere(nameof(MiniPacketCallback), value); }

        [Offset(64UL)]
        public IntPtr Context { get => ReadHere<IntPtr>(nameof(Context)); set => WriteHere(nameof(Context), value); }

        [Offset(72UL)]
        public byte Allocated { get => ReadHere<byte>(nameof(Allocated)); set => WriteHere(nameof(Allocated), value); }

        public IoMiniCompletionPacketUser(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IoMiniCompletionPacketUser>();
        }
    }
}