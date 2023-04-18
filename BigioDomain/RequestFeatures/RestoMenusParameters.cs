namespace BigioDomain.RequestFeatures
{
    public class RestoMenusParameters : RequestParameters
    {
        public string? SearchTerm { get; set; }

        public string orderBy { get; set; } = "RemeId";
    }

}

