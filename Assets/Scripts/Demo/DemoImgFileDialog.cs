using System;
using Infrastructure;
using UnityEngine;

namespace Demo
{
    public class DemoImgFileDialog : MonoBehaviour
    {
        void Start()
        {
            string filepath = new ImgFileDialog().OpenDialogAndGetFilePath();
            Debug.Log(filepath);
        }
    }
}