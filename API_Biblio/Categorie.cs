namespace API_Biblio
{
    public class Categorie
    {
        private int idCat;
        private string name;
        private int count;
        private string description;
        private string image;

        public Categorie(int idCat, string name, int count, string description, string image)
        {
            this.idCat = idCat;
            this.name = name;
            this.count = count;
            this.description = description;
            this.image = image;
        }
    }
}
