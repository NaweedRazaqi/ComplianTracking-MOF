﻿using System;
using System.Collections.Generic;

namespace Clean.UI.PMSModel
{
    public partial class AspNetRolesScreens
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int ScreenId { get; set; }
        public bool? IsActive { get; set; }
    }
}
