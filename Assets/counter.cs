using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class counter : MonoBehaviour
{
    double counterValue = 100;
    public Text countText;
    Rigidbody rigidbody = new Rigidbody(); 

    void Start()
    {
        counterValue = 100;
        //countText = GetComponent<Text>(); 
        rigidbody = GetComponent<Rigidbody>();
        countText.text = "—чЄтчик: " + counterValue.ToString();
    }

    void Update()
    {
        
    }

    // ћетод, который вызываетс€ при столкновении
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PU"))
        {
            //other.gameObject.SetActive(false);
            counterValue-=0.5;
            //print("Pop");
            countText.text = "—чЄтчик: " + counterValue.ToString();
        }
    }
    /*void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "OtherObject")
        {
            counterValue--;
            countText.text = "—чЄтчик: " + counterValue.ToString();
        }
    }*/
}
