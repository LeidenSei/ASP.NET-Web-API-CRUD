using WebMVCCore.Models;
using Microsoft.AspNetCore.Mvc;
using WebMVCCore.Repository;
namespace WebMVCCore.ViewComponents
{
    public class LoaiSpMenuViewComponent:ViewComponent
    {
        private readonly ITypeProductRepository _typeProductRepository;
        public LoaiSpMenuViewComponent(ITypeProductRepository typeProductRepository)
        {
            _typeProductRepository = typeProductRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var typeProduct = _typeProductRepository.GetAllLoaiSp().OrderBy(x => x.Loai);
            return View(typeProduct);
        }
    }
}
