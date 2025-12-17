using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KPCR")]
    public sealed class Kpcr : DynamicStructure
    {
        [Offset(0UL)]
        public NtTib NtTib { get => ReadStructure<NtTib>(nameof(NtTib)); set => WriteStructure(nameof(NtTib), value); }

        [Offset(0UL)]
        public IntPtr GdtBase { get => ReadHere<IntPtr>(nameof(GdtBase)); set => WriteHere(nameof(GdtBase), value); }

        [Offset(8UL)]
        public IntPtr TssBase { get => ReadHere<IntPtr>(nameof(TssBase)); set => WriteHere(nameof(TssBase), value); }

        [Offset(16UL)]
        public ulong UserRsp { get => ReadHere<ulong>(nameof(UserRsp)); set => WriteHere(nameof(UserRsp), value); }

        [Offset(24UL)]
        public IntPtr Self { get => ReadHere<IntPtr>(nameof(Self)); set => WriteHere(nameof(Self), value); }

        [Offset(32UL)]
        public IntPtr CurrentPrcb { get => ReadHere<IntPtr>(nameof(CurrentPrcb)); set => WriteHere(nameof(CurrentPrcb), value); }

        [Offset(40UL)]
        public IntPtr LockArray { get => ReadHere<IntPtr>(nameof(LockArray)); set => WriteHere(nameof(LockArray), value); }

        [Offset(48UL)]
        public IntPtr Used_Self { get => ReadHere<IntPtr>(nameof(Used_Self)); set => WriteHere(nameof(Used_Self), value); }

        [Offset(56UL)]
        public IntPtr IdtBase { get => ReadHere<IntPtr>(nameof(IdtBase)); set => WriteHere(nameof(IdtBase), value); }

        [Offset(64UL)]
        [Length(2)]
        public DynamicArray Unused { get => ReadStructure<DynamicArray>(nameof(Unused)); set => WriteStructure(nameof(Unused), value); }

        [Offset(80UL)]
        public byte Irql { get => ReadHere<byte>(nameof(Irql)); set => WriteHere(nameof(Irql), value); }

        [Offset(81UL)]
        public byte SecondLevelCacheAssociativity { get => ReadHere<byte>(nameof(SecondLevelCacheAssociativity)); set => WriteHere(nameof(SecondLevelCacheAssociativity), value); }

        [Offset(82UL)]
        public byte ObsoleteNumber { get => ReadHere<byte>(nameof(ObsoleteNumber)); set => WriteHere(nameof(ObsoleteNumber), value); }

        [Offset(83UL)]
        public byte Fill0 { get => ReadHere<byte>(nameof(Fill0)); set => WriteHere(nameof(Fill0), value); }

        [Offset(84UL)]
        [Length(3)]
        public DynamicArray Unused0 { get => ReadStructure<DynamicArray>(nameof(Unused0)); set => WriteStructure(nameof(Unused0), value); }

        [Offset(96UL)]
        public ushort MajorVersion { get => ReadHere<ushort>(nameof(MajorVersion)); set => WriteHere(nameof(MajorVersion), value); }

        [Offset(98UL)]
        public ushort MinorVersion { get => ReadHere<ushort>(nameof(MinorVersion)); set => WriteHere(nameof(MinorVersion), value); }

        [Offset(100UL)]
        public uint StallScaleFactor { get => ReadHere<uint>(nameof(StallScaleFactor)); set => WriteHere(nameof(StallScaleFactor), value); }

        [Offset(104UL)]
        [Length(3)]
        public DynamicArray Unused1 { get => ReadStructure<DynamicArray>(nameof(Unused1)); set => WriteStructure(nameof(Unused1), value); }

        [Offset(128UL)]
        [Length(15)]
        public DynamicArray KernelReserved { get => ReadStructure<DynamicArray>(nameof(KernelReserved)); set => WriteStructure(nameof(KernelReserved), value); }

        [Offset(188UL)]
        public uint SecondLevelCacheSize { get => ReadHere<uint>(nameof(SecondLevelCacheSize)); set => WriteHere(nameof(SecondLevelCacheSize), value); }

        [Offset(192UL)]
        [Length(16)]
        public DynamicArray HalReserved { get => ReadStructure<DynamicArray>(nameof(HalReserved)); set => WriteStructure(nameof(HalReserved), value); }

        [Offset(256UL)]
        public uint Unused2 { get => ReadHere<uint>(nameof(Unused2)); set => WriteHere(nameof(Unused2), value); }

        [Offset(264UL)]
        public IntPtr KdVersionBlock { get => ReadHere<IntPtr>(nameof(KdVersionBlock)); set => WriteHere(nameof(KdVersionBlock), value); }

        [Offset(272UL)]
        public IntPtr Unused3 { get => ReadHere<IntPtr>(nameof(Unused3)); set => WriteHere(nameof(Unused3), value); }

        [Offset(280UL)]
        [Length(24)]
        public DynamicArray PcrAlign1 { get => ReadStructure<DynamicArray>(nameof(PcrAlign1)); set => WriteStructure(nameof(PcrAlign1), value); }

        public Kpcr(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Kpcr>();
        }
    }
}