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
        public ElectronicRequirements ElectronicRequirements { get; set; }
        /// <summary>
        /// Дополнительные сведения
        /// </summary>
        public List<Addition> Additions { get; set; }

        /// <summary>
        /// Стоимость
        /// </summary>
        public double Price { get; set; }
        public Currency Currency { get; set; }
      
    }

    /// <summary>   
    /// Наименование марки производителя
    /// </summary>
    

    /// <summary>
    /// Сведения о ноутбуке
    /// </summary>
    public class ElectronicRequirements
    {   
        /// <summary>   
        /// Наименование марки производителя
        /// </summary>
        public List<NameLaptop> NameLaptop{ get; set; }
       
        
        public ElectronicRequirements Clone()
        {
            return new ElectronicRequirements { NameLaptop = NameLaptop};
        }
    }
    public class NameLaptop
    { /// <summary>   
      /// Наименование марки производителя
      /// </summary>
      public string Name { get; set; }

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
