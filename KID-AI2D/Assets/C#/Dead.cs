using UnityEngine;
using UnityEngine.Events;           //引用 事件 API
using UnityEngine.UI;               //引用 事件 API

public class Dead : MonoBehaviour
{
    public GameObject final;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "QQ")
        {
           final.SetActive(true);
        }
         
    }
}
