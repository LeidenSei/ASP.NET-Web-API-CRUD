using WebMVCCore.Models;
namespace WebMVCCore.Repository
{
    public interface ITypeProductRepository
    {
        TLoaiSp Add(TLoaiSp loaiSp);
        TLoaiSp Update (TLoaiSp loaiSp);
        TLoaiSp Delete(String  maloaiSp);

        TLoaiSp GetLoaiSp(String maloaiSp);

        IEnumerable<TLoaiSp> GetAllLoaiSp();

    }
}
