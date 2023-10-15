using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Display_and_decrease_playerhealth_when_collided_with_enemies_or_objects : MonoBehaviour
{
      public float health = 100f;
      public Slider slider;
      public Text text;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = health;                           
        text.text="Health: "+health;
    }

    // Update is called once per frame
    void Update()
    {                  
        
    }
                                                    
    void OnCollisionEnter(Collision obj)
    {
                                                    
        if (obj.gameObject.tag == "Hazard") {
            Destroy(obj.gameObject);
            health = health - 10f;
            slider.value = health;                           
            text.text = "Health: " + health;
            if (health == 0) {
                Debug.Log("You lose!");
            }
        }
                             
    }
 
}