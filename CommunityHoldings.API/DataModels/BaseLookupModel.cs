namespace CommunityHoldings.API.DataModels
{
    public abstract class BaseLookupModel : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int? SortOrder { get; set; }

        public BaseLookupModel()
        {
            IsActive = true;
        }
    }
}