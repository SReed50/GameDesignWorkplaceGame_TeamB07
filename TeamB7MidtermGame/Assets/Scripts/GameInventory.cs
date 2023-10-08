using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameInventory : MonoBehaviour
{
    public GameObject menuBuild; 
    public static bool menuBuildIsOpen = false;
    
    // Inventory Variables
    public int nailsHave = 0;
    public int woodHave = 0;
    public int metalHave = 0;

    // Hut variables:
    public GameObject buildHutButton;
    public Text hutNails;
    public Text hutWood;
    public Text hutMetal;
    public int hutNailsNeed = 4;
    public int hutWoodNeed = 6;
    public int hutMetalNeed = 0;
    private bool hutNailsComplete = false;
    private bool hutWoodComplete = false;
    private bool hutMetalComplete = false;

    // Shed variables:
    public GameObject buildShedButton;
    public Text shedNails;
    public Text shedWood;
    public Text shedMetal;
    public int shedNailsNeed = 4;
    public int shedWoodNeed = 6;
    public int shedMetalNeed = 2;
    private bool shedNailsComplete = false;
    private bool shedWoodComplete = false;
    private bool shedMetalComplete = false;

    // House variables:
    public GameObject buildHouseButton;
    public Text houseNails;
    public Text houseWood;
    public Text houseMetal;
    public int houseNailsNeed = 10;
    public int houseWoodNeed = 10;
    public int houseMetalNeed = 5;
    private bool houseNailsComplete = false;
    private bool houseWoodComplete = false;
    private bool houseMetalComplete = false;

    // Fort variables:
    public GameObject buildFortButton;
    public Text fortNails;
    public Text fortWood;
    public Text fortMetal;
    public int fortNailsNeed = 25;
    public int fortWoodNeed = 6;
    public int fortMetalNeed = 12;
    private bool fortNailsComplete = false;
    private bool fortWoodComplete = false;
    private bool fortMetalComplete = false;



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

        // Set text vars
        hutNails.text = nailsHave + " / " + hutNailsNeed;
        hutWood.text = woodHave + " / " + hutWoodNeed;
        hutMetal.text = metalHave + " / " + hutMetalNeed;

        shedNails.text = nailsHave + " / " + shedNailsNeed;
        shedWood.text = woodHave + " / " + shedWoodNeed;
        shedMetal.text = metalHave + " / " + shedMetalNeed;

        houseNails.text = nailsHave + " / " + houseNailsNeed;
        houseWood.text = woodHave + " / " + houseWoodNeed;
        houseMetal.text = metalHave + " / " + houseMetalNeed;

        fortNails.text = nailsHave + " / " + fortNailsNeed;
        fortWood.text = woodHave + " / " + fortWoodNeed;
        fortMetal.text = metalHave + " / " + fortMetalNeed;

        // Check if hut variables are complete
        if (nailsHave >= hutNailsNeed) {
            hutNailsComplete = true;
        } else {
            hutNailsComplete = false;
        }
        
        if (woodHave >= hutWoodNeed) {
            hutWoodComplete = true;
        } else {
            hutWoodComplete = false;
        }

        if (metalHave >= hutMetalNeed) {
            hutMetalComplete = true;
        } else {
            hutMetalComplete = false;
        }

        if (hutNailsComplete && hutWoodComplete && hutMetalComplete){
            buildHutButton.SetActive(true);
        } else {
            buildHutButton.SetActive(false);
        }

        // Check if shed variables are complete
        if (nailsHave >= shedNailsNeed) {
            shedNailsComplete = true;
        } else {
            shedNailsComplete = false;
        }
        
        if (woodHave >= shedWoodNeed) {
            shedWoodComplete = true;
        } else {
            shedWoodComplete = false;
        }

        if (metalHave >= shedMetalNeed) {
            shedMetalComplete = true;
        } else {
            shedMetalComplete = false;
        }

        if (shedNailsComplete && shedWoodComplete && shedMetalComplete){
            buildShedButton.SetActive(true);
        } else {
            buildShedButton.SetActive(false);
        }

        // Check if house variables are complete
        if (nailsHave >= houseNailsNeed) {
            houseNailsComplete = true;
        } else {
            houseNailsComplete = false;
        }
        
        if (woodHave >= houseWoodNeed) {
            houseWoodComplete = true;
        } else {
            houseWoodComplete = false;
        }

        if (metalHave >= houseMetalNeed) {
            houseMetalComplete = true;
        } else {
            houseMetalComplete = false;
        }

        if (houseNailsComplete && houseWoodComplete && houseMetalComplete){
            buildHouseButton.SetActive(true);
        } else {
            buildHouseButton.SetActive(false);
        }

        // Check if fort variables are complete
        if (nailsHave >= fortNailsNeed) {
            fortNailsComplete = true;
        } else {
            fortNailsComplete = false;
        }
        
        if (woodHave >= fortWoodNeed) {
            fortWoodComplete = true;
        } else {
            fortWoodComplete = false;
        }

        if (metalHave >= fortMetalNeed) {
            fortMetalComplete = true;
        } else {
            fortMetalComplete = false;
        }

        if (fortNailsComplete && fortWoodComplete && fortMetalComplete){
            buildFortButton.SetActive(true);
        } else {
            buildFortButton.SetActive(false);
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
        nailsHave -= hutNailsNeed;
        woodHave -= hutWoodNeed;
        metalHave -= hutMetalNeed;
    }

    public void BuildShed(){
        Debug.Log("I built a shed!");
        //actual hut visibility goes here
        nailsHave -= shedNailsNeed;
        woodHave -= shedWoodNeed;
        metalHave -= shedMetalNeed;
    }

    public void BuildHouse(){
        Debug.Log("I built a house!");
        //actual hut visibility goes here
        nailsHave -= houseNailsNeed;
        woodHave -= houseWoodNeed;
        metalHave -= houseMetalNeed;
    }

    public void BuildFort(){
        Debug.Log("I built a fort!");
        //actual hut visibility goes here
        nailsHave -= fortNailsNeed;
        woodHave -= fortWoodNeed;
        metalHave -= fortMetalNeed;
    }



}
