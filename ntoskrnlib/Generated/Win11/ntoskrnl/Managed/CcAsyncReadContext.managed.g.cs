using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CC_ASYNC_READ_CONTEXT")]
    public sealed class CcAsyncReadContext : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr CompletionRoutine { get => ReadHere<IntPtr>(nameof(CompletionRoutine)); set => WriteHere(nameof(CompletionRoutine), value); }

        [Offset(8UL)]
        public IntPtr Context { get => ReadHere<IntPtr>(nameof(Context)); set => WriteHere(nameof(Context), value); }

        [Offset(16UL)]
        public IntPtr Mdl { get => ReadHere<IntPtr>(nameof(Mdl)); set => WriteHere(nameof(Mdl), value); }

        [Offset(24UL)]
        public sbyte RequestorMode { get => ReadHere<sbyte>(nameof(RequestorMode)); set => WriteHere(nameof(RequestorMode), value); }

        [Offset(28UL)]
        public uint NestingLevel { get => ReadHere<uint>(nameof(NestingLevel)); set => WriteHere(nameof(NestingLevel), value); }

        public CcAsyncReadContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CcAsyncReadContext>();
        }
    }
}