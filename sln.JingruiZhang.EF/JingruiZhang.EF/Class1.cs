using System;

namespace JingruiZhang.EF
{
#if NET45
    public class Class1
    {
        System.Data.Entity.DbContext c;
    }
#else
    public class Class1
    {
        Microsoft.EntityFrameworkCore.DbContext c;
    }
#endif
}
