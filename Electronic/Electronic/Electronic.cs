using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Electronic


{
    /// <summary> Программа составления заявления на покупку ноутбука в интернет-магазине техники
    /// Информация о заявлении 
    /// </summary>
    public class Choice
    {
        /// <summary>
        /// Дата заполнения
        /// </summary>
        public NewTime NewTime { get; set; }
        /// <summary>
        /// ФИО покупателя
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Сведения о ноутбуке
        /// </summary>

        public string Name { get; set; }
        /// <summary>
        /// Оперативная память
        /// </summary>
        public string Memory { get; set; }
        /// <summary>
        /// Видеокарта
        /// </summary>
        public string VideoCard { get; set; }
        /// <summary>
        /// Процессор
        /// </summary>
        public string Processor { get; set; }


        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Price { get; set; }
        

    }

    /// <summary>   
    /// Наименование марки производителя
    /// </summary>


    /// <summary>
    /// Сведения о ноутбуке
    /// </summary>
    



   
    /// <summary>
    /// Наименования ноутбуков
    /// </summary>

    public class NewTime
        {
            public DateTime Filled { get; set; }
        }


}
