using backend_part.Models;
using backend_part.Services.Comment;
using backend_part.Services.Model;
using DocumentFormat.OpenXml.EMMA;
using DocumentFormat.OpenXml.ExtendedProperties;
using DocumentFormat.OpenXml.Office2019.Word.Cid;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Utilities;

namespace backend_part.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        /*private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpPost("comment")]
        public async Task<IActionResult> postComment(AddComment newComment)
        {
            var comment = await _commentService.postComment(newComment);

            return Ok(comment);
        }

        [HttpGet("{TaskId}")]
        public async Task<ActionResult<List<UserComment>?>> getComment(int TaskId)
        {
            var comment = await _commentService.getComment(TaskId);


            if (comment == null)
            {
                return NotFound("Notes list is Empty..!");
            }

            return Ok(comment);
        }

        */

        private readonly DataContext _context;
        public CommentController(DataContext context)
        {
            _context = context;
        }

        [HttpPost("comment")]
        public async Task<List<UserComment>> AddComment(AddComment request)
        {
            var Comment = new UserComment
            {
                TaskId= request.TaskId,
                Name = request.Name,
                Body = request.Body,
                UserID = request.UserID,
                ParentId=request.ParentId
            };
            Comment.CreatedAt = DateTime.Now;
            _context.Comments.Add(Comment);
            await _context.SaveChangesAsync();
            var newComment = await _context.Comments.ToListAsync();

            return newComment;
        }

        [HttpPost("edit")]
        public async Task<List<UserComment>> EditComment(EditComment request)
        {
            var comment = await _context.Comments.FirstOrDefaultAsync(u => u.id == request.id);

            comment.Body = request.Body;

            comment.CreatedAt = DateTime.Now;

            await _context.SaveChangesAsync();

            var newComment = await _context.Comments.ToListAsync();

            return newComment;
        }

        [HttpPost("reply")]
        public async Task<List<UserComment>> ReplyComment(ReplyComment request)
        {
            var Comment = new UserComment
            {
                TaskId = request.TaskId,
                Name = request.Name,
                Body = request.Body,
                UserID = request.UserID,
                ParentId = request.ParentId,
            };
            Comment.CreatedAt = DateTime.Now;
            _context.Comments.Add(Comment);
            await _context.SaveChangesAsync();

            var newComment = await _context.Comments.ToListAsync();

            return newComment;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> getComment(int id)
        {
            var comment = await _context.Comments.FindAsync(id);


            if (comment == null)
            {
                return NotFound("Comment list is Empty..!");
            }

            return Ok(comment);
        }

        [HttpDelete("{id}")]
        public async Task<List<UserComment>> deleteComment(int id)
        {
            
            var comment = await _context.Comments.FindAsync(id);

            
            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();

            var newComment = await _context.Comments.ToListAsync();

            return newComment;

        }

        [HttpGet]
        public async Task<ActionResult> getdata()
        {
            var comment = await _context.Comments.ToListAsync();


            if (comment == null)
            {
                return NotFound("Comment list is Empty..!");
            }

            return Ok(comment);
        }

    }
}
