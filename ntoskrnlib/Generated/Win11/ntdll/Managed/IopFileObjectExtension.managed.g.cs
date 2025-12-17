using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_IOP_FILE_OBJECT_EXTENSION")]
    public sealed class IopFileObjectExtension : DynamicStructure
    {
        public IopFileObjectExtension(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IopFileObjectExtension>();
        }
    }
}