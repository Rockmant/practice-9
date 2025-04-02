using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;
//������ ������ ���������� ���� � ��������(superman badguy) ������ �� ��������� ������. 
public class RunnersScript : MonoBehaviour
{
    public Transform[] runner;
    private Vector3[] points;
    private int[] j = new int[5]; // 1 ��� 4 �������. ����� ����� � ������� ���� ���� ���� j[0] ��� ����



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
        for (int i = 0; i < runner.Length; i++) // ��������� �� ������� � ������� �������� � ����� ����
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