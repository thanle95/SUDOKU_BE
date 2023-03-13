using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SUDOKU_BE.Models
{
    public class LogRequest
    {
        public string InitMatrix { get; set; } = string.Empty;
        public string SolvedMatrix { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime SolvedDate { get; set; }
    }
}