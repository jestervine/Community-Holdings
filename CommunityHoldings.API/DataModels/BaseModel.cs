using System;

namespace CommunityHoldings.API.DataModels
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        public string UserAdded { get; set; }
        public string UserModified { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime? DateModified { get; set; }
    }
}