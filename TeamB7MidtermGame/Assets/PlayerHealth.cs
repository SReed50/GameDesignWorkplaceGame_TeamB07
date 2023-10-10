using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Display_and_decrease_playerhealth_when_collided_with_enemies_or_objects : MonoBehaviour
{
      public float health;
      public Slider slider;
      public Text text;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
                                                    
     slider.value=health;                           
     text.text="Health : "+health;                  
        
    }
                                                    
    void OnCollisionEnter(Collision obj)
    {
                                                    
        if(obj.gameObject.tag=="Hazard")
        health=health-10f;                         
    }
 
}