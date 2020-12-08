﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;

namespace ConsoleApp1
{
    public static class Class1
    {
        public static bool kek(this int lel)
        {
            if (lel > 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int Blow(this Class2 bj)
        {
            return bj.Fel + bj.Atio;
        }
    }

    public interface Ilek
    {
        string Se(int k);
    }
    public class Class2 : Ilek
    {
        public int Fel { get; set; }
        public int Atio { get; set; }

        public Class2()
        {

        }

        public int Job()
        {
            return Fel * Atio;
        }

        public string Se(int s)
        {
            return s.ToString();
        }

        public IDictionary<int, string> Key { get; set; }
        public Dictionary<int, string> Val { get; set; }

        public bool Ekmek(IDictionary<int, string> key, Dictionary<int, string> val)
        {
            return key == val;
        }
    }

    public enum ke
    {
        zal,
        fak,
        ef
    }

    public static class Extensive
    {
        public static bool? IsT<T>(this T obj)
        {
            if (obj == null)
            {
                Console.WriteLine("null");
                return null;
            }
            if (obj.GetType().Equals(typeof(int)))
            {
                return true;
            }
            return false;
        }

        public static string GenTry<T>(this T gen) where T : Generics
        {
            return gen.Fuse(gen.Name, gen.Id);
        }
    }

    public interface IId
    {
        public string Id { get; set; }
    }

    public interface IName
    {
        public string Name { get; set; }
    }

    public interface IIdAndName : IId, IName
    {
        string Fuse(string id, string name);
    }

    public class IdAndName : IIdAndName
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string Fuse(string id, string name)
        {
            return id + name;
        }
    }

    public class IdAndNameVar : IIdAndName
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string Fuse(string id, string name)
        {
            return $"{id} - {name}";
        }
    }

    public class InterfaceTest
    {
        private readonly IIdAndName _idAndName;
        public int Inter { get; set; }
        public int Face { get; set; }

        public InterfaceTest(int inter, int face, IIdAndName idAndName)
        {
            Inter = inter;
            Face = face;
            _idAndName = idAndName;
        }

        public string Add()
        {
            var result = Inter + Face;
            return _idAndName.Fuse(result.ToString(), "");
        }
    }

    public partial class Partial : IId
    {
        public int Count { get; set; }
        public string Id { get; set; }

        public Partial(int count)
        {
            Count = count;
        }
    }

    public enum dfahdj
    {
        fasdfaf = 1,
        afkdjd = 4,
        akfasdfdsf = -5
    }

    public enum afdfa
    {
        Kgadf = 0,
        adsfkhad = 3
    }

