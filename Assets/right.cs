using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class right : MonoBehaviour
{
    public GameObject but;
    void OnTriggerStay2D(Collider2D collision)
    {
        collision.transform.parent.transform.position = transform.position;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.parent.transform.position = transform.position;
        if(this.name == collision.name)
        {
            //GameObject.FindGameObjectWithTag("Finish").SetActive(true);
            but = GameObject.FindWithTag("Respawn").transform.GetChild(0).gameObject;
            Debug.Log(but);
            but.SetActive(true);
        }
    }
}
