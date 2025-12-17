using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KALPC_MESSAGE_ATTRIBUTES")]
    public sealed class KalpcMessageAttributes : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr ClientContext { get => ReadHere<IntPtr>(nameof(ClientContext)); set => WriteHere(nameof(ClientContext), value); }

        [Offset(8UL)]
        public IntPtr ServerContext { get => ReadHere<IntPtr>(nameof(ServerContext)); set => WriteHere(nameof(ServerContext), value); }

        [Offset(16UL)]
        public IntPtr PortContext { get => ReadHere<IntPtr>(nameof(PortContext)); set => WriteHere(nameof(PortContext), value); }

        [Offset(24UL)]
        public IntPtr CancelPortContext { get => ReadHere<IntPtr>(nameof(CancelPortContext)); set => WriteHere(nameof(CancelPortContext), value); }

        [Offset(32UL)]
        public IntPtr SecurityData { get => ReadHere<IntPtr>(nameof(SecurityData)); set => WriteHere(nameof(SecurityData), value); }

        [Offset(40UL)]
        public IntPtr View { get => ReadHere<IntPtr>(nameof(View)); set => WriteHere(nameof(View), value); }

        [Offset(48UL)]
        public IntPtr HandleData { get => ReadHere<IntPtr>(nameof(HandleData)); set => WriteHere(nameof(HandleData), value); }

        [Offset(56UL)]
        public KalpcDirectEvent DirectEvent { get => ReadStructure<KalpcDirectEvent>(nameof(DirectEvent)); set => WriteStructure(nameof(DirectEvent), value); }

        [Offset(64UL)]
        public KalpcWorkOnBehalfData WorkOnBehalfData { get => ReadStructure<KalpcWorkOnBehalfData>(nameof(WorkOnBehalfData)); set => WriteStructure(nameof(WorkOnBehalfData), value); }

        public KalpcMessageAttributes(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KalpcMessageAttributes>();
        }
    }
}