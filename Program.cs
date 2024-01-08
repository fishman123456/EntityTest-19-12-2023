using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


// строка соединения в App.config
//< connectionStrings >
//  < add name = "classDbContext"               public class classDbContext : DbContext
//  connectionString = "Data Source = fishman\SQLEXPRESS;    сущ подключение
//  Initial Catalog = CodeFirst;                             Имя базы данных
//  Integrated Security = SSPI"                              По умолчанию
//  providerName="System.Data.SqlClient"/>                   По умолчанию
//	</connectionStrings>

// консоль чиспетчера пакетов
// Создаём таблицу с полями
// 1) PM> enable-migrations                                  Создаём миграцию
// 1.1) PM> enable-migrations-Force                          
// 2) PM> add-migration CreateClassAttrB                     Имя таблицы
// 3) PM> update-database                                    Обновляем базу данных
// 4) PM> Update-Database –Verbose                           Восстанавливаем данные из миграции
// 5) PM> Update-Database -TargetMigration:MyMigration-V1
// 6) Script-Migration
// Х) PM> Update-Database-TargetMigration:202401081142441_CreateClassAttrB
// 202401081134235_CreateClassAttrB

namespace EntityTest_19_12_2023
{
    public class ClassAttrB
    {
        public int id { get; set; }
        public string BlockHandle { get; set; } = "BlockHandle_f";
        public string BlockName { get; set; } = "BlockName_f";
        public string BlockAttrVal { get; set; } = "BlockAttrVal_f";
        public string BlockX { get; set; } = "BlockX_f"; 
        public string BlockY { get; set; } = "BlockY_f";
        public string BlockZ { get; set; } = "BlockZ_f";
        public string BlockLayer { get; set; } = "BlockLayer_f";
        public string BlockXor { get; set; } = "BlockXor_f";
        public ClassAttrB() { }
        public ClassAttrB( string blockHandle, string blockName, 
                           string blockAttrVal, string blockX, 
                           string blockY, 
                           string blockZ, string blockLayer,string Blockxor)
        {
            BlockHandle = blockHandle;
            BlockName = blockName;
            BlockAttrVal = blockAttrVal;
            BlockX = blockX;
            BlockY = blockY;
            BlockZ = blockZ;
            BlockLayer = blockLayer;
            BlockXor = Blockxor;
        }
    }
    public class classDbContext : DbContext
    {
        public DbSet<ClassAttrB> classAttrBs {get;set; }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("База создана");
            using (var ctx = new classDbContext())
            {
                var stud = new ClassAttrB("1","2","3","4","5","6","1959","");
                ctx.classAttrBs.Add(stud);
                ctx.SaveChanges();
            }
            Console.WriteLine("Запись добавлена");
            Console.ReadKey();
        }
    }
}
