using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VF_TARGET_DRIVER")]
    public sealed class _VF_TARGET_DRIVER : DynamicStructure
    {
        public _VF_AVL_TREE_NODE TreeNode { get; }
        public _unnamed_tag_ u1 { get; }
        public IntPtr DriverObject { get; }
        public IntPtr Callbacks { get; }
        public uint AssignedPluginId { get; }
        public IntPtr VerifiedData { get; }

        public _VF_TARGET_DRIVER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VF_TARGET_DRIVER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VF_TARGET_DRIVER.TreeNode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VF_TARGET_DRIVER.u1),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_VF_TARGET_DRIVER.DriverObject),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_VF_TARGET_DRIVER.Callbacks),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_VF_TARGET_DRIVER.AssignedPluginId),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_VF_TARGET_DRIVER.VerifiedData),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_VF_TARGET_DRIVER>((mem, ptr) => new _VF_TARGET_DRIVER(mem, ptr), offsets);
        }
    }
}