using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;
//Скрипт должен заставлять копа и бандитов(superman badguy) бегать по случайным точкам. 
public class RunnersScript : MonoBehaviour
{
    public Transform[] runner;
    private Vector3[] points;
    private int[] j = new int[5]; // 1 коп 4 бандита. Нужно чтобы у каждого была своя цель j[0] для копа



    private Vector3[] SetPointsMasiisve()
    {
        Random rnd = new Random(); 
         Vector3[] array = new Vector3[30];
        for (int i = 0; i < 30; i++)
        {
            array[i].Set(rnd.Next(-36, 6), 1, rnd.Next(-45, -6));

        }
         return array;
     }
     
    private void RunnerMoove()
    {
        float distance;
        for (int i = 0; i < runner.Length; i++) // пробегаем по бегунам и каждого сдвигаем к своей цели
        {
            distance = Vector3.Distance(runner[i].position, points[j[i]]);
            if (distance < 2)
            {
                if (j[i] < 29)
                {
                    j[i]++;
                    runner[i].LookAt(points[j[i]]);
                }
                else j[i] = 0;
            }
            runner[i].position = Vector3.MoveTowards(runner[i].position, points[j[i]], 0.1f);
        }
    }
    
    void Start()
    {
        points = SetPointsMasiisve();
        for(int i =0; i < 5; i++)
        {
            j[i] = 0;
        }

        
       
    }

    
    private void FixedUpdate()
    {

        RunnerMoove();
    }

}