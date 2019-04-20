namespace DrawApp.UI
{
    public class TeamModels
    {
        public string Name { get; set; } = "Country";
        public int W { get; set; } = 0;
        public int D { get; set; } = 0;
        public int L { get; set; } = 0;
        public int Points { get; set; } = 0;
        public int PlusMinus { get; set; } = 0;
        public int GoalsScored { get; set; } = 0;
        public int GoalsReceived { get; set; } = 0;
        public string ImgURL { get; set; }

        public TeamModels(string name)
        {
            Name = name;
        }
    }
}
