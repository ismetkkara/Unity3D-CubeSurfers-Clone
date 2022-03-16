using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toplayici : MonoBehaviour
{ 
    GameObject TOP;
    int yukseklik;
    void Start()
    {
        TOP = GameObject.Find("AnaKup");
    }

    // Update is called once per frame
    void Update()
    {
        TOP.transform.position = new Vector3(transform.position.x, yukseklik + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -yukseklik, 0);
    }
    public void YukseklikAzalt()
    {
        yukseklik--;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "topla"&&other.gameObject.GetComponent<toplanacakToplar>().GetToplandiMi()==false) 
        {
            yukseklik += 1;
            other.gameObject.GetComponent<toplanacakToplar>().ToplandiYap();
            other.gameObject.GetComponent<toplanacakToplar>().IndexAyarla(yukseklik);
            other.gameObject.transform.parent = TOP.transform;

        }
    }
}
