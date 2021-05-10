using System;
using System.Collections.Generic;
using System.Text;

namespace Urja.Model.DTO
{
    public class PaginationModelDTO
    {
        public object List { get; set; }
        public string SearchText { get; set; }
        public string SortField { get; set; }
        public int SortType { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public long TotalPages { get; set; }
        public long TotalRows { get; set; }
    }
}
