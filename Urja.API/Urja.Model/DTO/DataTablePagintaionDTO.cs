using System;
using System.Collections.Generic;
using System.Text;

namespace Urja.Model.DTO
{
    public class DataTablePagintaionDTO
    {
        public DataTablePagintaionDTO()
        {
            sortOrder = 1;
        }
        public string searchText { get; set; }
        public string sortColumn { get; set; }
        public int sortOrder { get; set; }
        public int pageSize { get; set; }
        public int pageIndex { get; set; }
    }
}
