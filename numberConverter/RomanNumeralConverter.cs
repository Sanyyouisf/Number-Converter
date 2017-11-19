using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberConverter
{
    public class RomanNumeralConverter
    {
        public string Convert(int numberToConvert)
        {
            //            //------------------------<4-------------------
            //            if (numberToConvert < 4)
            //            {
            //                var DisplayedResult = "";
            //                for (var i = 0; i < numberToConvert; i++)
            //                {
            //                    DisplayedResult += "I";
            //                }
            //                return DisplayedResult;
            //            }
            //            //-------------------4------------------------
            //            else if (numberToConvert == 4)
            //            {
            //                var DisplayedResult = "IV";
            //                return DisplayedResult;
            //            }
            //            //----------------- 5 to 8-------------------
            //            else if (numberToConvert >= 5 && numberToConvert == 8)
            //            {
            //                var DisplayedResult = "V";
            //                for (var i = 6; i < numberToConvert; i++)
            //                {
            //                    DisplayedResult += "I";
            //                }
            //                return DisplayedResult;
            //            }
            //            //-------------------9--------------------------------
            //            else if (numberToConvert == 9)
            //            {
            //                var DisplayedResult = "IX";
            //                return DisplayedResult;
            //            }
            ////-----------------10 to 13---------------------------
            //            //else if (numberToConvert >= 10 && numberToConvert == 13)
            //            //{
            //            //    var DisplayedResult = "X";

            //            //    for (var i = 10; i < numberToConvert; i++)
            //            //    {
            //            //        DisplayedResult += "I";
            //            //    }
            //            //    return DisplayedResult;
            //            //}
            //------------------------------------------
            if (numberToConvert >= 0)
            {
                var Remainder = 0;
                var RemainderValue = "";
                var pairKeyValue = "";
                var DisplayedResult = "";
                Dictionary<int, string> myDictionary = new Dictionary<int, string>()
                {
                     {1000,"M"},{ 900 , "CM"},{800 ,"DCCC" },{700 ,"DCC" },{600 ,"DC" },{ 500,"D"},{100,"C"},
                    { 90,"XC" },{ 80 ,"LXXX"},{ 70,"LXX"},{ 60 ,"LX"},{ 50,"L"},{ 40,"XL"},{ 30,"XXX"},{ 20,"XX"},{ 10,"X"},
                    { 9,"IX"},{ 8,"VIII"},{ 7,"VII"},{ 6,"VI"},{ 5,"V"},{ 4,"IV"},{ 3,"III"},{ 2,"II"},{ 1 ,"I"},{0 ,""}
                };
                //var Remainder = 0;
                foreach (KeyValuePair< int,string> pair in myDictionary )
                {
                    if (numberToConvert >= pair.Key)
                    {
                        int Reminder = numberToConvert - pair.Key;
                        pairKeyValue = myDictionary[pair.Key];
                        while (myDictionary.ContainsKey(Reminder) != true)
                        {
                            var NewNumberToConver = Reminder;
                            foreach (KeyValuePair<int, string> pair2 in myDictionary)
                            {
                                if (NewNumberToConver >= pair2.Key)
                                {
                                    var NewReminder = NewNumberToConver - pair2.Key;
                                    pairKeyValue += myDictionary[pair2.Key];
                                    Reminder = NewReminder;
                                    //string NewPairKeyValue = myDictionary[pair2.Key] + " ";
                                    break;
                                }
                                //break;
                            }
                        };

                        //if (myDictionary.ContainsKey(Reminder) != true)
                        //{
                        //    Reminder = numberToConvert - pair.Key;
                        //}
                        // string ReminderValue = myDictionary[Reminder];
                        pairKeyValue += myDictionary[Reminder];
                        DisplayedResult = pairKeyValue;

                       // DisplayedResult = pairKeyValue + ReminderValue;
                        //break;
                    }
                }
                return DisplayedResult;
            }
            return "";
        }
    }
}
