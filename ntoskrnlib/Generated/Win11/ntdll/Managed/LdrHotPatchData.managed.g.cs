using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_LDR_HOT_PATCH_DATA")]
    public sealed class LdrHotPatchData : DynamicStructure
    {
        [Offset(0UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(8UL)]
        public IntPtr PatchLoadLibrary { get => ReadHere<IntPtr>(nameof(PatchLoadLibrary)); set => WriteHere(nameof(PatchLoadLibrary), value); }

        [Offset(16UL)]
        public IntPtr PatchGetProcAddress { get => ReadHere<IntPtr>(nameof(PatchGetProcAddress)); set => WriteHere(nameof(PatchGetProcAddress), value); }

        public LdrHotPatchData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LdrHotPatchData>();
        }
    }
}