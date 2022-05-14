using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class UserConfiguration
    {
        public int UserConfigurationId { get; set; }
        public int BelongsToUser { get; set; }
        public string TimeZone { get; set; }
        public int? TaskEventStartTime { get; set; }
        public int? TaskEventEndTime { get; set; }
        public int? EventCharacterLimit { get; set; }

        public virtual User BelongsToUserNavigation { get; set; }
    }
}
