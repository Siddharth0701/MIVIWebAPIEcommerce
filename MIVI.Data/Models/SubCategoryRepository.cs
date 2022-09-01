using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MIVI.Data.Models
{
   public class SubCategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public SubCategoryRepository(ApplicationDbContext db)
        {
            _db = db;

        }
        public IEnumerable<SubCategory> GetAllSubCategories()
        {
            return _db.SubCategory.ToList();
        }
        public void AddSubCategory(SubCategory s)
        {
            _db.SubCategory.Add(s);
            _db.SaveChanges();
        }
        public void UpdateSubCategory(SubCategory s)
        {
            _db.Entry<SubCategory>(s).State = EntityState.Modified;
            _db.SaveChanges();

        }
        public void deleteSubCategory(int id)
        {
            SubCategory sub = _db.SubCategory.Find(id);
            _db.SubCategory.Remove(sub);
            _db.SaveChanges();
        }
    }
}
