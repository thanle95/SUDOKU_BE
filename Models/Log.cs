using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SUDOKU_BE.Models
{
    [Table("SudokuLog")]
    public class Log
    {
        [Key]
        public Int64 ID { get; set; }
        public string InitMatrix { get; set; } = string.Empty; //81 chars
        public string SolvedMatrix { get; set; } = string.Empty; //81 chars
        public DateTime StartDate { get; set; }
        public DateTime SolvedDate { get; set; }
    }
}