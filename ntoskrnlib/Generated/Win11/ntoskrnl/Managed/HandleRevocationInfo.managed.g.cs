using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HANDLE_REVOCATION_INFO")]
    public sealed class HandleRevocationInfo : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public IntPtr RevocationBlock { get => ReadHere<IntPtr>(nameof(RevocationBlock)); set => WriteHere(nameof(RevocationBlock), value); }

        [Offset(24UL)]
        public byte AllowHandleRevocation { get => ReadHere<byte>(nameof(AllowHandleRevocation)); set => WriteHere(nameof(AllowHandleRevocation), value); }

        [Offset(25UL)]
        [Length(3)]
        public DynamicArray Padding1 { get => ReadStructure<DynamicArray>(nameof(Padding1)); set => WriteStructure(nameof(Padding1), value); }

        [Offset(28UL)]
        [Length(4)]
        public DynamicArray Padding2 { get => ReadStructure<DynamicArray>(nameof(Padding2)); set => WriteStructure(nameof(Padding2), value); }

        public HandleRevocationInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HandleRevocationInfo>();
        }
    }
}