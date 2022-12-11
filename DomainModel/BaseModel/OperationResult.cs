using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.BaseModel
{
   public class OperationResult
    {
        public string Operation { get; set; }
        public DateTime OperationDate { get; set; }
        public bool  Success { get; set; }
         public string Message { get; set; }
        public int RecordID { get; set; }
    }
}
