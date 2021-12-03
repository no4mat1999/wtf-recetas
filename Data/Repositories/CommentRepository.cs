using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Data.Repositories {
    public class CommentRepository {
        private RSDBContext _context;

        public CommentRepository(RSDBContext context) { 
            this._context = context;
        }

        public CommentRepository() { 
            this._context = new RSDBContext();
        }

        public List<Comment> Get(int? id) {
            return this._context.Comments.Where(c => c.Id == id).ToList();
        }

        public void Add(Comment comment) {
            this._context.Comments.Add(comment);
            this._context.SaveChanges();
        }

        public void Delete(Comment comment) {
            this._context.Comments.Remove(comment);
            this._context.SaveChanges();
        }

        public void Update(Comment comment) {
            Comment oldComment = this._context.Comments.Find(comment.Id);
            this._context.Entry(oldComment).CurrentValues.SetValues(comment);
            this._context.SaveChanges();
        }

    }
}
