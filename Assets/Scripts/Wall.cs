using System;
using UnityEngine;

public class Wall : MonoBehaviour
{
    
    

    private void OnCollisionEnter2D(Collision2D c)
    {
        IHitable obj = c.gameObject.GetComponent<IHitable>();
        obj?.TakeDamage();
    }
}
