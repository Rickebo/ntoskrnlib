using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ALPC_DISPATCH_CONTEXT")]
    public sealed class AlpcDispatchContext : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr PortObject { get => ReadHere<IntPtr>(nameof(PortObject)); set => WriteHere(nameof(PortObject), value); }

        [Offset(8UL)]
        public IntPtr Message { get => ReadHere<IntPtr>(nameof(Message)); set => WriteHere(nameof(Message), value); }

        [Offset(16UL)]
        public IntPtr CommunicationInfo { get => ReadHere<IntPtr>(nameof(CommunicationInfo)); set => WriteHere(nameof(CommunicationInfo), value); }

        [Offset(24UL)]
        public IntPtr TargetThread { get => ReadHere<IntPtr>(nameof(TargetThread)); set => WriteHere(nameof(TargetThread), value); }

        [Offset(32UL)]
        public IntPtr TargetPort { get => ReadHere<IntPtr>(nameof(TargetPort)); set => WriteHere(nameof(TargetPort), value); }

        [Offset(40UL)]
        public KalpcDirectEvent DirectEvent { get => ReadStructure<KalpcDirectEvent>(nameof(DirectEvent)); set => WriteStructure(nameof(DirectEvent), value); }

        [Offset(48UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(52UL)]
        public ushort TotalLength { get => ReadHere<ushort>(nameof(TotalLength)); set => WriteHere(nameof(TotalLength), value); }

        [Offset(54UL)]
        public ushort Type { get => ReadHere<ushort>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(56UL)]
        public ushort DataInfoOffset { get => ReadHere<ushort>(nameof(DataInfoOffset)); set => WriteHere(nameof(DataInfoOffset), value); }

        [Offset(58UL)]
        public byte SignalCompletion { get => ReadHere<byte>(nameof(SignalCompletion)); set => WriteHere(nameof(SignalCompletion), value); }

        [Offset(59UL)]
        public byte PostedToCompletionList { get => ReadHere<byte>(nameof(PostedToCompletionList)); set => WriteHere(nameof(PostedToCompletionList), value); }

        public AlpcDispatchContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<AlpcDispatchContext>();
        }
    }
}