using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucene.Net.Search;

namespace EduSearchAdvancedIS
{
    class CustomizedSimilarity: DefaultSimilarity
    {
        public override float SloppyFreq(int distance)
        {
            return 1.0f / (distance + 1);
        }
        //public override float Tf(float freq)
        //{
        //    //
        //    //1~4==>1*2 4~9 2*2, 2*2 9 16 3* increase the importance of the unique terms
        //    //1~4 as important as 4~8
        //    //4~8   2* increase the inportance of unique terms...

        //    if (freq > 0 && freq < 4)
        //    {
        //        freq *= 4;
        //    }
        //    /*
        //     * make it decrease the overall inportance of tf
        //     * 
        //     */
        //    return (float)Math.Sqrt(freq) / 2;
        //}
    }
}
