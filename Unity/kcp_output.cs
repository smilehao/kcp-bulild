namespace KCP
{
    using System;

    public delegate int kcp_output(IntPtr buf, int len, IntPtr kcp, IntPtr user);
}

