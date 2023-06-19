using backend_part.Data;
using backend_part.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_part.Services
{
    public class SharePointService: ISharePoint
    {
        private readonly DataContext _dBAccess = new DataContext();

        public int GetSharePoint(int id, int InnovativeId)
        {
            return 0;
        }

        public void AddSharePoint(SharePoint sharePoint)
        {
            throw new NotImplementedException();
        }

        public SharePoint GetSharePoint(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateSharePoint(int Id, int sharepoint)
        {
            throw new NotImplementedException();
        }
    }
}
