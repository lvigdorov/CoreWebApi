using System;
using System.Collections.Generic;

namespace CoreWebApi.DataAccess.Entities
{
    public partial class NotificationList
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
