﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Runtime.Serialization;
using System.Xml;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ConsoleApplication1
{
    /// <summary>
    /// Модель данных
    /// </summary>
    [Serializable]
    public class Model
    {
        /// <summary>
        /// Таблица Дисциплин
        /// </summary>
        public List<Discipline> Disciplines;

        /// <summary>
        /// Таблица Цели
        /// </summary>
        public List<Goal> Goals;

        /// <summary>
        /// Таблица Величин
        /// </summary>
        public List<Scale> Scales;

        /// <summary>
        /// Таблица Виды спорта
        /// </summary>
        public List<Sport> Sports;

        /// <summary>
        /// Таблица Эталонные данные
        /// </summary>
        public List<Standart_Data> Standarts_Datas;

        /// <summary>
        /// Таблица Пользователей
        /// </summary>
        public List<User> Users;

        /// <summary>
        /// Таблица Промежуточных данных пользователя
        /// </summary>
        public List<User_Data> Users_Datas;

        /// <summary>
        /// Таблица Цели пользователя
        /// </summary>
        public List<User_Goal> Users_Goals;

        /// <summary>
        /// Конструктор, инициализирует таблицы
        /// </summary>
        public Model()
        {
            Disciplines = new List<Discipline>();
            Goals = new List<Goal>();
            Scales = new List<Scale>();
            Sports = new List<Sport>();
            Standarts_Datas = new List<Standart_Data>();
            Users = new List<User>();
            Users_Datas = new List<User_Data>();
            Users_Goals = new List<User_Goal>();
        }
        /*
        public void LoadInFile()
        {
            Sports.Add(new Sport { Name = "qwe" });
            DataContractSerializer dcs = new DataContractSerializer(typeof(Model));
            StringBuilder sb = new StringBuilder();
            XmlWriter writer = XmlWriter.Create(sb);
            dcs.WriteObject(writer, this);
            writer.Close();
            string xml = sb.ToString();
            XDocument.Parse(xml).Save("data.xml");

            SaveBinaryFormat(this, "dd.xml");
        }*/

        /// <summary>
        /// Сериализация данных в бинарных файл
        /// </summary>
        /// <param name="model">Модель данных</param>
        /// <param name="fileName">Имя файла</param>
        public static void SaveBinaryFormat(Model model, string fileName)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, model);
            }
        }
        
        /// <summary>
        /// Десериализация данных из файла
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <returns></returns>
        public static Model LoadFromBinaryFile(string fileName)
        {
            BinaryFormatter binFormat = new BinaryFormatter();

            using (Stream fStream = File.OpenRead(fileName))
            {
                Model res =
                     (Model)binFormat.Deserialize(fStream);
                return res;
            }
        }

    }

    /// <summary>
    /// Запись Пользователь 
    /// </summary>
    [Serializable]
    public class User
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string Partonumic { get; set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateBirth { get; set; }
        /// <summary>
        /// Логин в системе
        /// </summary>
        public string AspnetUserLogin { get; set; }
        /// <summary>
        /// Id в системе
        /// </summary>
        public int AspnetUserId { get; set; }
    }

    /// <summary>
    /// Сущность Вид спорта
    /// </summary>
    [Serializable]
    public class Sport
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }
    }

    /// <summary>
    /// Сущность Величина
    /// </summary>
    [Serializable]
    public class Scale
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }
    }

    /// <summary>
    /// Дисциплина из вида спорта
    /// </summary>
    [Serializable]
    public class Discipline
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Вид спорта, к которому относится дисциплина
        /// </summary>
        public Sport Sport { get; set; }
        /// <summary>
        /// Величина
        /// </summary>
        public Scale Scales { get; set; }
        /// <summary>
        /// Опивание
        /// </summary>
        public string Description { get; set; }
    }

    /// <summary>
    /// Сущность Цель
    /// </summary>
    [Serializable]
    public class Goal
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Значение
        /// </summary>
        public int Value { get; set; }
        /// <summary>
        /// Дисциплина, по которой цель
        /// </summary>
        public Discipline Discipline { get; set; }
        /// <summary>
        /// Период достижения цели в днях
        /// </summary>
        public int PeriodDays { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
    }

    /// <summary>
    /// Сущность Эталонные данные
    /// </summary>
    [Serializable]
    public class Standart_Data
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Значение
        /// </summary>
        public int Value { get; set; }
        /// <summary>
        /// Цель
        /// </summary>
        public Goal Goal { get; set; }
        /// <summary>
        /// День от начала срока выполнения цели
        /// </summary>
        public int Day { get; set; }
    }

    /// <summary>
    /// Сущность Цели пользователя
    /// </summary>
    [Serializable]
    public class User_Goal
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// Цель
        /// </summary>
        public Goal Goal { get; set; }
        /// <summary>
        /// Дата постановки цели
        /// </summary>
        public DateTime DateStart { get; set; }
    }

    /// <summary>
    /// Сущность Промежуточные данные пользователя
    /// </summary>
    [Serializable]
    public class User_Data
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Цель пользователя
        /// </summary>
        public User_Goal User_Goal { get; set; }
        /// <summary>
        /// Значение
        /// </summary>
        public int value { get; set; }
        /// <summary>
        /// Дата заполнения
        /// </summary>
        public DateTime Date { get; set; }
    }





}
