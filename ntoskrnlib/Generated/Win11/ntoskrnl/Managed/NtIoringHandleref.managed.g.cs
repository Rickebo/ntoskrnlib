using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_NT_IORING_HANDLEREF")]
    public sealed class NtIoringHandleref : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Handle { get => ReadHere<IntPtr>(nameof(Handle)); set => WriteHere(nameof(Handle), value); }

        [Offset(0UL)]
        public uint HandleIndex { get => ReadHere<uint>(nameof(HandleIndex)); set => WriteHere(nameof(HandleIndex), value); }

        public NtIoringHandleref(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<NtIoringHandleref>();
        }
    }
}