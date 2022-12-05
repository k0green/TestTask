namespace TestTask
{
    public class TVSeries
    {
        public string Name { get; set; }
        public int Season { get; set; }
        public int Series { get; set; }
        public int DurationTime { get; set; }

        public int ViewingTime => Season*Series*DurationTime;

        public TVSeries(string name, int season, int series, int durationTime)
        {
            Name = name;
            Season = season;
            Series = series;
            DurationTime = durationTime;
        }
    }
}