using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;
using Newtonsoft.Json;

using Newtonsoft.Json.Linq;
using System.Security.Policy;
using System.Threading;


namespace Server.Classes
{
    public class Dall_E
    {
        

        private static HttpClient sharedClient1 = new HttpClient()
        {
            BaseAddress = new Uri("https://api.openai.com/"),
        };
        private static HttpClient sharedClient2 = new HttpClient()
        {
            BaseAddress = new Uri("https://api.openai.com/"),
        };
        private static HttpClient sharedClient3 = new HttpClient()
        {
            BaseAddress = new Uri("https://api.openai.com/"),
        };
        private static HttpClient sharedClient4 = new HttpClient()
        {
            BaseAddress = new Uri("https://api.openai.com/"),
        };
        private static HttpClient sharedClient5 = new HttpClient()
        {
            BaseAddress = new Uri("https://api.openai.com/"),
        };

        public static Dictionary<int, string> imgList;

        public List<string> words = new List<string> { "Selfie", "Influencer", "Vlog", "TikTok", "Cryptocurrency", "Streaming", "Memes", 
            "Sustainable", "Cancel", "culture", "Eco-friendly", "Virtual", "reality", "Artificial", "intelligence", 
            "Blockchain", "Cloud", "computing", "Swipe", "YOLO", "Emoji", "Hashtag", "Zoom", "Podcast", "Algorithm", "Biohacking", 
            "Mindfulness", "Gluten-free", "Vegan", "Keto", "Flexitarian", "Digital", "detox", "Influencer", "marketing", "Deepfake", 
            "Hackathon", "Augmented", "reality", "Big", "data", "Internet",  "IoT", "Remote", "work", 
            "Staycation", "Microdosing", "Geofencing", "UX", "VR", "IoT", "NFT", "E-commerce", "Gamification", 
            "Data", "mining", "Disruptive", "Wellness", "Sustainability", "Mindset", "Resilience", "Biohacking", 
            "Agility", "Gig", "economy", "Remote", "learning", "Digital", "nomad", "Cybersecurity", "Bioengineering", 
            "Podcasting", "Machine", "learning", "Crowdfunding", "Freelancing", "Influencer", "economy", "Mental", 
            "health" };

        public List<List<string>> CreateWords(int level)
        {
            int[] idxWord = MakeRandomNumbers(1, 79, 0);

            List<List<string>> wordsList = new List<List<string>>(10);

            int cnt = 0;

            for(int i=0; i<6; i++)
            {
                List<string> tmp = new List<string>(new string[7]);
                for(int j=0; j<level; j++)
                {
                    tmp[j] = words[idxWord[cnt++]];
                    
                }
                for(int  k=level; k<6; k++)
                {
                    tmp[k] = " ";
                }
                wordsList.Add(tmp);
            }

            return wordsList;
        }

        public async Task<Dictionary<int, string>> CreateImgList(List<string> _prompt)
        {
            imgList = new Dictionary<int, string>();

            Task t1 = CreateImage(sharedClient1, _prompt[0], 0);
            Task t2 = CreateImage(sharedClient2, _prompt[1], 1);
            Task t3 = CreateImage(sharedClient3, _prompt[2], 2);
            Task t4 = CreateImage(sharedClient4, _prompt[3], 3);
            Task t5 = CreateImage(sharedClient5, _prompt[4], 4);

            await t1;
            await t2;
            await t3;
            await t4;
            await t5;

            return imgList;

        }

        static async Task CreateImage(HttpClient sharedClient, string _prompt, int idx)
        {
            string apiKey;

           
            using (StringContent jsonContent = new StringContent(
                Newtonsoft.Json.JsonConvert.SerializeObject(new
                {
                    model = "image-alpha-001",
                    prompt = _prompt,
                    num_images = 1,
                    size = "256x256",
                    response_format = "url"
                }),
                Encoding.UTF8,
                "application/json"))
            {
                
                // sharedClient.DefaultRequestHeaders.Add("Authorization", apiKey);

                using (HttpResponseMessage response = await sharedClient.PostAsync(
                    "v1/images/generations",
                    jsonContent))
                {
                    response.EnsureSuccessStatusCode();

                    var responseJson = JObject.Parse(await response.Content.ReadAsStringAsync());
                    var url = responseJson["data"][0]["url"].ToString();

                    imgList.Add(idx, url);

                }
            }
            
            
        }

        //string img1 = "https://pbs.twimg.com/media/Fb_Sec8WQAIbCZV?format=jpg&name=medium";
        //string img2 = "https://i.ytimg.com/vi/HUNFD3ktkQ4/maxresdefault.jpg";
        //string img3 = "https://i.ytimg.com/vi/K0TW-zcbEuY/mqdefault.jpg";
        //string img4 = "https://pbs.twimg.com/media/Fb_Sec8WQAIbCZV?format=jpg&name=medium";
        //string img5 = "https://i.ytimg.com/vi/HUNFD3ktkQ4/maxresdefault.jpg";

        public static int[] MakeRandomNumbers(int minValue, int maxValue, int randomSeed = 0)
        {
            if (randomSeed == 0)
                randomSeed = (int)DateTime.Now.Ticks;

            List<int> values = new List<int>();
            for (int v = minValue; v < maxValue; v++)
            {
                values.Add(v);
            }

            int[] result = new int[maxValue - minValue];
            System.Random random = new System.Random(Seed: randomSeed);
            int i = 0;
            while (values.Count > 0)
            {
                int randomValue = values[random.Next(0, values.Count)];
                result[i++] = randomValue;

                if (!values.Remove(randomValue))
                {
                    // Exception
                    break;
                }
            }

            return result;
        }
    }
}
