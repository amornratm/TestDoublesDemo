﻿using Microsoft.EntityFrameworkCore;

namespace MemberFake
{
    internal class MemberContext : DbContext
    {
        public MemberContext(DbContextOptions<MemberContext> options)
: base(options)
        {
        }

        public DbSet<Member> Members { get; set; }
    }
}