    public class Generics : IIdAndName
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public virtual string Fuse(string id, string name)
        {
            return $"{id} / {name}";
        }
    }

    public class GenChild : Generics
    {
        public override string Fuse(string id, string name)
        {
            return nameof(this.ToString);
        }
    }
    public class GenSecondChild : Generics
    {
        public override string Fuse(string id, string name)
        {
            return GetType().Name;
        }
    }
    public class GenThirdChild : Generics
    {
        public override string Fuse(string id, string name)
        {
            return $"{id} \\ {name}";
        }
    }
    public class GenFourthhild : Generics
    {
        public override string Fuse(string id, string name)
        {
            return $"{id}: {name}";
        }
    }


    public class Ageing
    {
        public int YearsLeft { get; set; }
        public string S { get; set; }

        public Ageing(int yearsLeft)
        {
            YearsLeft = yearsLeft;
        }

        public void PrintSentence()
        {
            S = YearsLeft == 1 ? null : "s";
            string message = $"You have {YearsLeft} year{S} to live.";
            Console.WriteLine(message);
        }
    }

    public class Ffbiased
    {
        public ke Keke { get; set; }
        public afdfa Afdfa { get; set; }

        public afdfa SetKe()
        {
            return Keke switch
            {
                ke.ef => afdfa.adsfkhad,
                ke.fak => afdfa.Kgadf,
                _ => afdfa.Kgadf,
            };
        }

        public Func<int, int, decimal> Fuu()
        {
            return (paragon, pentragon) => (decimal)paragon + pentragon;
        }

        public string Kfaf()
        {
            Func<int, string> Kal()
            {
                return (seg) => seg.ToString();
            }

            return Kal().Invoke((int)Keke > (int)Afdfa ? (int)Keke : (int)Afdfa);
        }

        public string KFKDf()
        {
            string Fel()
            {
                return GetHashCode().ToString();
            }

            return Fel() + GetType().Name;
            //return (int)Keke > (int)Afdfa ? ((int)Keke > 1 ? "kef" : "faf") : ((int)Afdfa < 2 ? "fadsf" : "famkldf");
        }

        public Func<int, int, int> GLGL()
        {
            try
            {
                return (d, e) => (e != 0) ? d / e : 0;
            }
            catch (DivideByZeroException)
            {
                return (d, e) => 0;
            }
        }

        public object Lele(int x, int y)
        {
            Func<int, int, int> rel = (int x, int y) => x + y;
            return rel.Invoke(x, y);
        }
    }

    public class On
    {
        public int Kgs(string d, int le)
        {
            switch (d)
            {
                case "fas":
                    return le;
                default:
                    throw new NotImplementedException();
            }
        }

        public int Kgag<T>(T da, Func<T, int> dis) where T : class
        {
            return dis(da);
        }

        public Func<List<string>, List<int>> FJ(List<string> gg)
        {
            var result = new List<int>();
            foreach (string txt in gg)
            {
                var inside = txt.Length;
                result.Add(inside);
            }

            return (d) => result;
        }
    }

    public class Fis
    {
        public int Fish { get; set; }
        public int Splash { get; set; }

        public Action<T> Fksk<T>(T input) where T : class
        {
            return (t) => Console.WriteLine(t.GetType().FullName);
        }

        public void KakaDudu(Action<int> dod, int dede)
        {
            dod(dede);
        }

        public int KKAf()
        {
            try
            {
                return Fish > Splash ? 1 : 0;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public Predicate<T> Leponga<T>(T input) where T : class
        {
            var o = input.GetType().Name.Length > 2;

            return o switch
            {
                true => (t) => true,
                false => (t) => false,

            };
        }
    }

    public class Delgado
    {
        public int Del { get; set; }
        public string Gado { get; set; }
       

        public Delgado(int del)
        {
            Delele fisfis = (del) => (del) => del.ToString();

            Del = del;
            Gado = fisfis(del)(Del);
        }

        public object Wow()
        {
            var es = SecurityAction.Assert;   
            Delele uwu = swag => swag => Enum.TryParse(swag.ToString(), out es).ToString();

            return uwu;
        }

        public bool Lol(dfahdj insert)
        {
            return insert switch
            {
                var x when x == dfahdj.afkdjd || x == dfahdj.akfasdfdsf //cover multiple cases
                => true,
                dfahdj.fasdfaf => false,
                _ => false
            };
        }

        public bool Addad(int x, int y)
        {
            return x > y | x == y;
        }

        public int Wax(int asdasd, int aad)
        {
            void ekkeke(string sads)
            {
                sads.ToLower();
            }

           var re =  asdasd + aad;
           ekkeke(re.ToString());

            return nameof(re).Count();
        }

        
    }

    public delegate Func<int, string> Delele(int del);
    public delegate object Dwight();


    public class IndominusRex
    {
        public const int Swat = 2;

        public int Def { get; set; }
        public int Dead { get; set; }
    }

    public enum BettingChoiceType
    {
        None = 0,
        Home = 1,
        Away = 2,
        Draw = 4,
        Yes = 8,
        No = 16,
        Under = 32,
        Over = 64,
        HomeOrDraw = Home | Draw,
        DrawOrAway = Draw | Away,
        HomeOrAway = Home | Away
    }

    public class SoccerMatchGoal
    {
        public short Minute { get; set; }
        public string Scorer { get; set; }
    }

    public static class ListExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach(T item in source)
            {
                action(item);
            }
        }

        public static void Guuus(this int le, Func<int,int,int> func)
        {
            func(le,le+1);
        }
    }
}

