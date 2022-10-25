using CheckDuplicateValue.Models;
using CheckDuplicateValue.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CheckDuplicateValue.Repository
{
   public interface IProductRepository
   {
      Task<MessageHelper> Save(List<ProductViewModel> products);
   }
}
