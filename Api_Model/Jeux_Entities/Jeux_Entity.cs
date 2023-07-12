namespace Api_Model.Jeux_Entities
{
    public class Jeux_Entity
    {
        public int Id { get; }
        public string Title { get; set; }
        public DateTime DateSortie { get; set; }
        public int Note { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
    }
}