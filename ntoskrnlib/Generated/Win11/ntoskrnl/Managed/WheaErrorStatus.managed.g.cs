using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEA_ERROR_STATUS")]
    public sealed class WheaErrorStatus : DynamicStructure
    {
        [Offset(0UL)]
        public ulong ErrorStatus { get => ReadHere<ulong>(nameof(ErrorStatus)); set => WriteHere(nameof(ErrorStatus), value); }

        [Offset(0UL)]
        public ulong Reserved1 { get => ReadHere<ulong>(nameof(Reserved1)); set => WriteHere(nameof(Reserved1), value); }

        [Offset(0UL)]
        public ulong ErrorType { get => ReadHere<ulong>(nameof(ErrorType)); set => WriteHere(nameof(ErrorType), value); }

        [Offset(0UL)]
        public ulong Address { get => ReadHere<ulong>(nameof(Address)); set => WriteHere(nameof(Address), value); }

        [Offset(0UL)]
        public ulong Control { get => ReadHere<ulong>(nameof(Control)); set => WriteHere(nameof(Control), value); }

        [Offset(0UL)]
        public ulong Data { get => ReadHere<ulong>(nameof(Data)); set => WriteHere(nameof(Data), value); }

        [Offset(0UL)]
        public ulong Responder { get => ReadHere<ulong>(nameof(Responder)); set => WriteHere(nameof(Responder), value); }

        [Offset(0UL)]
        public ulong Requester { get => ReadHere<ulong>(nameof(Requester)); set => WriteHere(nameof(Requester), value); }

        [Offset(0UL)]
        public ulong FirstError { get => ReadHere<ulong>(nameof(FirstError)); set => WriteHere(nameof(FirstError), value); }

        [Offset(0UL)]
        public ulong Overflow { get => ReadHere<ulong>(nameof(Overflow)); set => WriteHere(nameof(Overflow), value); }

        [Offset(0UL)]
        public ulong Reserved2 { get => ReadHere<ulong>(nameof(Reserved2)); set => WriteHere(nameof(Reserved2), value); }

        public WheaErrorStatus(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaErrorStatus>();
        }
    }
}