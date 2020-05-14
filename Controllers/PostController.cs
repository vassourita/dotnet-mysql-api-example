using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using blog.Models;
using blog.Data;

namespace blog.Controllers
{
    [ApiController]
    [Route("posts")]
    public class PostController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Post>>> Index([FromServices] DataContext context)
        {
            var posts = await context.Posts.ToListAsync();

            return posts;
        }

        [HttpGet("{id}")]
        [Route("")]
        public async Task<ActionResult<Post>> Show([FromServices] DataContext context, [FromRoute] int id)
        {
            var post = await context.Posts.Where(x => x.Id == id).ToListAsync();

            if (post.Any())
            {
                return post[0];
            }

            return NotFound("Post not found");
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Post>> Store([FromServices] DataContext context, [FromBody] Post model)
        {
            context.Posts.Add(model);
            await context.SaveChangesAsync();

            return model;
        }
    }
}
