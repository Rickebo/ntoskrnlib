using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!FEATURE_LOGGED_TRAITS")]
    public sealed class FeatureLoggedTraits : DynamicStructure
    {
        [Offset(0UL)]
        public ushort version { get => ReadHere<ushort>(nameof(version)); set => WriteHere(nameof(version), value); }

        [Offset(2UL)]
        public ushort baseVersion { get => ReadHere<ushort>(nameof(baseVersion)); set => WriteHere(nameof(baseVersion), value); }

        [Offset(4UL)]
        public byte stage { get => ReadHere<byte>(nameof(stage)); set => WriteHere(nameof(stage), value); }

        public FeatureLoggedTraits(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<FeatureLoggedTraits>();
        }
    }
}