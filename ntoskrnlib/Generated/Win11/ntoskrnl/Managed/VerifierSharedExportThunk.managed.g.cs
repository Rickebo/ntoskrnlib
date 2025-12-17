using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VERIFIER_SHARED_EXPORT_THUNK")]
    public sealed class VerifierSharedExportThunk : DynamicStructure
    {
        public VerifierSharedExportThunk(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<VerifierSharedExportThunk>();
        }
    }
}