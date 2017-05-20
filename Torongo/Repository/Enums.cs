using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Torongo.Repository
{
    enum WeatherStatus : int
    {
        Foggy = 1,
        Rainy = 2,
        Sunny,
        Clear
    };

    enum District : int
    {
        /*BarisalDivision = 1,
        Barguna = 10,
        Barisal = 11,
        Bhola = 12,
        Jhalokati = 13,
        Patuakhali = 14,
        Pirojpur = 15,

        ChittagongDivision = 2,
        Bandarban = 20,
        Brahmanbaria = 21,
        Chandpur = 22,*/
        Chittagong = 23,
        /*Comilla = 24,
        CoxsBazar=25,
        Feni = 26,
        Khagrachhari = 27,
        Lakshmipur = 28,
        Noakhali = 29,
        Rangamati = 30,

        DhakaDivision = 4,*/
        Dhaka = 40,
        /*Faridpur = 41,
        Gazipur = 42,
        Gopalganj = 43,
        Jamalpur = 44,
        Kishoregonj = 45,
        Madaripur = 46,
        Manikganj = 47,
        Munshiganj = 48,
        Mymensingh = 49,
        Narayanganj = 51,
        Narsingdi = 52,
        Netrakona = 53,
        Rajbari = 54,
        Shariatpur = 55,
        Sherpur = 56,
        Tangail = 57,

        KhulnaDivision = 6,
        Bagerhat = 60,
        Chuadanga = 61,*/
        Jessore = 62,
        /*Jhenaidah = 63,
        Khulna = 64,
        Kushtia = 65,
        Magura = 66,
        Meherpur = 67,
        Narail = 68,
        Satkhira = 69,

        RajshahiDivision = 7,
        Bogra = 70,
        Chapainababganj = 71,
        Joypurhat = 72,
        Pabna = 73,
        Naogaon = 74,
        Natore = 75,
        Rajshahi = 76,
        Sirajganj = 77,

        RangpurDivision = 8,
        Dinajpur = 80,
        Gaibandha = 81,
        Kurigram = 82,
        Lalmonirhat = 83,
        Nilphamari = 84,
        Panchagarh = 85,
        Rangpur = 86,
        Thakurgaon = 87,

        SylhetDivision = 9,
        Habiganj = 90,
        Maulvibazar = 91,
        Sunamganj = 92,
        Sylhet = 93*/
    }
}