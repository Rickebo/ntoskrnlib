using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CACHE_MANAGER_CALLBACKS_EX")]
    public sealed class CacheManagerCallbacksEx : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Version { get => ReadHere<ushort>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(2UL)]
        public ushort Size { get => ReadHere<ushort>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(8UL)]
        public CacheManagerCallbackFunctions Functions { get => ReadStructure<CacheManagerCallbackFunctions>(nameof(Functions)); set => WriteStructure(nameof(Functions), value); }

        public CacheManagerCallbacksEx(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CacheManagerCallbacksEx>();
        }
    }
}