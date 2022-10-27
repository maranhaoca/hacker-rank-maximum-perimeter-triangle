using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Result
    {
        /*
         * Complete the 'maximumPerimeterTriangle' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY sticks as parameter.
         */

        public static List<int> maximumPerimeterTriangle(List<int> sticks)
        {
            List<List<int>> result = new List<List<int>>();
            
            sticks.Sort();
            for (int i = 0; i < sticks.Count -2; i++)
            {
                for (int j = i + 1; j < sticks.Count -1; j++)
                {
                    for (int k = j + 1; k < sticks.Count; k++)
                    {
                        if ((sticks[i] + sticks[j] > sticks[k]) && (sticks[i] + sticks[k] >= sticks[j]))
                        {                            
                            result.Clear();
                            result.Add(new List<int>(){sticks[i], sticks[j], sticks[k]});
                            
                        }
                    }
                }
            }
             

            return result.Count() == 0 ? new List<int>(){-1} : result[0];
        }
    }
}