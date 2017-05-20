using System.Collections.Generic;
using System.Linq;
using Torongo.Model;
using static System.StringComparison;

namespace Torongo.Repository
{
    public class FrequencyRepository
    {
        public List<long> GetAllFrequency()
        {
            var frequencies = new List<long>();

            foreach (var freq in _frequencyGroups)
            {
                frequencies.AddRange(freq.Frequencies);
            }

            return frequencies.Distinct().ToList();
        }

        public List<long> GetFrequencyByCriterya(FrequencyGroup criterya)
        {
            IEnumerable<FrequencyGroup> frequencyGroups = _frequencyGroups;

            if (!string.IsNullOrEmpty(criterya.To))
            {
                frequencyGroups = frequencyGroups.Where(x => string.Equals(x.To, criterya.To, OrdinalIgnoreCase));
                //frequencyGroups = frequencyGroups.Where(x => int.Parse(x.To) >= int.Parse(criterya.To));
            }

            if (!string.IsNullOrEmpty(criterya.From))
            {
                frequencyGroups = frequencyGroups.Where(x => string.Equals(x.From, criterya.From, OrdinalIgnoreCase));
                //frequencyGroups = frequencyGroups.Where(x => int.Parse(x.From) <= int.Parse(criterya.From));
            }

            if (!string.IsNullOrEmpty(criterya.Weather))
            {
                frequencyGroups = frequencyGroups.Where(x => string.Equals(x.Weather, criterya.Weather, OrdinalIgnoreCase));
            }

            if (!string.IsNullOrEmpty(criterya.Location))
            {
                frequencyGroups = frequencyGroups.Where(x => string.Equals(x.Location, criterya.Location, OrdinalIgnoreCase));
            }

            var frequencies = new List<long>();

            foreach (var freq in frequencyGroups)
            {
                frequencies.AddRange(freq.Frequencies);
            }

            return frequencies.Count > 0 ? frequencies.Distinct().ToList() : new List<long>();
        }

