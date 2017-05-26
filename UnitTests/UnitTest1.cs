using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hangman_release;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestChoosing_word1()
        {
            string[] arr = { "атом", "протон", "тороид", "диффузия", "телескоп", "излучение", "трепанация", "электричество", "препарирование", "синхрофазатрон",
                             "тяготение", "фотоэффект", "проводник", "магнитизм", "планета", "фотон", "соленоид", "синтез", "матрица", "рассчёты", "дифракция",
                             "дисперсия", "интерференция", "аннигиляция", "антиматерия", "нейротрансмиттер", "нейрон", "дизоксирибоза", "эволюция", "линза" };

            Class2 a = new Class2();
            string file = a.choosing_word(1);

            bool result = arr.Contains(file);
            bool must = true;

            Assert.AreEqual(must, result);
        }

        [TestMethod]
        public void TestChoosing_word2()
        {
            string[] arr = { "мат", "мяч", "риф", "шест", "футбол", "ракетка", "разминка", "упражнение", "велотренажер", "соревнование", "штанга", "прыжок", "забег",
                             "спринтер", "воланчик", "сетка", "бобслей", "кёрлинг", "баскетбол", "гантеля", "скакалка", "стадион", "батут", "биатлон", "пятиборье",
                             "поло", "гольф", "клюшка", "шайба", "чемпионат" };

            Class2 a = new Class2();
            string file = a.choosing_word(2);

            bool result = arr.Contains(file);
            bool must = true;

            Assert.AreEqual(must, result);
        }

        [TestMethod]
        public void TestChoosing_word3()
        {
            string[] arr = { "бюст", "соната", "барокко", "концерт", "орнамент", "выставка", "мольберт", "натюрморт", "композиция", "классицизм", "футуризм",
                             "сюрреализм", "модернизм", "кубизм", "портрет", "нота", "архитектура", "театр", "пьеса", "сюита", "балет", "опера", "марш", "танец",
                             "танго", "вальс", "хореография", "литература", "кинематограф" };

            Class2 a = new Class2();
            string file = a.choosing_word(3);

            bool result = arr.Contains(file);
            bool must = true;

            Assert.AreEqual(must, result);
        }

        [TestMethod]
        public void TestChoosing_word4()
        {
            string[] arr = { "альт", "туба", "ханг", "гобой", "лютня", "орган", "банджо", "челеста", "саксофон", "контрафагот", "камертон", "гитара", "труба",
                             "тромбон", "арфа", "контробасс", "волторна", "скрипка", "тарелки", "треугольник", "бубен", "пианино", "рояль", "кларнет", "аккордеон",
                             "баян", "виолончель", "маракасы", "барабан", "флейта" };

            Class2 a = new Class2();
            string file = a.choosing_word(4);

            bool result = arr.Contains(file);
            bool must = true;

            Assert.AreEqual(must, result);
        }

        [TestMethod]
        public void TestChoosing_word5()
        {
            string[] arr = { "як", "сыч", "белуга", "геккон", "нарвал", "лемминг", "неясыть", "овцебык", "опоссум", "сколопендра", "кот", "собака", "волк", "змея",
                             "заяц", "обезьяна", "нерпа", "касатка", "дельфин", "кашалот", "слон", "жираф", "лев", "тигр", "черепаха", "стриж", "аллигатор", "тритон",
                             "попугай", "страус" };

            Class2 a = new Class2();
            string file = a.choosing_word(5);

            bool result = arr.Contains(file);
            bool must = true;

            Assert.AreEqual(must, result);
        }

        [TestMethod]
        public void TestSetWord1()
        {
            string word = "бланк";

            Class1 a = new Class1();

            a.setWord(word);

            Assert.AreEqual(word, a.word1);
        }

        [TestMethod]
        public void TestSetWord2()
        {
            string word = "kreuzfeuer";

            Class1 a = new Class1();

            a.setWord(word);

            Assert.AreEqual(word, a.word1);
        }

        [TestMethod]
        public void TestGetWord2()
        {
            Class1 a = new Class1();
            string word = "dragon";
            a.setWord(word);

            string line = a.getWord('d');
            line = a.getWord('r');
            line = a.getWord('a');
            line = a.getWord('g');
            line = a.getWord('o');
            line = a.getWord('n');

            Assert.AreEqual(word, line);
        }
    }
}
