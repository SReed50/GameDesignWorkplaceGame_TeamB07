using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameInventory : MonoBehaviour
{
    public GameObject menuBuild; 
    public static bool menuBuildIsOpen = false;
    

    //Hut variables:
    public GameObject buildHutButton;
    public Text hutItem1nums;
    public Text hutItem2nums;
    public Text hutItem3nums;
    public int hutItem1need = 2;
    public int hutItem2need = 2;
    public int hutItem3need = 1;
    private bool hutItem1complete = false;
    private bool hutItem2complete = false;
    private bool hutItem3complete = false;



    void Start()
    {
        if (!menuBuildIsOpen){
            menuBuild.SetActive(false);
        } else {
            menuBuild.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("b")){
            ToggleBuildMenu();
        }



        if (hutItem1complete && hutItem2complete && hutItem3complete){
            buildHutButton.SetActive(true);
        } else {
            buildHutButton.SetActive(false);
        }


    }

    public void ToggleBuildMenu(){
        menuBuildIsOpen = !menuBuildIsOpen;
        
        if (!menuBuildIsOpen){
            menuBuild.SetActive(false);
        } else {
            menuBuild.SetActive(true);
        }
    }




    public void BuildHut(){
        Debug.Log("I built a hut!");
        //actual hut visibility goes here
    }



}
