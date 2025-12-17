using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_LOADER_BOOT_APPLICATION_SVN_INFORMATION")]
    public sealed class LoaderBootApplicationSvnInformation : DynamicStructure
    {
        [Offset(0UL)]
        public LargeInteger BootStlCreationTime { get => ReadStructure<LargeInteger>(nameof(BootStlCreationTime)); set => WriteStructure(nameof(BootStlCreationTime), value); }

        [Offset(8UL)]
        public uint HiberrsmMinSvn { get => ReadHere<uint>(nameof(HiberrsmMinSvn)); set => WriteHere(nameof(HiberrsmMinSvn), value); }

        public LoaderBootApplicationSvnInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LoaderBootApplicationSvnInformation>();
        }
    }
}