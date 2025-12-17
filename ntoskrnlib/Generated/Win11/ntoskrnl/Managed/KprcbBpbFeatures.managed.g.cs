using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KPRCB_BPB_FEATURES")]
    public sealed class KprcbBpbFeatures : DynamicStructure
    {
        [Offset(0UL)]
        public byte ClearOnIdle { get => ReadHere<byte>(nameof(ClearOnIdle)); set => WriteHere(nameof(ClearOnIdle), value); }

        [Offset(0UL)]
        public byte Enabled { get => ReadHere<byte>(nameof(Enabled)); set => WriteHere(nameof(Enabled), value); }

        [Offset(0UL)]
        public byte Smep { get => ReadHere<byte>(nameof(Smep)); set => WriteHere(nameof(Smep), value); }

        [Offset(0UL)]
        public byte KCet { get => ReadHere<byte>(nameof(KCet)); set => WriteHere(nameof(KCet), value); }

        [Offset(0UL)]
        public byte BhbFlushSequence { get => ReadHere<byte>(nameof(BhbFlushSequence)); set => WriteHere(nameof(BhbFlushSequence), value); }

        [Offset(0UL)]
        public byte VerwOnIdle { get => ReadHere<byte>(nameof(VerwOnIdle)); set => WriteHere(nameof(VerwOnIdle), value); }

        [Offset(0UL)]
        public byte FeaturesReserved { get => ReadHere<byte>(nameof(FeaturesReserved)); set => WriteHere(nameof(FeaturesReserved), value); }

        [Offset(0UL)]
        public byte AllFlags { get => ReadHere<byte>(nameof(AllFlags)); set => WriteHere(nameof(AllFlags), value); }

        public KprcbBpbFeatures(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KprcbBpbFeatures>();
        }
    }
}