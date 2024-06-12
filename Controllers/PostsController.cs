// Controllers/PostsController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; // Add this line
using System.Collections.Generic;
using System.Linq;

[ApiController]
[Route("api/[controller]")]
public class PostsController : ControllerBase
{
    private readonly BlogDbContext _context;

    public PostsController(BlogDbContext context)
    {
        _context = context;
    }

    // GET: api/Posts
    [HttpGet]
    public IEnumerable<Post> GetPosts()
    {
        return _context.Posts.ToList();
    }

    // GET: api/Posts/5
    [HttpGet("{id}")]
    public ActionResult<Post> GetPost(int id)
    {
        var post = _context.Posts.Find(id);
        if (post == null)
        {
            return NotFound();
        }

        return post;
    }

    // POST: api/Posts
    [HttpPost]
    public ActionResult<Post> CreatePost(Post post)
    {
        post.CreatedAt = DateTime.UtcNow;
        _context.Posts.Add(post);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetPost), new { id = post.Id }, post);
    }

    // PUT: api/Posts/5
    [HttpPut("{id}")]
    public IActionResult UpdatePost(int id, Post post)
    {
        if (id != post.Id)
        {
            return BadRequest();
        }

        _context.Entry(post).State = EntityState.Modified;
        _context.SaveChanges();

        return NoContent();
    }

    // DELETE: api/Posts/5
    [HttpDelete("{id}")]
    public IActionResult DeletePost(int id)
    {
        var post = _context.Posts.Find(id);
        if (post == null)
        {
            return NotFound();
        }

        _context.Posts.Remove(post);
        _context.SaveChanges();

        return NoContent();
    }
}