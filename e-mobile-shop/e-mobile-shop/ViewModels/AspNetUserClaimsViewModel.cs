﻿namespace e_mobile_shop.ViewModels
{
    public partial class AspNetUserClaimsViewModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual AspNetUsersViewModel User { get; set; }
    }
}
