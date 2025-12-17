using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PORT_MESSAGE32")]
    public sealed class PortMESSAGE32 : DynamicStructure
    {
        [Offset(0UL)]
        public UnnamedTag u1 { get => ReadStructure<UnnamedTag>(nameof(u1)); set => WriteStructure(nameof(u1), value); }

        [Offset(4UL)]
        public UnnamedTag u2 { get => ReadStructure<UnnamedTag>(nameof(u2)); set => WriteStructure(nameof(u2), value); }

        [Offset(8UL)]
        public ClientID32 ClientId { get => ReadStructure<ClientID32>(nameof(ClientId)); set => WriteStructure(nameof(ClientId), value); }

        [Offset(8UL)]
        public long DoNotUseThisField { get => ReadHere<long>(nameof(DoNotUseThisField)); set => WriteHere(nameof(DoNotUseThisField), value); }

        [Offset(16UL)]
        public uint MessageId { get => ReadHere<uint>(nameof(MessageId)); set => WriteHere(nameof(MessageId), value); }

        [Offset(20UL)]
        public uint ClientViewSize { get => ReadHere<uint>(nameof(ClientViewSize)); set => WriteHere(nameof(ClientViewSize), value); }

        [Offset(20UL)]
        public uint CallbackId { get => ReadHere<uint>(nameof(CallbackId)); set => WriteHere(nameof(CallbackId), value); }

        public PortMESSAGE32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PortMESSAGE32>();
        }
    }
}