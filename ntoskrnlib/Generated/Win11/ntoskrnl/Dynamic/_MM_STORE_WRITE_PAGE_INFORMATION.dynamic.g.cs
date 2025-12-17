using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MM_STORE_WRITE_PAGE_INFORMATION")]
    public sealed class _MM_STORE_WRITE_PAGE_INFORMATION : DynamicStructure
    {
        public int IssueStatus { get; }
        public _MM_STORE_KEY StoreKey { get; }
        public _MM_STORE_KEY_DESCRIPTOR StoreKeyDescriptor { get; }
        public uint WritePageIndex { get; }
        public IntPtr OpaqueStoreContext { get; }
        public IntPtr Mdl { get; }
        public IntPtr TransferContext { get; }
        public IntPtr IoStatus { get; }

        public _MM_STORE_WRITE_PAGE_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MM_STORE_WRITE_PAGE_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MM_STORE_WRITE_PAGE_INFORMATION.IssueStatus),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MM_STORE_WRITE_PAGE_INFORMATION.StoreKey),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_MM_STORE_WRITE_PAGE_INFORMATION.StoreKeyDescriptor),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MM_STORE_WRITE_PAGE_INFORMATION.WritePageIndex),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MM_STORE_WRITE_PAGE_INFORMATION.OpaqueStoreContext),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MM_STORE_WRITE_PAGE_INFORMATION.Mdl),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MM_STORE_WRITE_PAGE_INFORMATION.TransferContext),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_MM_STORE_WRITE_PAGE_INFORMATION.IoStatus),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_MM_STORE_WRITE_PAGE_INFORMATION>((mem, ptr) => new _MM_STORE_WRITE_PAGE_INFORMATION(mem, ptr), offsets);
        }
    }
}