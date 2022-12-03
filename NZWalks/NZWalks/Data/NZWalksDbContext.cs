﻿using Microsoft.EntityFrameworkCore;
using NZWalks.Models.Domain;

namespace NZWalks.Data
{
    public class NZWalksDbContext:DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> options):base(options)
        {

        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }

        public DbSet<WalkDifficulty> WalkDifficultys { get; set; }
    }
}
