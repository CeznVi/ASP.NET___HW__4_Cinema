namespace CinemaLib
{
    [Serializable]
    public class CinemaModel
    {
        /// <summary>
        /// Название фильма
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Режисеры
        /// </summary>
        public List<string> Director { get; set; }
        /// <summary>
        /// Жанр
        /// </summary>
        public List<string> Style { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string Info { get; set; }
        /// <summary>
        /// Список сеансов
        /// </summary>
        public List<string> Seances { get; set; }

    }
}
