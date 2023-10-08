using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameInventory : MonoBehaviour
{
    public GameObject menuBuild; 
    public static bool menuBuildIsOpen = false;
    

    // Hut variables:
    public GameObject buildHutButton;
    public Text hutNails;
    public Text hutWood;
    public Text hutMetal;
    public int hutNailsneed = 4;
    public int hutWoodneed = 6;
    public int hutMetalneed = 0;
    private bool hutNailscomplete = false;
    private bool hutWoodcomplete = false;
    private bool hutMetalcomplete = false;



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



        if (hutNailscomplete && hutWoodcomplete && hutMetalcomplete){
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
