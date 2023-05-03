using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BNP.SeniorEvaluation.Data;
using BNP.SensiorTesting.Api.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BNP.SensiorTesting.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthorsController(ILogger<AuthorsController> logger, AppDbContext DbContext)
        {
            logger.LogDebug("Hello Authors");
            _context = DbContext;
        }

        [HttpGet]
        public IEnumerable<AuthorViewModel> Get()
        {
            var authors = _context.Authors.ToList();
            var books = _context.Books.ToList();

            var authorViewModels = new List<AuthorViewModel>();
            foreach (var author in authors)
            {
                var bookTitles = books.Where(b => b.AuthorId == author.Id)
                    .Select(b => b.Title)
                    .ToList();
                var authorViewModel = new AuthorViewModel
                {
                    Id = author.Id,
                    FirstName = author.FirstName,
                    LastName = author.LastName,
                    BookTitles = bookTitles
                };
                authorViewModels.Add(authorViewModel);
            }
            return authorViewModels;
        }
    }
}
