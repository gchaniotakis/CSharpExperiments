using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var sw = new System.Diagnostics.Stopwatch(); //experiment with stopwatch
            //sw.Start();

            //string GetEnumName<T>(int x) where T : Enum //get Enum member name from int
            //{
            //    try
            //    {
            //        var name = Enum.GetName(typeof(T), x);
            //        if (string.IsNullOrEmpty(name))
            //        {
            //            return $"No enum member with index {x}.";
            //        }
            //        return name;
            //    }
            //    catch (Exception e)
            //    {
            //        return e.Message;
            //    }
            //}
            //Console.WriteLine(GetEnumName<dfahdj>(1));
            //Console.WriteLine(GetEnumName<afdfa>(2));

            //int? GetEnumValue<T>(string name) where T : Enum // get enum member int value from int
            //{
            //    try
            //    {
            //        var index = (int)Enum.Parse(typeof(T), name);
            //        return index;
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //        return null;
            //    }
            //}
            //var fdf = new List<int> { -1, 0, 5, -546, 1 };
            //foreach (int kek in fdf)
            //{
            //    if (fdf.Any(x => x < 0))
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(kek);
            //}

            //var age = new Ageing(1); //experimenting with increment values + printing techinques
            //age.PrintSentence();
            //age.YearsLeft++;
            //age.PrintSentence();
            //Console.WriteLine(GetEnumValue<dfahdj>("afkdjd"));

            //void IdPrint(IIdAndName input) // experiment with interface as input in method
            //{
            //    if (input.Id == null || input.Name == null)
            //    {
            //        return;
            //    }

            //    var print = input.Fuse(input.Id, input.Name);
            //    Console.WriteLine(print);
            //}

            //IdPrint(new Generics { Id = null, Name = "fasdg" });

            //var fasdkf = new List<List<int>>(); //experiment with continue keyword in loop
            //fasdkf.Add(new List<int> { 0, 465406, 5646 });
            //fasdkf.Add(new List<int> { 504, 4500, 45 });
            //fasdkf.Add(new List<int> { 4, 50, 321 });
            //foreach (var fe in fasdkf)
            //{
            //    if (fe.Any(x => x == 0))
            //    {
            //        continue;
            //    }
            //}

            //var fb = new Ffbiased(); // experiment with func
            //Console.WriteLine(fb.GLGL().Invoke(3, 0));

            //var duplicates = new List<Generics> { new Generics { Id = "deez", Name = "nuts" }, new Generics { Id = "deez", Name = "ballz" }, new Generics { Id = "se", Name = "lele" } };

            //bool CheckListForDuplicates(List<Generics> lelel) // experiment checking for duplicates
            //{
            //    var co = lelel.GroupBy(g => g.Id);
            //    var sk = co.Distinct().Count();
            //    return sk != lelel.GroupBy(g => g.Id).Count() ? true : false;
            //}

            //var sde = new Dictionary<string, int>();
            //foreach (var ADFAD in duplicates) //experiment with contains key and get distinct values
            //{
            //    if (sde.ContainsKey(ADFAD.Id)) { continue; }
            //    sde.Add(ADFAD.Id, duplicates.Count(id => id.Id == ADFAD.Id));
            //}
            //foreach (var fd in sde)
            //{
            //    Console.WriteLine(fd);
            //}
            //var ks = sde;
            //ks.Add("faag", 12);

            //var adf = new On();
            //Func<Class2, int> sdfkd = (fun) => fun.Ato + fun.Gel; //assign func to local variable
            ////Func<Class2, int> SF() //experiment with class input in func
            ////{
            ////    return (fun) => fun.Atio + fun.Fel;
            ////}
            //var skdaa = adf.Kgag(new Class2 { Gel = 21, Ato = 54 }, sdfkd); //experiment with generics and func as input
            //Console.WriteLine(skdaa);

            //var kksk = new List<Fis> { new Fis { Fish = 2, Splash = 3 }, new Fis { Splash = 4, Fish = 5 }, new Fis { Fish = 12, Splash = 3 } }; 
            //var fkff = kksk.Where(x => x.Fish <= 2 && 2 <= x.Splash); //experimenting with linq "where" method, attempting to find range within object properties
            //sw.Stop();
            //Console.WriteLine(sw.ElapsedMilliseconds);

            //var skksfkf = new List<string> { "00a5d0dd-820a-4a6f-b45b-96cf6468b3ea", "012c8944-49f8-40a5-8c5d-270743beb218", "014c8c32-56c4-4684-bb8a-db84fed344c0" };
            //var format = "'" + string.Join("','", skksfkf) + "'";
            //Console.WriteLine(format); //experimenting with string fomatting and joining 

            //var ke = new Fis { Fish = 3, Splash = 2 };
            //var lalistatos = ke.Leponga(ke); //experimenting with predicate and action  assingnment and invocations
            //Console.WriteLine(lalistatos.Invoke(ke));
            //Console.WriteLine(ke.Fksk(ke));
            //string lelelele = "Collection modified exception";

            //Func<int, int> deedee = kel => kel + 1; //attempting one param func witout parenthesis in lambda expression
            //Dwight lahtar = () => new List<object> { new Fis { Fish = 2, Splash = 46 } }; // experimenting with delegates 

            //var kkgzfg = lahtar() as IEnumerable<object>;
            //var dw = kkgzfg.FirstOrDefault(s => s.GetType() == typeof(Fis));
            //foreach (var prop in dw.GetType().GetProperties())
            //{
            //    Console.WriteLine($"{prop.Name}: {prop.GetValue(dw)}"); //attempting to extract properties from generic object
            //}

            //Func<string, int> quasi = modo => modo.Split('/').Length;
            //Console.WriteLine(quasi("quaresma"));

            //Console.WriteLine(deedee(12));
            //Console.WriteLine(lelelele.Contains("Collection")); //experimenting with string methods
            //Console.WriteLine(lelelele.StartsWith("Collection"));

            //var del = new Delgado(2);

            //var isn = del.Addad(2, 1); //experimenting with  single | OR boolean expression
            //Console.WriteLine(isn);

            //Action<string> fadf = _ =>
            //{
            //    switch (_.Length)
            //    {
            //        case 3:
            //            _.ToLower();
            //            break;
            //    }
            //};

            //var dafafd = "SSS"; //experimenting on action with a full body using curly brackets
            //fadf(dafafd);
            //Console.WriteLine(dafafd);

            //Func<int, string> delaware = deck => //experimenting on func with a full body using curly brackets
            //{
            //    switch (deck)
            //    {
            //        case 12:
            //            return deck.GetHashCode().ToString();
            //        default:
            //            return deck.ToString();
            //    }
            //};

            //var Ir = new IndominusRex();

            //Func<int, int> dedicate = de => //experimenting with assigning new value to local func variable
            //{
            //    return de + 12;
            //};
            //Console.WriteLine($"dedicate: {dedicate(2)}");

            //dedicate = dot =>
            //{
            //    var hash = dot.GetHashCode();
            //    return dot + 2;
            //};
            //Console.WriteLine($"dedicate: {dedicate(2)}");

            //var tik = "Manchester United"; //experimenting with string comparisons
            //var swaf = tik.CompareTo("Man Utd");
            //var cif = tik.CompareTo("Manchester Utd");
            //var skaf = tik.CompareTo("Man. Utd");
            //var skaDf = tik.CompareTo("Man. United");
            //var skafs = tik.CompareTo("Nottingham");

            //var statName = StatsFromJson.GetStatName(1003); //experimenting with reading from json file and printing certain property
            //Console.WriteLine(statName);

            //void CheckGoalsMinutesAndFixIfNeeded(List<SoccerMatchGoal> homeGoalsDetails, List<SoccerMatchGoal> awayGoalsDetails) //experimenting in comparing two lists and fixing results 
            //{
            //    var random = new Random();
            //    foreach (var homeGoal in homeGoalsDetails)
            //    {
            //        if (awayGoalsDetails.Any(ag => ag.Minute == homeGoal.Minute))
            //        {
            //            var index = homeGoalsDetails.IndexOf(homeGoal);
            //            var previous = index != 0 ? homeGoalsDetails[index - 1] : new SoccerMatchGoal { Minute = 0 } ;
            //            homeGoal.Minute = Convert.ToInt16(random.Next(previous == null ? previous.Minute + 1 : 0, 45));
            //        }
            //    }
            //}

            //var homeGoals = new List<SoccerMatchGoal>
            //{
            //    new SoccerMatchGoal
            //    {
            //        Minute = 22
            //    },
            //    new SoccerMatchGoal
            //    {
            //        Minute = 36
            //    }
            //};

            //var awayGoals = new List<SoccerMatchGoal>
            //{
            //    new SoccerMatchGoal
            //    {
            //        Minute = 22
            //    },
            //    new SoccerMatchGoal
            //    {
            //        Minute = 56
            //    }
            //};
            //CheckGoalsMinutesAndFixIfNeeded(homeGoals, awayGoals);
            //Func<int, string> wakawaka = x => //experiment with try catch block and reverse bool check on a func
            //{
            //    try
            //    {
            //        if(2 == x)
            //        {
            //            return x.ToString();
            //        }
            //        return (x + 10).ToString();
            //    }
            //    catch(Exception)
            //    {
            //        throw;
            //    }
            //};

            //var dict = new Dictionary<string, int?>();
            //var found = dict.Keys.FirstOrDefault(k => k == "chan") != null  ? dict["chan"] : null; //experimenting with finding a key in dictionary using linq

            //var lelist = new List<int> { 1, 4, 2, 4 }; //valueable lesson here, don't try to iterate and edit enumerable at the same time, use a copy!!
            //foreach (var le in lelist.ToList())
            //{
            //    if (le == 2)
            //    {
            //        lelist.Remove(le);
            //    }
            //}

            //var kadfsfsafa = lelist.Where(f => f == 3);
            //Console.WriteLine(wakawaka(2));


            //var dateTimeOffset1 = new DateTimeOffset(2013, 8, 31, 15, 30, 0, new TimeSpan(0, 0, 0)); //comparing datetimeoffset without the Compare method
            //var dateTimeOffset2 = new DateTimeOffset(2014, 8, 31, 15, 30, 0, new TimeSpan(0, 0, 0));
            //Console.WriteLine(dateTimeOffset1 > dateTimeOffset2);

            //var ssle = 1;
            //ssle.Guuus((x,y) => x.GetHashCode() + y.GetHashCode()); //experimenting with lambdas as method input like linq
            //Console.WriteLine(ssle);

            //var lolist = new List<int> { 1, 4, 2, 4 }; //experimenting with Sequence Equal method
            //var varo = lelist.SequenceEqual(lolist);
            //Console.WriteLine(varo);

            //var handleEvent = new Events(); //experimenting with event handling
            //handleEvent.ProcessCompleted += EventImplement;
            //handleEvent.StartProcessing(skksfkf);


            //static int EventImplement(string input)
            //{
            //    return input.Length;
            //}

            //lolist.ForEach(x => //experimenting with using lambda statement in linq
            //{
            //    if (x != 12)
            //    {
            //        return;
            //    }
            //    else
            //    {
            //        x++;
            //    }
            //});
            //string ResolveStatName(string propName)
            //{
            //    const string Home = "Home";
            //    const string Away = "AWay";
            //    const string FirstHalf = "FirstHalf";
            //    const string SecondHalf = "SecondHalf";

            //    var homePredicate = propName.Contains(Home);
            //    var awayPredicate = propName.Contains(Away);
            //    var firstHalfPredicate = propName.Contains(FirstHalf);
            //    var secondHalfPredicate = propName.Contains(SecondHalf);

            //    if (homePredicate && firstHalfPredicate)
            //    {
            //        var onceRemoved = propName.Remove(propName.IndexOf(Home), Home.Length);
            //        return onceRemoved.Remove(propName.IndexOf(FirstHalf), FirstHalf.Length);
            //    }
            //    if (awayPredicate && firstHalfPredicate)
            //    {
            //        var onceRemoved = propName.Remove(propName.IndexOf(Away), Away.Length);
            //        return onceRemoved.Remove(propName.IndexOf(FirstHalf), FirstHalf.Length);
            //    }
            //    if (homePredicate && secondHalfPredicate)
            //    {
            //        var onceRemoved = propName.Remove(propName.IndexOf(Home), Home.Length);
            //        return onceRemoved.Remove(propName.IndexOf(SecondHalf), SecondHalf.Length);
            //    }
            //    if (awayPredicate && secondHalfPredicate)
            //    {
            //        var onceRemoved = propName.Remove(propName.IndexOf(Away), Away.Length);
            //        return onceRemoved.Remove(propName.IndexOf(SecondHalf), SecondHalf.Length);
            //    }
            //    if (homePredicate)
            //    {
            //        return propName.Remove(propName.IndexOf(Home), Home.Length);
            //    }
            //    if (awayPredicate)
            //    {
            //        return propName.Remove(propName.IndexOf(Away), Away.Length);
            //    }

            //    return null;
            //}

            //var stat = ResolveStatName("FirstHalfHomeGoals");


            //var betList = new List<ModelBets>
            //{
            //    new ModelBets
            //    {
            //        Line = "0.2",
            //        Name = "asfaf",
            //        Id = 2445
            //    },
            //    new ModelBets
            //    {
            //        Line = "1.2",
            //        Name = "asfaf",
            //        Id = 2445
            //    },
            //    new ModelBets
            //    {
            //        Line = "0.4",
            //        Name = "asfaf",
            //        Id = 2445
            //    },
            //    new ModelBets
            //    {
            //        Line = "0.2",
            //        Name = "asfaf",
            //        Id = 2445
            //    },
            //};

            //var lines = betList.GroupBy(x => x.Line).Select(x => x.Key).ToList();

            //var kdafdfas = SearchOperator.Equal;
            //var sfaadfadaf = kdafdfas.GetEnumDictionary();
            var line = "-0.75 (0-0)";
            var subline = line.Remove(line.IndexOf('(') - 1, 6);
            var decline = decimal.Parse(subline.Replace('.', ','));

            var bc = DateTime.MinValue;
            var ad = DateTime.MaxValue;
            var bcOffset = DateTimeOffset.MinValue;
            var adOffset = DateTimeOffset.MaxValue;

            Console.Read();

        }
    }
}
