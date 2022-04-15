using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");

        int sum;
        
        sum = 10+20;
        Debug.Log(sum);
        
        int num=10;

        sum=num+20;
        Debug.Log(sum);

        sum=sum+num;
        Debug.Log(sum);

        string str1="Unity";
        string str2="Engine";
        num=2020;

        str1=str1+str2;
        Debug.Log(str1);

        str1=str1+num;
        Debug.Log(str1);

        num=2020;

        if (num>2000)
        {
            Debug.Log("2000보다 크다");
        }

        string str="반복";
        for (int count = 0; count < 5;count++)
        {
            Debug.Log(str+count);
        }

        int[]score={100, 50, 80, 90, 95};
        
        score[1]=70;
        
        for(int index=0;index<5;index++)
        {
            Debug.Log(score[index]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
