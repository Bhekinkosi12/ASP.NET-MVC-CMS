/* http://www.zkea.net/ Copyright 2016 ZKEASOFT http://www.zkea.net/licenses */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Easy.Models
{
    [Serializable]
    public class HumanBase : EditorEntity
    {
        /// <summary>
        /// 姓
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// 名
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// 英文名
        /// </summary>
        public string EnglishName { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int? Age { get { return Birthday.HasValue ? (DateTime.Now.Year - Birthday.Value.Year) : 0; } }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime? Birthday { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public int? Sex { get; set; }
       
        public string Birthplace { get; set; }
       
        public string Address { get; set; }
      
        public string ZipCode { get; set; }
      
        public string School { get; set; }
     
        public string Telephone { get; set; }
      
        public string MobilePhone { get; set; }
      
        public string Profession { get; set; }
    
        public int? MaritalStatus { get; set; }
     
        public string Hobby { get; set; }
   
        public string QQ { get; set; }

        public string Email { get; set; }
    }
}
