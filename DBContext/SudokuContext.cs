using Microsoft.EntityFrameworkCore;
using SUDOKU_BE.Models;
using System.Collections.Generic;

namespace SUDOKU_BE.DataContext
{
    public class SudokuContext : DbContext
    {
        public SudokuContext(DbContextOptions<SudokuContext> options) : base(options) { }

        public DbSet<Log> Logs { get; set; }

    }
}
