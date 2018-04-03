using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Travel
{
    /// <summary>
    /// Информация о путешествии
    /// программа для Турагентcтва
    /// </summary>
    public class RideRequestDto
    {
        /// <summary>
        /// Дата заполнения
        /// </summary>
        public DateTime Filled { get; set; }
        /// <summary>           
        /// ФИО 
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Описание путешествия
        /// </summary>
        public List<WayPoint> WayPoints { get; set; }
        /// <summary>
        /// Стоимость
            /// </summary>
            public double Price { get; set; }
            public Currency Currency { get; set; }
        /// <summary>
        /// Требования к участвующим в путешествии
        /// </summary>
        public TravelRequirements Tr { get; set; }
    }

    public enum Currency
    {
        Rubles
    }

    /// <summary>
    /// Требования к участвующим
    /// </summary>
    public class TravelRequirements
    {
        /// <summary>
        /// Не берут курящих
        /// </summary>
        public bool NoSmoking { get; set; }
        /// <summary>
        /// Требования к детям
        /// </summary>
        public List<BabyRequirements> Baby{ get; set; }
    }

    /// <summary>
    /// Требования к детям
    /// </summary>
    public class BabyRequirements
    {
        /// <summary>
        /// Возраст ребёнка
        /// </summary>
        public int Age { get; set; }
    }
    /// <summary>
    /// Место встречи для отправления
    /// </summary>
    public class WayPoint
    {
        /// <summary>
        /// Адрес
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Latitude { get; set; }
        /// <summary>
        /// Долгота
        /// </summary>
        public double? Longtitude { get; set; }
        /// <summary>
        /// Тип точки
        /// </summary>
        public WayPointType Type { get; set; }

    }

    /// <summary>
    /// Тип точки
    /// </summary>
    public enum WayPointType
    {
        Start,
        Pickpoint,
        Await,
        Stop,
    }
}
