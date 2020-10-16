using System;
using System.Data.Entity;
namespace ErfanCoImageUploader
{
    public partial class ERFANEntities : DbContext
    {
        public ERFANEntities(String connectionString)
            : base(connectionString)
        {

        }
    }   
}
