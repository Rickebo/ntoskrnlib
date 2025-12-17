using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_EVENT_DESCRIPTOR")]
    public sealed class EventDescriptor : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Id { get => ReadHere<ushort>(nameof(Id)); set => WriteHere(nameof(Id), value); }

        [Offset(2UL)]
        public byte Version { get => ReadHere<byte>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(3UL)]
        public byte Channel { get => ReadHere<byte>(nameof(Channel)); set => WriteHere(nameof(Channel), value); }

        [Offset(4UL)]
        public byte Level { get => ReadHere<byte>(nameof(Level)); set => WriteHere(nameof(Level), value); }

        [Offset(5UL)]
        public byte Opcode { get => ReadHere<byte>(nameof(Opcode)); set => WriteHere(nameof(Opcode), value); }

        [Offset(6UL)]
        public ushort Task { get => ReadHere<ushort>(nameof(Task)); set => WriteHere(nameof(Task), value); }

        [Offset(8UL)]
        public ulong Keyword { get => ReadHere<ulong>(nameof(Keyword)); set => WriteHere(nameof(Keyword), value); }

        public EventDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EventDescriptor>();
        }
    }
}