using System;
using System.Collections.Generic;
using System.Text;

namespace AppPortal.Core.Entities.v2
{
    public class V2Comment : BaseEntity<long>
    {
        public string SenderFullName { get; set; } // Họ tên người gởi
        public string SenderAddress { get; set; } // Địa chỉ người gửi
        public string SenderPhone { get; set; } // Số điện thoại người gửi
        public string SenderEmail { get; set; } // Email người gửi

        public string AgentOrg { get; set; } // Tổ chưc cá nhân gây ô nhiêm
        public string LonLat { get; set; } // vị độ, kinh độ
        public string Address { get; set; } // Địa chỉ xảy ra
        public string Description { get; set; } // Mô tả 
        public string Behavior { get; set; } // Hành vi
        public DateTime? CreateDate { get; set; }// Thời gian xảy ra vụ việc

        public string FileName { get; set; }  // tệp tin
        public string FileType { get; set; }
        public byte[] FileData { get; set; }
        public string FileUrl{ get; set; }

        public int V2ReceptionId { get; set; } // Hình thức tiếp nhận Id
        public string V2ReceptionName { get; set; } // Hình thức tiếp nhận
        public string UserId { get; set; } // Người tiếp nhận thôn gtin
        
        public DateTime? DateCreated { get; set; } // Ngày gửi yêu cầu 
        public DateTime? DateReceive { get; set; } // Thời gian tiếp nhận

        public string Authorization { get; set; } // Thẩm quyền xử lý

        public int V2IncidentId { get; set; } // Tính chất vụ việc Id
        public string IncidentName { get; set; } // Tính chất vụ việc
        public string IncidentType { get; set; } // Loại vụ việc

        public int StatusId { get; set; } // Tình trạng Id
        public string StatusName { get; set; } // Tình trạng vụ việc
    }
}
