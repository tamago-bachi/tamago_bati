using System;
using UnityEngine;

namespace Infrastructure
{
    public class ImageSelectButton : MonoBehaviour
    {
        //ボタンが押されたときに呼ばれるイベント
        public event Action clicked;

        public void OnClick()
        {
            clicked?.Invoke();
        }
    }
}