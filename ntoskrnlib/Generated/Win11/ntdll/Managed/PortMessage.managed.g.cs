using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PORT_MESSAGE")]
    public sealed class PortMessage : DynamicStructure
    {
        [Offset(0UL)]
        public UnnamedTag u1 { get => ReadStructure<UnnamedTag>(nameof(u1)); set => WriteStructure(nameof(u1), value); }

        [Offset(4UL)]
        public UnnamedTag u2 { get => ReadStructure<UnnamedTag>(nameof(u2)); set => WriteStructure(nameof(u2), value); }

        [Offset(8UL)]
        public ClientId ClientId { get => ReadStructure<ClientId>(nameof(ClientId)); set => WriteStructure(nameof(ClientId), value); }

        [Offset(8UL)]
        public long DoNotUseThisField { get => ReadHere<long>(nameof(DoNotUseThisField)); set => WriteHere(nameof(DoNotUseThisField), value); }

        [Offset(24UL)]
        public uint MessageId { get => ReadHere<uint>(nameof(MessageId)); set => WriteHere(nameof(MessageId), value); }

        [Offset(32UL)]
        public ulong ClientViewSize { get => ReadHere<ulong>(nameof(ClientViewSize)); set => WriteHere(nameof(ClientViewSize), value); }

        [Offset(32UL)]
        public uint CallbackId { get => ReadHere<uint>(nameof(CallbackId)); set => WriteHere(nameof(CallbackId), value); }

        public PortMessage(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PortMessage>();
        }
    }
}