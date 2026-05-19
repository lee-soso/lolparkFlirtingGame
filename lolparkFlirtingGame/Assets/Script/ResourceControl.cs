using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;

public class ResourceControl : MonoBehaviour
{
    [SerializeField] float resource = 5;
    private const int maxResource = 10;
    [SerializeField] List<Image> resourceObjects = new List<Image>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    private void FixedUpdate()
    {
        renewal();
    }

    public void renewal()
    {
        float temp = resource;

        for (int i = 0; i < maxResource; i++)
        {
            resourceObjects[i].fillAmount = temp;
            temp--;
        }
    }

    public void useResourceOneTick()
    {
        resource -= 0.25f / Application.targetFrameRate;
        isOver();
    }

    public void useResourceOneClick()
    {
        resource -= 0.05f;
        isOver();
    }

    public void getResourse()
    {
        resource += 1f;
        isOver();
    }

    private void isOver()
    {
        if (resource < 0)
        {
            resource = 0;

            //gameOver
            Debug.Log("Gameover");
        }
        else if (resource > maxResource)
        {
            resource = 5;

            //enter the trans mode
            Debug.Log("trans mode");
        }
    }
}