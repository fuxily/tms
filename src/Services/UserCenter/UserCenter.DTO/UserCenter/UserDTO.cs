using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Zh.UserCenter.DTO.UserCenter
{
    public class UserDTO
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION 
        ////ECC/ END CUSTOM CODE SECTION 
        public long Id { get; set; }
        public string LoginName { get; set; }
        public string Portrait { get; set; }
        public string NickName { get; set; }
    }
}
