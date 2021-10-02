
namespace Shop_Gosha_Dudar_.Data.Models
{
    public class Car
    {
        /// <summary>
        /// Id машины
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Название машины
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Короткое описание машины
        /// </summary>
        public string shortDesc { get; set; }
        /// <summary>
        /// Полное описание машины
        /// </summary>
        public string longDesc { get; set; }
        /// <summary>
        /// URL-ссылка на изображение машины
        /// </summary>
        public string img { get; set; }
        /// <summary>
        /// Цена машины
        /// </summary>
        public ushort price { get; set; }
        /// <summary>
        /// Добавлена ли машины в избранное
        /// </summary>
        public bool isFavorite { get; set; }
        /// <summary>
        /// Доступно ли объявление машины
        /// </summary>
        public bool available { get; set; }
        /// <summary>
        /// ID категории, к которой относится машина
        /// </summary>
        public int categoryID { get; set; }
        /// <summary>
        /// Ссылка на объект класса Category, категории, к которой относится машина
        /// </summary>
        public virtual Category Category { get; set;}
    }
}
