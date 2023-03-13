using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SUDOKU_BE.DataContext;
using SUDOKU_BE.Models;
using System.Security.Claims;

namespace SUDOKU_BE.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LogController : Controller
    {
        private readonly SudokuContext sudokuContext;
        public LogController(SudokuContext sudokuContext)
        {
            this.sudokuContext = sudokuContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLogs()
        {
            var logs = await this.sudokuContext.Logs.ToListAsync();
            return Ok(logs);
        }
        [HttpPost]
        public async Task<IActionResult> PostLog(LogRequest request)
        {
            this.sudokuContext.Logs.Add(new Log()
            {
                InitMatrix = request.InitMatrix,
                SolvedMatrix= request.SolvedMatrix,
                StartDate= request.StartDate,
                SolvedDate= request.SolvedDate,
            });
            return Ok(await this.sudokuContext.SaveChangesAsync() == 1);
        }
    }
}