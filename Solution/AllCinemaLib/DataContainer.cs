using CinemaLib;
using System.Reflection;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace AllCinemaLib
{
    public class DataContainer
    {
        public List<CinemaModel> data = new List<CinemaModel>();
        static DataContainer self = null;
        DataContainer() { }
        public static DataContainer Create()
        {
            if (self == null)
            {
                self = new DataContainer();
                LoadJson();
            }
            
            return self;
        }

        public void Save()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            };

            string json = JsonSerializer.Serialize(self.data, options);
            File.WriteAllText("JsonDB.json", json);
        }

        private static void LoadJson()
        {
            string json = File.ReadAllText("JsonDB.json");
            self.data = JsonSerializer.Deserialize<List<CinemaModel>>(json);
        }
    }
}


//// из конструктора
//self = new DataContainer
//{
////    data = { new CinemaModel() { Name="Крестный отец",
////                                 Director = new List<string>() { "Фрэнсис Форд Коппола" },
////                                 Style = new List<string>() {"Драма", "Криминал"},
////                                 Info="Криминальная сага, повествующая о нью-йоркской сицилийской мафиозной семье Корлеоне. Фильм охватывает период 1945-1955 годов." ,
////                                 Seances = new List<string>() { "12:00","14:00","16:00"}
////                               },
////             new CinemaModel() { Name="Лицо со шрамом",
////                                 Director = new List < string >() { "Брайан Де Пальма" },
////                                 Style = new List<string>() {"Драма", "Криминал"},
////                                 Info="Весной 1980 года был открыт порт Мэйриэл Харбор, и тысячи кубинских беженцев ринулись в Соединенные Штаты на поиски Американской Мечты. Один из них нашел ее на залитых солнцем улицах Майами. Богатство, власть и страсть превзошли даже самые невероятные его мечты. Его звали Тони Монтана. Мир запомнил его под другим именем - «Лицо со шрамом»",
////                                 Seances = new List<string>() { "08:00","13:30"}
////                               },
////             new CinemaModel() { Name="Гарри Поттер и философский камень",
////                                 Director = new List<string>() { "Крис Коламбус" },
////                                 Style = new List <string>() { "Семейные", "Фэнтези", "Приключения" },
////                                 Info="Фильм \"Гарри Поттер и философский камень\" это начало удивительных похождений юного волшебника. Сюжет завязан на десятилетнем мальчишке Гарри Поттере, который в детстве потерял своих родителей, и вынужден был жить с дядей и тетей – не самыми добрыми людьми. Однако на одиннадцатилетие Гарри, все меняется, поскольку на пороге дома появляется таинственный гость, с письмом в руках, содержимое которого гласит, что мальчик является волшебником, и принят на обучение в магическую школу Хогвартс.",
////                                 Seances = new List <string>() { "11:00", "15:50" }
////                               },

////}
//};   