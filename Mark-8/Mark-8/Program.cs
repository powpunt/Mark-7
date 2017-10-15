using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mark_8
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //find 'land'
                string[] array1 = Array.FindAll(Names,
                   element => element.EndsWith("land",
                   StringComparison.Ordinal));
                //find 'stan'
                string[] array2 = Array.FindAll(Names,
                   element => element.EndsWith("stan",
                   StringComparison.Ordinal));
                Console.WriteLine("Find 'land' : " + (string.Join(",", array1)));
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Find 'stan' : " + (string.Join(",", array2)));
                Console.ReadKey();
            }
        }
        public static string[] Names = new string[]
    {
   "Afghanistan ",
"Albania ",
"Algeria",
"Andorra",
"Argentina", 
"Armenia ",
"Australia" ,
"Austria ",
"Azerbaijan", 
"Bahamas ",
"Bahrain ",
"Bangladesh", 
"Barbados ",
"Belarus ",
"Belgium" ,
"Belize" ,
"Benin",
"Bermuda", 
"Bhutan",
 "Bolivia ",
"Bosnia and Herzegovia", 
"Botswana ",
"Brazil ",
"Brunei",
"Bulgaria ",
"Burkina Faso", 
"Burundi ",
        
"Cambodia ",
"Cameroon" ,
"Canada ",
"Cape Verde ",
"Central African Republic", 
"Chad ",
"Chile ",
"China ",
"Colombia ",
"Comoros" ,
"Congo",
"Costa Rica", 
"Croatia", 
"Cuba ",
"Cyprus ",
"Czech ",

"Denmark ",
"Djibouti ",
"Dominica",
"Domincan Republic",

"Egypt ",
"El Salvador ",
"Equatorial Guinea",
"Eritrea ",
"Estonia",
"Ethiopia", 

"Fiji ",
"Finland",
"France ",
"Gabon ",
"Georgia ",
"Germany", 
"Ghana ",
"Greece ",
"Grenada ",
"Guinea ",
"Guinea Bissau ",
"Guyana", 

"Haiti",
"Honduras ",

"Iceland ",
"India ",
"Indonesia", 
"Iran ",
"Iraq",
"Ireland ",
"Israel ",
"Italy ",

"Jamaica ",
"Japan ",
"Jordan ",
"Kazakhstan ", 
"Kenya ",
"Kiribati ",
"Korea, North ",
"Korea. South ",
"Kuwait ",
"Kyrgyzstan ",

"Laos ",
"Latvia ",
"Lebanon ",
"Lesotho ",
"Liberia ",
"Libya",
"Liechtenstein ",
"Lithuania",
"Luxembourg ",

"Macedonia",
"Madagascar ",
"Malawi ",
"Malaysia ",
"Maldives" ,
"Mali ",
"Malta ",
"Mauritius", 
"Mexico ",
"Micronesia", 
"Moldova ",
"Monaco ",
"Mongolia",
"Morocco ",
"Mozambique", 
"Myanmar ",

"Namibia" ,
"Nauru ",
"Nepal ",
"Netherlands", 
"New Zealand",
"Nicaragua", 
"Niger ",
"Nigeria",
"Norway", 

"Oman ",

"Pakistan" ,
        "Panama ",
"Papua New Guinea", 
"Paraguay" ,
"Peru",
"Philippines", 
"Portugal",

"Qatar ",

"Romania ",
"Russia ",
"Rwanda",

"Samoa ",
"San Marino ",
"Saudi Arabia" ,
"Senegal",
"Seychelles",
"Sierra Leone", 
"Singapore",
"Slovakia ",
"Slovenia ",
"Somalia ",
"South Africa ",
"Spain ",
"Sri Lanka", 
"Sudan ",
"Suriname ",
"Swaziland", 
"Sweden ",
"Switzerland", 
"Syria ",

"Taiwan" ,
"Tajikistan",
"Tanzania ",
"Thailand" ,
"Togo",
"Tonga ",
"Trinidad and Tobago", 
"Tunisia ",
"Turkey ",
"Turkmenistan",

"Uganda",
"Ukraine",
"United Arab Emirates", 
"United Kingdom ",
"United States of America ",
"Uzbekistan" ,

"Vanuatu ",
"Venezuela", 
"Vietnam ",

"Yemen" ,

"Zambia",
"Zimbabwe", 
     };

    }

}

