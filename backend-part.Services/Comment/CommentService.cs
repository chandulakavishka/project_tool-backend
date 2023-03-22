using backend_part.Data;
using backend_part.Models;
using DocumentFormat.OpenXml.Office2016.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend_part.Services.Comment
{
    public class CommentService : ICommentService
    {
        /*private readonly DataContext _context;

        public CommentService(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> postComment(AddComment newComment)
        {
            var Comment = new UserComment
            {
                TaskId= newComment.TaskId,
                Name = newComment.Name,
                Body = newComment.Body,
                UserID = newComment.UserID
        };
            Comment.CreatedAt = DateTime.Now;
            _context.Comments.Add(Comment);
            await _context.SaveChangesAsync();

            return (IActionResult)await _context.Comments.ToListAsync();
        }

        public async Task<List<UserComment?>> getComment(int TaskId)
        {
            var comments = await _context.Comments.ToListAsync<UserComment>();

            return comments;
        }*/
    }
}
