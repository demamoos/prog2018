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
        public DateTime dateTime { get; set; }
        /// <summary>
        /// ФИО покупателя
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Сведения о ноутбуке
        /// </summary>
        public List <ElectronicRequirements> ElectronicRequirements { get; set; }
        /// <summary>
        /// Стоимость
        /// </summary>
        public double Price { get; set; }
        public Currency Currency { get; set; }
      
    }

    
    /// <summary>
    /// Сведения о ноутбуке
    /// </summary>
    public class ElectronicRequirements
    {   
        /// <summary>   
        /// Наименование марки производителя
        /// </summary>
        public string NameLaptop{ get; set; }
        /// <summary>
        /// Дополнительные сведения
        /// </summary>
        public List<Addition> additions { get; set; }
        public override string ToString()
        {
            return NameLaptop;
        }
        public ElectronicRequirements Clone()
        {
            return new ElectronicRequirements { NameLaptop = NameLaptop, additions = additions };
        }
    }

    
    public class  Addition
    {
        /// <summary>
        /// Оперативная память
        /// </summary>
        public int Memory { get; set; }
        /// <summary>
        /// Видеокарта
        /// </summary>
        public string VideoCard { get; set; }
        /// <summary>
        /// Процессор
        /// </summary>
        public string Processor { get; set; }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", Memory, VideoCard, Processor);
        }  
        public Addition Clone()
        {
            return new Addition { Memory = Memory, VideoCard = VideoCard, Processor = Processor };
        }

    }

    /// <summary>
    /// Наименования ноутбуков
    /// </summary>
  
    public enum Currency
    {
        Rubles
    }

}
