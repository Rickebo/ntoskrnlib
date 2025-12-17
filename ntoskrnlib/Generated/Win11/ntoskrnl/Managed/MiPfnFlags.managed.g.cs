using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_PFN_FLAGS")]
    public sealed class MiPfnFlags : DynamicStructure
    {
        [Offset(0UL)]
        public ushort ReferenceCount { get => ReadHere<ushort>(nameof(ReferenceCount)); set => WriteHere(nameof(ReferenceCount), value); }

        [Offset(2UL)]
        public byte PageLocation { get => ReadHere<byte>(nameof(PageLocation)); set => WriteHere(nameof(PageLocation), value); }

        [Offset(2UL)]
        public byte WriteInProgress { get => ReadHere<byte>(nameof(WriteInProgress)); set => WriteHere(nameof(WriteInProgress), value); }

        [Offset(2UL)]
        public byte Modified { get => ReadHere<byte>(nameof(Modified)); set => WriteHere(nameof(Modified), value); }

        [Offset(2UL)]
        public byte ReadInProgress { get => ReadHere<byte>(nameof(ReadInProgress)); set => WriteHere(nameof(ReadInProgress), value); }

        [Offset(2UL)]
        public byte CacheAttribute { get => ReadHere<byte>(nameof(CacheAttribute)); set => WriteHere(nameof(CacheAttribute), value); }

        [Offset(3UL)]
        public byte Priority { get => ReadHere<byte>(nameof(Priority)); set => WriteHere(nameof(Priority), value); }

        [Offset(3UL)]
        public byte OnProtectedStandby { get => ReadHere<byte>(nameof(OnProtectedStandby)); set => WriteHere(nameof(OnProtectedStandby), value); }

        [Offset(3UL)]
        public byte InPageError { get => ReadHere<byte>(nameof(InPageError)); set => WriteHere(nameof(InPageError), value); }

        [Offset(3UL)]
        public byte SystemChargedPage { get => ReadHere<byte>(nameof(SystemChargedPage)); set => WriteHere(nameof(SystemChargedPage), value); }

        [Offset(3UL)]
        public byte RemovalRequested { get => ReadHere<byte>(nameof(RemovalRequested)); set => WriteHere(nameof(RemovalRequested), value); }

        [Offset(3UL)]
        public byte ParityError { get => ReadHere<byte>(nameof(ParityError)); set => WriteHere(nameof(ParityError), value); }

        [Offset(0UL)]
        public uint EntireField { get => ReadHere<uint>(nameof(EntireField)); set => WriteHere(nameof(EntireField), value); }

        public MiPfnFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiPfnFlags>();
        }
    }
}