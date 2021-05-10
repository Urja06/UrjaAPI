using System;
using System.Collections.Generic;
using System.Text;

namespace Urja.Utility.Helper
{
    public class BaseResponseModel
    {
        public BaseResponseModel()
        {
            Data = null;
            Message = null;
        }
        public object Data { get; set; }
        public string Message { get; set; }
        public long StatusCode { get; set; }
    }
}
