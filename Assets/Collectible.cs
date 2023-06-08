using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collectible : MonoBehaviour
{
    public SliderController slidercontroller;
  


    private void Awake()
    {
 
    }
    void Update()
    {
       
    }
    public void OnTriggerEnter(Collider other)
    {

       



        if (other.CompareTag("Player"))
        {
            slidercontroller.progress = 30;
            Destroy(gameObject);
            
            
        }
    }
}
