namespace CinemaLib
{
    public class CinemaModel
    {
        /// <summary>
        /// Название фильма
        /// </summary>
        public string name ="";
        /// <summary>
        /// Режисеры
        /// </summary>
        public List<string> director = new List<string>();
        /// <summary>
        /// Жанр
        /// </summary>
        public List<string> style = new List<string>();
        /// <summary>
        /// Описание
        /// </summary>
        public string info = "";
        /// <summary>
        /// Список сеансов
        /// </summary>
        public List<string> seances=new List<string>();
    }
}
