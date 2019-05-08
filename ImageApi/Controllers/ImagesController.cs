using ImageApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ImageApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly ImageApiContext _context;

        public ImagesController(ImageApiContext context)
        {
            _context = context;
        }

        // GET: api/Images
        [HttpGet]
        public IEnumerable<Image> GetImage()
        {
            return _context.Image;
        }

        // GET: api/Images/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetImage([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            IQueryable<Image> images = _context.Image.Where(i => i.PropertyId == id);

            if (images == null)
            {
                return NotFound();
            }

            return Ok(images);
        }

        //// PUT: api/Images/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutImage([FromRoute] long id, [FromBody] Image image)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != image.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(image).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ImageExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/Images
        [HttpPost]
        public async Task<IActionResult> PostImage(IFormFile File)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (File == null || File.Length == 0)
                return Content("file not selected");

            string path = Path.Combine(
                  Directory.GetCurrentDirectory(), "wwwroot",
                  File.FileName);
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await File.CopyToAsync(stream);
            }

            Image image = new Image
            {
                PropertyId = 1234,
                ImgPath = path
            };

            _context.Image.Add(image);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetImage", new { id = image.Id }, image);
        }

        // DELETE: api/Images/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteImage([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Image image = await _context.Image.FindAsync(id);
            if (image == null)
            {
                return NotFound();
            }

            _context.Image.Remove(image);
            await _context.SaveChangesAsync();

            return Ok(image);
        }

        private bool ImageExists(long id)
        {
            return _context.Image.Any(e => e.Id == id);
        }
    }
}