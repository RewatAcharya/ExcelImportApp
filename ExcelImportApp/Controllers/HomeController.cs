using System.Collections.Generic;
using System.IO;
using System.Web;
using ExcelImportApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using OfficeOpenXml;
using Microsoft.EntityFrameworkCore;
using ExcelImportApp.Data;

namespace ExcelImportApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _context.Table1s
                                                //.Where(c => c.Id != 0)
                                                //.Select(x => new Table1()
                                                //{
                                                //    Id = x.Id,

                                                //})
                .ToListAsync();
            return View(values);
        }

        [HttpPost]
        public async Task<ActionResult> Import(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                ModelState.AddModelError("File", "Please upload a file.");
                return View("Index");
            }

            // Validate file type (e.g., .xlsx)
            if (!file.FileName.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase))
            {
                ModelState.AddModelError("File", "Please upload a valid Excel file (.xlsx).");
                return View("Index");
            }

            using var transaction = _context.Database.BeginTransaction();

            var data = new List<Table1>();
            try
            {
                using var package = new ExcelPackage(file.OpenReadStream());

                var worksheet = package.Workbook.Worksheets[1];
                var rowCount = worksheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++)
                {
                    var table1Record = new Table1
                    {
                        FullName = worksheet.Cells[row, 1].Text,
                        DOB = worksheet.Cells[row, 2].Text,
                        IsInjured = worksheet.Cells[row, 3].Text,
                        Education = worksheet.Cells[row, 4].Text,
                        Occupation = worksheet.Cells[row, 5].Text,
                        Relation = worksheet.Cells[row, 6].Text,
                        RelationDOB = worksheet.Cells[row, 7].Text,
                        Index = worksheet.Cells[row, 8].Text,
                        ParentTableName = worksheet.Cells[row, 9].Text,
                        ParentIndex = worksheet.Cells[row, 10].Text,
                        SubId = worksheet.Cells[row, 11].Text,
                        SubUUID = worksheet.Cells[row, 12].Text,
                        SubTime = worksheet.Cells[row, 13].Text,
                        SubValidation = worksheet.Cells[row, 14].Text,
                        SubNotes = worksheet.Cells[row, 15].Text,
                        SubStatus = worksheet.Cells[row, 16].Text,
                        SubBy = worksheet.Cells[row, 17].Text,
                        SubVersion = worksheet.Cells[row, 18].Text,
                        SubTags = worksheet.Cells[row, 19].Text
                    };
                    data.Add(table1Record);
                }

                _context.Table1s.AddRange(data);
                await _context.SaveChangesAsync();
                transaction.Commit(); 
                
                return View("Index", data);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "An error occurred while processing the file.");
                transaction.Rollback();
                return View("Index");
            }
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
