using CheckDuplicateValue.Models;
using CheckDuplicateValue.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CheckDuplicateValue.Repository
{
   public class ProductRepository : IProductRepository
   {
      private readonly IProductRepository _repository;
      private readonly DbModel _context;
      public ProductRepository(DbModel context,IProductRepository repository)
      {
         this._repository = repository;
         this._context = context;
      }
      public async Task<MessageHelper> Save(List<ProductViewModel> model)
      {
         List<Product> objList = new List<Product>();
         
         foreach(var item in model)
         {
            new Product()
            {
               Name = item.Name,
               Description = item.Description,
               Price = item.Price,
            };
         }
         await _context.Products.AddRangeAsync(objList);   
         await _context.SaveChangesAsync();
         return new MessageHelper()
         {
            Status = 200, Message = "Successfully Saved"
         };   
         
      }
   }
}
