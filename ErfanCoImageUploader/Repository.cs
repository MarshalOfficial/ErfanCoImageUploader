using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ErfanCoImageUploader
{
    public class Repository
    {
        ERFANEntities _context;
        public Repository()
        {
            _context = new ERFANEntities(Extension.GetEfConnectionString("ErfanDB"));
        }

        public void RunStartupScript()
        {
            _context.Database.ExecuteSqlCommand(@"  insert into [TOrder].[ProductPictures]([ERPCode])
                                                    select p.[ERPCode] from [TOrder].[Products](nolock) p left join [TOrder].[ProductPictures](nolock) i on p.ERPCode=i.ERPCode
                                                    Where i.ID is null  ");
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.AsNoTracking().ToList();
        }

        public ProductPicture GetProductPic(string erpcode)
        {
            return _context.ProductPictures.AsNoTracking().FirstOrDefault(l => l.ERPCode == erpcode);
        }

        public void SetProductPicture(string erpcode,byte[] data)
        {
            _context.Database.ExecuteSqlCommand(" update [TOrder].[ProductPictures] set [Picture]=@picture Where [ERPCode]=@erpcode ", new SqlParameter("@picture", data), new SqlParameter("@erpcode", erpcode));
            //_context.Database.ExecuteSqlCommand(string.Format(@"  update [TOrder].[ProductPictures] set [Picture]=CONVERT(VARBINARY(max),'{1}') Where [ERPCode]='{0}'  ", erpcode, data));
        }

        public void ClearProductImage(string erpcode)
        {
            _context.Database.ExecuteSqlCommand(string.Format(@"  update [TOrder].[ProductPictures] set [Picture]=null Where [ERPCode]='{0}'  ", erpcode));
        }
    }
}