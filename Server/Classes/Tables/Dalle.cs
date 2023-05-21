using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Classes.Tables
{
    public class Dalle
    {
        public int questionId;
        public string imageUrl, keyword_1, keyword_2, keyword_3;

        public Dalle(int questionId,
            string imageUrl, string keyword_1, string keyword_2, string keyword_3)
        {
            this.questionId = questionId;
            this.imageUrl = imageUrl;
            this.keyword_1 = keyword_1;
            this.keyword_2 = keyword_2;
            this.keyword_3 = keyword_3;
        }
    }
}
