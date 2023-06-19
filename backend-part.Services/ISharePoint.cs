using backend_part.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_part.Services
{
    public interface ISharePoint
    {
        public int GetSharePoint(int id, int InnovativeId);
        public void AddSharePoint(SharePoint sharePoint);
        public SharePoint GetSharePoint(int id);
        public void UpdateSharePoint(int Id, int sharepoint);
    }
}
