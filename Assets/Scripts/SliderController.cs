using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SliderController : MonoBehaviour
{
    public float delay = 1;
    float timer;
    [SerializeField]
    public int progress;
    public Slider slider;
    private void Start()
    {
        progress = 30;
    }
    public void UpdateProgress()
    {
        progress--;
        slider.value = progress;
    }
    private void Update()
    {
        
        timer += Time.deltaTime;
        if (timer > delay){

            UpdateProgress();
            timer -= delay;

        }
        if (progress == 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
   


}
