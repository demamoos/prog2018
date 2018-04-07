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
        /// Требования к ноутбуку
        /// </summary>
        public ElectronicRequirements Laptop { get; set; }
        /// <summary>
        /// Стоимость
        /// </summary>
        public double Price { get; set; }
        public Currency Currency { get; set; }
      
    }

    
    /// <summary>
    /// Описание путушествия
    /// </summary>
    public class ElectronicRequirements
    {   
        /// <summary>
        /// Наименование марки производителя
        /// </summary>
        public NameLaptop NameLaptop{ get; set; }
        /// <summary>
        /// Дополнительные сведения
        /// </summary>
        public List<Addition> additions { get; set; }
    }

    
    public class  Addition
    {
        /// <summary>
        /// Оперативная память
        /// </summary>
        public Memory Memory { get; set; }
        /// <summary>
        /// Видеокарта
        /// </summary>
        public VideoCard VideoCard { get; set; }
        /// <summary>
        /// Процессор
        /// </summary>
        public Processor Processor { get; set; }

    }

    /// <summary>
    /// Наименования ноутбуков
    /// </summary>
    public enum NameLaptop
    {
        Lenovo,
        MSI,
        Asus,
        DXP,
        Samsung,
    }


    /// <summary>
    /// Типо процессора
    /// </summary>
    public enum Processor
    {
        IntelCoreI3,
        IntelCoreI5,
        IntelCoreI7,

    }
    /// <summary>
    /// Тип видеокарты
    /// </summary>
    public enum VideoCard
    {
        Nvidia,
        Radeon,
    }
    /// <summary>
    /// Количество оперативки
    /// </summary>
    public enum Memory
    {
        twogiga,
        fourgigov,
        sixgigov,
        eightgigov,
    }
    /// <summary>
    /// Валюта
    /// </summary>
    /// 
    public enum Currency
    {
        Rubles
    }

}
