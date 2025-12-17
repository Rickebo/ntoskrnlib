using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KTIMER2")]
    public sealed class KTIMER2 : DynamicStructure
    {
        [Offset(0UL)]
        public DispatcherHeader Header { get => ReadStructure<DispatcherHeader>(nameof(Header)); set => WriteStructure(nameof(Header), value); }

        [Offset(24UL)]
        [Length(2)]
        public DynamicArray RbNodes { get => ReadStructure<DynamicArray>(nameof(RbNodes)); set => WriteStructure(nameof(RbNodes), value); }

        [Offset(24UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(72UL)]
        [Length(2)]
        public DynamicArray DueTime { get => ReadStructure<DynamicArray>(nameof(DueTime)); set => WriteStructure(nameof(DueTime), value); }

        [Offset(88UL)]
        public long Period { get => ReadHere<long>(nameof(Period)); set => WriteHere(nameof(Period), value); }

        [Offset(96UL)]
        public IntPtr Callback { get => ReadHere<IntPtr>(nameof(Callback)); set => WriteHere(nameof(Callback), value); }

        [Offset(104UL)]
        public IntPtr CallbackContext { get => ReadHere<IntPtr>(nameof(CallbackContext)); set => WriteHere(nameof(CallbackContext), value); }

        [Offset(112UL)]
        public IntPtr DisableCallback { get => ReadHere<IntPtr>(nameof(DisableCallback)); set => WriteHere(nameof(DisableCallback), value); }

        [Offset(120UL)]
        public IntPtr DisableContext { get => ReadHere<IntPtr>(nameof(DisableContext)); set => WriteHere(nameof(DisableContext), value); }

        [Offset(128UL)]
        public byte AbsoluteSystemTime { get => ReadHere<byte>(nameof(AbsoluteSystemTime)); set => WriteHere(nameof(AbsoluteSystemTime), value); }

        [Offset(129UL)]
        public byte TypeFlags { get => ReadHere<byte>(nameof(TypeFlags)); set => WriteHere(nameof(TypeFlags), value); }

        [Offset(129UL)]
        public byte Unused { get => ReadHere<byte>(nameof(Unused)); set => WriteHere(nameof(Unused), value); }

        [Offset(129UL)]
        public byte IdleResilient { get => ReadHere<byte>(nameof(IdleResilient)); set => WriteHere(nameof(IdleResilient), value); }

        [Offset(129UL)]
        public byte HighResolution { get => ReadHere<byte>(nameof(HighResolution)); set => WriteHere(nameof(HighResolution), value); }

        [Offset(129UL)]
        public byte NoWake { get => ReadHere<byte>(nameof(NoWake)); set => WriteHere(nameof(NoWake), value); }

        [Offset(129UL)]
        public byte PseudoHighRes { get => ReadHere<byte>(nameof(PseudoHighRes)); set => WriteHere(nameof(PseudoHighRes), value); }

        [Offset(129UL)]
        public byte AusterityResilient { get => ReadHere<byte>(nameof(AusterityResilient)); set => WriteHere(nameof(AusterityResilient), value); }

        [Offset(129UL)]
        public byte Unused1 { get => ReadHere<byte>(nameof(Unused1)); set => WriteHere(nameof(Unused1), value); }

        [Offset(130UL)]
        [Length(2)]
        public DynamicArray CollectionIndex { get => ReadStructure<DynamicArray>(nameof(CollectionIndex)); set => WriteStructure(nameof(CollectionIndex), value); }

        public KTIMER2(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KTIMER2>();
        }
    }
}