        private static IEnumerable<FrequencyGroup> _frequencyGroups = new List<FrequencyGroup>()
        {
            new FrequencyGroup()
            {
                To = "0600",
                From = "0700",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Dhaka.ToString(),
                Frequencies = new List<long>() { 4422, 4450, 4510, 4650, 4550, 5510, 5650, 5757, 4552, 4425 }
            },
            new FrequencyGroup()
            {
                To = "0600",
                From = "0700",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Chittagong.ToString(),
                Frequencies = new List<long>() { 4510, 4450, 4422, 4650, 4550, 5512, 5651, 5757, 4552, 4425 }
            },
            new FrequencyGroup()
            {
                To = "0600",
                From = "0700",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Jessore.ToString(),
                Frequencies = new List<long>() { 4450, 4510, 4650, 4550, 5512, 5650, 5657, 4552, 4425, 5757 }
            },
            new FrequencyGroup()
            {
                To = "0700",
                From = "0800",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Dhaka.ToString(),
                Frequencies = new List<long>() { 5750, 5515, 5540, 5545, 5550, 5470, 5225, 5115, 5775, 5530 }
            },
            new FrequencyGroup()
            {
                To = "0700",
                From = "0800",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Chittagong.ToString(),
                Frequencies = new List<long>() { 5530, 5775, 5115, 2525, 5470, 5550, 5545, 5540, 5515, 5750 }
            },
            new FrequencyGroup()
            {
                To = "0700",
                From = "0800",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Jessore.ToString(),
                Frequencies = new List<long>() { 5550, 5545, 5540, 5515, 5750, 5470, 5225, 5115, 5775, 5530 }
            },
            new FrequencyGroup()
            {
                To = "0800",
                From = "0900",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Dhaka.ToString(),
                Frequencies = new List<long>() { 5770, 5772, 5535, 5780, 5555, 6225, 6115, 6035, 6110, 6555 }
            },
            new FrequencyGroup()
            {
                To = "0800",
                From = "0900",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Chittagong.ToString(),
                Frequencies = new List<long>() { 5780, 5535, 5772, 5770, 5555, 6225, 6115, 6035, 6110, 6555 }
            },
            new FrequencyGroup()
            {
                To = "0800",
                From = "0900",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Jessore.ToString(),
                Frequencies = new List<long>() { 5772, 5770, 5535, 5780, 5555, 6225, 6115, 5035, 6110, 6555 }
            },
            new FrequencyGroup()
            {
                To = "0900",
                From = "1000",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Dhaka.ToString(),
                Frequencies = new List<long>() { 5650, 5751, 5750, 7115, 7515, 7525, 6719, 6525, 5755, 5755 }
            },
            new FrequencyGroup()
            {
                To = "0900",
                From = "1000",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Chittagong.ToString(),
                Frequencies = new List<long>() { 5650, 5751, 5750, 7115, 7515, 7525, 5719, 6525, 5755, 5756 }
            },
            new FrequencyGroup()
            {
                To = "0900",
                From = "1000",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Jessore.ToString(),
                Frequencies = new List<long>() { 7525, 7515, 7115, 5750, 5751, 5650, 6719, 6525, 5755, 5756 }
            },
            new FrequencyGroup()
            {
                To = "1000",
                From = "1100",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Dhaka.ToString(),
                Frequencies = new List<long>() { 6655, 6588, 6587, 6671, 5660, 11350, 10350, 10330, 11405, 10332 }
            },
            new FrequencyGroup()
            {
                To = "1000",
                From = "1100",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Chittagong.ToString(),
                Frequencies = new List<long>() { 6655, 6588, 6587, 6671, 5660, 11350, 10350, 10330, 11405, 10332 }
            },
            new FrequencyGroup()
            {
                To = "1000",
                From = "1100",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Jessore.ToString(),
                Frequencies = new List<long>() { 10320, 10332, 11405, 10330, 10350, 11350, 5660, 6671, 6587, 6588, 6655 }
            },
            new FrequencyGroup()
            {
                To = "1100",
                From = "1200",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Dhaka.ToString(),
                Frequencies = new List<long>() { 10320, 10351, 11360, 11316, 10365, 10372, 7857, 5751, 5525, 5758 }
            },
            new FrequencyGroup()
            {
                To = "1100",
                From = "1200",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Chittagong.ToString(),
                Frequencies = new List<long>() { 10320, 10351, 11360, 11316, 10365, 10372, 7857, 5751, 5525, 5758 }
            },
            new FrequencyGroup()
            {
                To = "1100",
                From = "1200",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Jessore.ToString(),
                Frequencies = new List<long>() { 5758, 5525, 10320, 10351, 11360, 11316, 10365, 10372, 7857, 5751 }
            },
            new FrequencyGroup()
            {
                To = "1200",
                From = "1300",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Dhaka.ToString(),
                Frequencies = new List<long>() { 6652, 6735, 6740, 6745, 7657, 11410, 7515, 7695, 10450, 7865 }
            },
            new FrequencyGroup()
            {
                To = "1200",
                From = "1300",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Chittagong.ToString(),
                Frequencies = new List<long>() { 11410, 10450, 7695, 7515, 7657, 6745, 6740, 6755, 6652, 7865 }
            },
            new FrequencyGroup()
            {
                To = "1200",
                From = "1300",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Jessore.ToString(),
                Frequencies = new List<long>() { 7857, 7865, 5757, 11410, 10450, 6537, 7515, 11316, 10372, 7855 }
            },
            new FrequencyGroup()
            {
                To = "1300",
                From = "1400",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Dhaka.ToString(),
                Frequencies = new List<long>() { 7875, 7930, 5752, 5857, 6516, 7657, 5540, 5530, 10405, 11355 }
            },
            new FrequencyGroup()
            {
                To = "1300",
                From = "1400",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Chittagong.ToString(),
                Frequencies = new List<long>() { 11405, 11355, 5530, 5540, 7657, 6516, 5857, 5752, 7930, 7875 }
            },
            new FrequencyGroup()
            {
                To = "1300",
                From = "1400",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Jessore.ToString(),
                Frequencies = new List<long>() { 7875, 7930, 5752, 5857, 6516, 7657, 5540, 5530, 11405, 11355 }
            },
            new FrequencyGroup()
            {
                To = "1400",
                From = "1500",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Dhaka.ToString(),
                Frequencies = new List<long>() { 5535, 5747, 5658, 6135, 6388, 5542, 6038, 5757, 5357, 6512, 7512 }
            },
            new FrequencyGroup()
            {
                To = "1400",
                From = "1500",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Chittagong.ToString(),
                Frequencies = new List<long>() { 5535, 5758, 5747, 5568, 5658, 6135, 5757, 6038, 6512, 7512 }
            },
            new FrequencyGroup()
            {
                To = "1400",
                From = "1500",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Jessore.ToString(),
                Frequencies = new List<long>() { 5712, 5535, 5758, 5747, 5568, 5658, 6135, 5757, 6038, 7512 }
            },
            new FrequencyGroup()
            {
                To = "1500",
                From = "1600",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Dhaka.ToString(),
                Frequencies = new List<long>() { 5550, 5505, 5536, 5705, 5859, 6637, 6505, 5995, 6612, 6535 }
            },
            new FrequencyGroup()
            {
                To = "1500",
                From = "1600",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Chittagong.ToString(),
                Frequencies = new List<long>() { 5558, 5505, 5536, 5705, 5859, 6637, 6505, 5995, 6612, 6535 }
            },
            new FrequencyGroup()
            {
                To = "1500",
                From = "1600",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Jessore.ToString(),
                Frequencies = new List<long>() { 5558, 5505, 5536, 5705, 5859, 6637, 6505, 5995, 6612, 6535 }
            },
            new FrequencyGroup()
            {
                To = "1600",
                From = "1700",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Dhaka.ToString(),
                Frequencies = new List<long>() { 5549, 5485, 5395, 5339, 5240, 6631, 4775, 4735, 5525, 5780 }
            },
            new FrequencyGroup()
            {
                To = "1600",
                From = "1700",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Chittagong.ToString(),
                Frequencies = new List<long>() { 5549, 5485, 5395, 5339, 5240, 6631, 4775, 4735, 5525, 5780 }
            },
            new FrequencyGroup()
            {
                To = "1600",
                From = "1700",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Jessore.ToString(),
                Frequencies = new List<long>() { 5780, 5230, 4735, 4975, 6631, 5240, 5339, 5395, 5549, 5485 }
            },
            new FrequencyGroup()
            {
                To = "1700",
                From = "1800",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Dhaka.ToString(),
                Frequencies = new List<long>() { 5548, 5641, 5743, 5646, 4135, 4516, 4712, 4319, 5935, 5507 }
            },
            new FrequencyGroup()
            {
                To = "1700",
                From = "1800",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Chittagong.ToString(),
                Frequencies = new List<long>() { 5548, 5641, 5743, 5646, 4135, 4516, 4712, 4319, 5112, 5105 }
            },
            new FrequencyGroup()
            {
                To = "1700",
                From = "1800",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Jessore.ToString(),
                Frequencies = new List<long>() { 5030, 5219, 5470, 5743, 4135, 4516, 5530, 4712, 5549, 5641 }
            },
            new FrequencyGroup()
            {
                To = "1800",
                From = "1900",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Dhaka.ToString(),
                Frequencies = new List<long>() { 5771, 5780, 5773, 5531, 5405, 5505, 5316, 5315, 5225, 5305 }
            },
            new FrequencyGroup()
            {
                To = "1800",
                From = "1900",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Chittagong.ToString(),
                Frequencies = new List<long>() { 5305, 5771, 5780, 5773, 5530, 5405, 5505, 5316, 5319, 5315, 5225 }
            },
            new FrequencyGroup()
            {
                To = "1800",
                From = "1900",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Jessore.ToString(),
                Frequencies = new List<long>() { 5225, 5315, 5305, 5771, 5780, 5773, 5530, 5505, 5316, 5225 }
            },
            new FrequencyGroup()
            {
                To = "1900",
                From = "2000",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Dhaka.ToString(),
                Frequencies = new List<long>() { 5115, 5110, 5225, 5216, 4530, 4531, 4050, 3910, 3510, 4215 }
            },
            new FrequencyGroup()
            {
                To = "1900",
                From = "2000",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Chittagong.ToString(),
                Frequencies = new List<long>() { 5115, 5110, 5225, 5216, 4530, 4535, 4050, 3910, 3515, 4225 }
            },
            new FrequencyGroup()
            {
                To = "1900",
                From = "2000",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Jessore.ToString(),
                Frequencies = new List<long>() { 5115, 5030, 5325, 5216, 4530, 4585, 4050, 3910, 3516, 4225 }
            },
            new FrequencyGroup()
            {
                To = "2000",
                From = "2100",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Dhaka.ToString(),
                Frequencies = new List<long>() { 5035, 5210, 5135, 4615, 4415, 4180, 4715, 5510, 5536, 5710 }
            },
            new FrequencyGroup()
            {
                To = "2000",
                From = "2100",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Chittagong.ToString(),
                Frequencies = new List<long>() { 5035, 5210, 5135, 4615, 4415, 4180, 4715, 5510, 5536, 5710 }
            },
            new FrequencyGroup()
            {
                To = "2000",
                From = "2100",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Jessore.ToString(),
                Frequencies = new List<long>() { 5035, 5210, 5135, 4615, 4415, 4180, 4715, 5510, 5536, 5710 }
            },
            new FrequencyGroup()
            {
                To = "2100",
                From = "2200",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Dhaka.ToString(),
                Frequencies = new List<long>() { 4890, 4895, 5501, 5305, 5105, 5113, 4516, 4518, 4205, 3625 }
            },
            new FrequencyGroup()
            {
                To = "2100",
                From = "2200",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Chittagong.ToString(),
                Frequencies = new List<long>() { 4890, 4895, 5501, 5305, 5105, 5113, 4516, 4518, 4205, 3625 }
            },
            new FrequencyGroup()
            {
                To = "2100",
                From = "2200",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Jessore.ToString(),
                Frequencies = new List<long>() { 4890, 4895, 5501, 5305, 5105, 5113, 4516, 4518, 4205, 3625 }
            },
            new FrequencyGroup()
            {
                To = "2200",
                From = "2300",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Dhaka.ToString(),
                Frequencies = new List<long>() { 5605, 5319, 5206, 5019, 4015, 4115, 4215, 4216, 4515, 3625 }
            },
            new FrequencyGroup()
            {
                To = "2200",
                From = "2300",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Chittagong.ToString(),
                Frequencies = new List<long>() { 5605, 5319, 5206, 5019, 4015, 4115, 4215, 4216, 4515, 3625 }
            },
            new FrequencyGroup()
            {
                To = "1700",
                From = "1800",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Jessore.ToString(),
                Frequencies = new List<long>() { 5655, 5419, 5106, 5019, 4015, 4215, 4217, 4515, 3512, 3115 }
            },
            new FrequencyGroup()
            {
                To = "2300",
                From = "0059",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Dhaka.ToString(),
                Frequencies = new List<long>() { 4205, 4231, 5562, 3595, 3680, 3565, 4320, 4885, 3215, 3136 }
            },
            new FrequencyGroup()
            {
                To = "2300",
                From = "0059",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Chittagong.ToString(),
                Frequencies = new List<long>() { 4115, 4535, 5062, 3591, 3580, 3562, 4325, 4870, 3115, 3136 }
            },
            new FrequencyGroup()
            {
                To = "1800",
                From = "1900",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Jessore.ToString(),
                Frequencies = new List<long>() { 4205, 4231, 5562, 3595, 3680, 3565, 4320, 4885, 3215, 3136 }
            },
            new FrequencyGroup()
            {
                To = "0059",
                From = "0100",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Dhaka.ToString(),
                Frequencies = new List<long>() { 5735, 5135, 5360, 4215, 4335, 3515, 3585, 3505, 3116, 3080 }
            },
            new FrequencyGroup()
            {
                To = "0059",
                From = "0100",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Chittagong.ToString(),
                Frequencies = new List<long>() { 5710, 5135, 5360, 4215, 4330, 3515, 3385, 3205, 3115, 3085 }
            },
            new FrequencyGroup()
            {
                To = "0059",
                From = "0100",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Jessore.ToString(),
                Frequencies = new List<long>() { 5115, 5030, 5325, 4215, 4535, 3515, 3375, 3205, 3116, 3085 }
            },
            new FrequencyGroup()
            {
                To = "0100",
                From = "0200",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Dhaka.ToString(),
                Frequencies = new List<long>() { 3315, 3235, 3425, 3515, 3556, 4115, 4230, 4245, 4320, 4510 }
            },
            new FrequencyGroup()
            {
                To = "0100",
                From = "0200",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Chittagong.ToString(),
                Frequencies = new List<long>() { 3315, 3235, 3425, 3515, 3556, 4115, 4230, 4245, 4320, 4510 }
            },
            new FrequencyGroup()
            {
                To = "0100",
                From = "0200",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Jessore.ToString(),
                Frequencies = new List<long>() { 4335, 3515, 3425, 3515, 3556, 3575, 3255, 3226, 4245, 4325 }
            },
            new FrequencyGroup()
            {
                To = "0200",
                From = "0300",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Dhaka.ToString(),
                Frequencies = new List<long>() { 4710, 4575, 4435, 3315, 3617, 3225, 2995, 2870, 2996, 3117 }
            },
            new FrequencyGroup()
            {
                To = "0200",
                From = "0300",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Chittagong.ToString(),
                Frequencies = new List<long>() { 4715, 4576, 4435, 3315, 3617, 3225, 2995, 2870, 2996, 3117 }
            },
            new FrequencyGroup()
            {
                To = "0200",
                From = "0300",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Jessore.ToString(),
                Frequencies = new List<long>() { 4715, 4576, 4435, 3315, 3617, 3225, 2995, 2870, 2996, 3117 }
            },
            new FrequencyGroup()
            {
                To = "0300",
                From = "0400",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Dhaka.ToString(),
                Frequencies = new List<long>() { 3130, 3236, 3355, 3450, 3560, 4130, 4145, 4422, 4675, 5535 }
            },
            new FrequencyGroup()
            {
                To = "0300",
                From = "0400",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Chittagong.ToString(),
                Frequencies = new List<long>() { 3130, 3236, 3355, 3450, 3560, 4130, 4145, 4422, 4675, 5105 }
            },
            new FrequencyGroup()
            {
                To = "0300",
                From = "0400",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Jessore.ToString(),
                Frequencies = new List<long>() { 3130, 3236, 3355, 3450, 3560, 4130, 4145, 4422, 4675, 5105 }
            },
            new FrequencyGroup()
            {
                To = "0400",
                From = "0500",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Dhaka.ToString(),
                Frequencies = new List<long>() { 3250, 2750, 2678, 2775, 3075, 3190, 3910, 4235, 3536, 3230 }
            },
            new FrequencyGroup()
            {
                To = "0400",
                From = "0500",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Chittagong.ToString(),
                Frequencies = new List<long>() { 2750, 2675, 2750, 3250, 3075, 3190, 3910, 4235, 3536, 3200 }
            },
            new FrequencyGroup()
            {
                To = "0400",
                From = "0500",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Jessore.ToString(),
                Frequencies = new List<long>() { 3250, 2750, 2678, 2775, 3075, 3190, 3910, 4235, 2750, 2890 }
            },
            new FrequencyGroup()
            {
                To = "0500",
                From = "0600",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Dhaka.ToString(),
                Frequencies = new List<long>() { 3545, 4325, 2885, 2965, 4850, 5175, 4275, 3775, 4995, 4275 }
            },
            new FrequencyGroup()
            {
                To = "0500",
                From = "0600",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Chittagong.ToString(),
                Frequencies = new List<long>() { 3545, 4325, 2885, 2965, 4850, 5175, 4275, 3775, 4995, 4275 }
            },
            new FrequencyGroup()
            {
                To = "0500",
                From = "0600",
                Weather = WeatherStatus.Clear.ToString(),
                Location = District.Jessore.ToString(),
                Frequencies = new List<long>() { 3545, 4325, 2885, 2965, 4850, 5175, 4275, 3775, 4995, 4275 }
            }
        }; 
    }
}