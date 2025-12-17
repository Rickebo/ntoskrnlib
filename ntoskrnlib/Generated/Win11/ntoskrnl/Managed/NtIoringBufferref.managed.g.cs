using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_NT_IORING_BUFFERREF")]
    public sealed class NtIoringBufferref : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Address { get => ReadHere<IntPtr>(nameof(Address)); set => WriteHere(nameof(Address), value); }

        [Offset(0UL)]
        public IoringRegisteredBuffer FixedBuffer { get => ReadStructure<IoringRegisteredBuffer>(nameof(FixedBuffer)); set => WriteStructure(nameof(FixedBuffer), value); }

        public NtIoringBufferref(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<NtIoringBufferref>();
        }
    }
}