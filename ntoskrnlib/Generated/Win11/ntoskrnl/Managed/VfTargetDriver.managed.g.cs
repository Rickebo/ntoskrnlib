using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VF_TARGET_DRIVER")]
    public sealed class VfTargetDriver : DynamicStructure
    {
        [Offset(0UL)]
        public VfAvlTreeNode TreeNode { get => ReadStructure<VfAvlTreeNode>(nameof(TreeNode)); set => WriteStructure(nameof(TreeNode), value); }

        [Offset(16UL)]
        public UnnamedTag u1 { get => ReadStructure<UnnamedTag>(nameof(u1)); set => WriteStructure(nameof(u1), value); }

        [Offset(40UL)]
        public IntPtr DriverObject { get => ReadHere<IntPtr>(nameof(DriverObject)); set => WriteHere(nameof(DriverObject), value); }

        [Offset(48UL)]
        public IntPtr Callbacks { get => ReadHere<IntPtr>(nameof(Callbacks)); set => WriteHere(nameof(Callbacks), value); }

        [Offset(56UL)]
        public uint AssignedPluginId { get => ReadHere<uint>(nameof(AssignedPluginId)); set => WriteHere(nameof(AssignedPluginId), value); }

        [Offset(64UL)]
        public IntPtr VerifiedData { get => ReadHere<IntPtr>(nameof(VerifiedData)); set => WriteHere(nameof(VerifiedData), value); }

        public VfTargetDriver(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<VfTargetDriver>();
        }
    }
}