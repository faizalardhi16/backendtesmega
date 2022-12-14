using Domain;
using Microsoft.AspNetCore.Mvc;
using Persistence;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class BPKBsController : BaseApiController
    {
        private readonly DataContext _context;

        public BPKBsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<BPKB>>> GetBPKB()
        {
            var data = await _context.BPKBs.ToListAsync();

            return Ok(data);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<BPKB>> GetDetailBPKB(Guid Id)
        {
            var data = await _context.BPKBs.FindAsync(Id);

            if (data == null)
            {
                return NotFound(new { Message = "Data Not Found" });
            }

            return Ok(data);
        }

        [HttpPost]

        public async Task<ActionResult<string>> PostBPKB(BPKB Input)
        {
            // Input.BPKBDate = new DateTime();
            // Input.BPKBDateIn = new DateTime();
            // Input.FakturDate = new DateTime();

            await _context.BPKBs.AddRangeAsync(Input);
            await _context.SaveChangesAsync();

            return Ok("Data Successfully Created");
        }

        [HttpPut("{id}")]

        public async Task<ActionResult<string>> UpdateBPKB(Guid id, BPKB input)
        {
            var detailData = await _context.BPKBs.FindAsync(id);

            if (detailData == null)
            {
                return NotFound(new { Message = "Data Not Found" });
            }

            detailData.BPKBNumber = input.BPKBNumber;
            detailData.FakturNumber = input.FakturNumber;

            await _context.SaveChangesAsync();

            return Ok("Success to Update Data");
        }
    }
}