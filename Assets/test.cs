using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
 
    //nums=2,7,11,15
    //target=9

    int [] twoSum(int[] nums,int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for(int i = 1; i < nums.Length;i++)
        {
            int result = target - nums[i];
            if (map.ContainsKey(result))
            {
                return new int[] { map[result], i };

            }
            if(!map .ContainsKey(nums[i]))
            {
                map.Add(nums[i], i);
            }
        }
        return new int[0];
    }

}
