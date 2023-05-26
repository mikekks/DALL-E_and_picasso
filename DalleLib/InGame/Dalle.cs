using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalleLib.InGame
{
    public class Dalle  // level 3밖에 안됨 수정 필요
    {
        public int roomId;
        public string imageUrl;
        public List<string> keywords;

        public Dalle(int roomId, string imageUrl, List<string> keywords)
        {
            this.roomId = roomId;
            this.imageUrl = imageUrl;
            this.keywords = keywords;
        }
    }
}
