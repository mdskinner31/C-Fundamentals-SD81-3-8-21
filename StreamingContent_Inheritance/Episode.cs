namespace StreamingContent_Inheritance
{
    public class Episode : StreamingRepository
    {
        public string Title { get; set; }

        public double RunTime { get; set; }

        public int SeasonNumber { get; set; }
      
       // public int EpisodeCountNumber { get; set; }
    }
}