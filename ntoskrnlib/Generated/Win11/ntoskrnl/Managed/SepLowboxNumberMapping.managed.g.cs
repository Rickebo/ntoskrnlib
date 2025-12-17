using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SEP_LOWBOX_NUMBER_MAPPING")]
    public sealed class SepLowboxNumberMapping : DynamicStructure
    {
        [Offset(0UL)]
        public ExPushLock Lock { get => ReadStructure<ExPushLock>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        [Offset(8UL)]
        public RtlBitmap Bitmap { get => ReadStructure<RtlBitmap>(nameof(Bitmap)); set => WriteStructure(nameof(Bitmap), value); }

        [Offset(24UL)]
        public IntPtr HashTable { get => ReadHere<IntPtr>(nameof(HashTable)); set => WriteHere(nameof(HashTable), value); }

        [Offset(32UL)]
        public byte Active { get => ReadHere<byte>(nameof(Active)); set => WriteHere(nameof(Active), value); }

        public SepLowboxNumberMapping(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SepLowboxNumberMapping>();
        }
    }
}