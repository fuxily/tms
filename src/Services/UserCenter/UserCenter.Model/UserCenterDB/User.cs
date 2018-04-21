using System;
using System.Collections.Generic;

namespace Zh.UserCenter.Model.UserCenterDB
{
    public partial class User
    {
        []
        public long Id { get; set; }
        public string LoginName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Pwd { get; set; }
        public string Portrait { get; set; }
        public string NickName { get; set; }
        public string RealName { get; set; }
        public string IdCardNo { get; set; }
        public string Address { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
