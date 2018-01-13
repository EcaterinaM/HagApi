namespace HagBusinessLayer.DomainModels.Results
{
    public class GetNumberOfLevels
    {
        public int NumberOfLevels { get; set; }

        public GetNumberOfLevels(int numberOfLevels)
        {
            NumberOfLevels = numberOfLevels;
        }
    }
}
