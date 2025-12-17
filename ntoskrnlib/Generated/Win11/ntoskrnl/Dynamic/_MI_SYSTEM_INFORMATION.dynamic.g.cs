using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_SYSTEM_INFORMATION")]
    public sealed class _MI_SYSTEM_INFORMATION : DynamicStructure
    {
        public _MI_POOL_STATE Pools { get; }
        public _MI_SECTION_STATE Sections { get; }
        public _MI_SYSTEM_IMAGE_STATE SystemImages { get; }
        public _MI_PROCESS_STATE Processes { get; }
        public _MI_HARDWARE_STATE Hardware { get; }
        public _MI_SYSTEM_VA_STATE SystemVa { get; }
        public _MI_COMBINE_STATE PageCombines { get; }
        public _MI_PAGELIST_STATE PageLists { get; }
        public _MI_PARTITION_STATE Partitions { get; }
        public _MI_SHUTDOWN_STATE Shutdowns { get; }
        public _MI_ERROR_STATE Errors { get; }
        public _MI_DEBUGGER_STATE Debugger { get; }
        public _MI_STANDBY_STATE Standby { get; }
        public _MI_SYSTEM_PTE_STATE SystemPtes { get; }
        public _MI_IO_PAGE_STATE IoPages { get; }
        public _MI_PAGING_IO_STATE PagingIo { get; }
        public _MI_COMMON_PAGE_STATE CommonPages { get; }
        public _MI_SYSTEM_TRIM_STATE Trims { get; }
        public _MI_SYSTEM_ACCELERATORS Accelerators { get; }
        public _MI_HOT_PATCH_STATE HotPatch { get; }
        public _MI_ENCLAVE_STATE Enclaves { get; }
        public ulong Cookie { get; }
        public IntPtr BootRegistryRuns { get; }
        public int ZeroingDisabled { get; }
        public byte FullyInitialized { get; }
        public byte SafeBooted { get; }
        public IntPtr TraceLogging { get; }
        public _MI_VISIBLE_STATE Vs { get; }

        public _MI_SYSTEM_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_SYSTEM_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_SYSTEM_INFORMATION.Pools),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_INFORMATION.Sections),
                    new ulong[]
                    {
                        448UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_INFORMATION.SystemImages),
                    new ulong[]
                    {
                        3520UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_INFORMATION.Processes),
                    new ulong[]
                    {
                        4096UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_INFORMATION.Hardware),
                    new ulong[]
                    {
                        4224UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_INFORMATION.SystemVa),
                    new ulong[]
                    {
                        9088UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_INFORMATION.PageCombines),
                    new ulong[]
                    {
                        13248UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_INFORMATION.PageLists),
                    new ulong[]
                    {
                        13280UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_INFORMATION.Partitions),
                    new ulong[]
                    {
                        13568UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_INFORMATION.Shutdowns),
                    new ulong[]
                    {
                        13824UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_INFORMATION.Errors),
                    new ulong[]
                    {
                        13952UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_INFORMATION.Debugger),
                    new ulong[]
                    {
                        14208UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_INFORMATION.Standby),
                    new ulong[]
                    {
                        37056UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_INFORMATION.SystemPtes),
                    new ulong[]
                    {
                        37440UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_INFORMATION.IoPages),
                    new ulong[]
                    {
                        42816UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_INFORMATION.PagingIo),
                    new ulong[]
                    {
                        43072UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_INFORMATION.CommonPages),
                    new ulong[]
                    {
                        43248UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_INFORMATION.Trims),
                    new ulong[]
                    {
                        43392UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_INFORMATION.Accelerators),
                    new ulong[]
                    {
                        43520UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_INFORMATION.HotPatch),
                    new ulong[]
                    {
                        43568UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_INFORMATION.Enclaves),
                    new ulong[]
                    {
                        43640UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_INFORMATION.Cookie),
                    new ulong[]
                    {
                        43712UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_INFORMATION.BootRegistryRuns),
                    new ulong[]
                    {
                        43720UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_INFORMATION.ZeroingDisabled),
                    new ulong[]
                    {
                        43728UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_INFORMATION.FullyInitialized),
                    new ulong[]
                    {
                        43732UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_INFORMATION.SafeBooted),
                    new ulong[]
                    {
                        43733UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_INFORMATION.TraceLogging),
                    new ulong[]
                    {
                        43736UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_INFORMATION.Vs),
                    new ulong[]
                    {
                        43776UL
                    }
                }
            };
            Register<_MI_SYSTEM_INFORMATION>((mem, ptr) => new _MI_SYSTEM_INFORMATION(mem, ptr), offsets);
        }
    }
}