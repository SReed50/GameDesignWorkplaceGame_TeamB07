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
    private int hutNailsNeed = 4;
    private int hutWoodNeed = 6;
    private int hutMetalNeed = 0;
    private bool hutNailsComplete = false;
    private bool hutWoodComplete = false;
    private bool hutMetalComplete = false;

    // Shed variables:
    public GameObject buildShedButton;
    public Text shedNails;
    public Text shedWood;
    public Text shedMetal;
    private int shedNailsNeed = 4;
    private int shedWoodNeed = 6;
    private int shedMetalNeed = 2;
    private bool shedNailsComplete = false;
    private bool shedWoodComplete = false;
    private bool shedMetalComplete = false;

    // House variables:
    public GameObject buildHouseButton;
    public Text houseNails;
    public Text houseWood;
    public Text houseMetal;
    private int houseNailsNeed = 10;
    private int houseWoodNeed = 10;
    private int houseMetalNeed = 5;
    private bool houseNailsComplete = false;
    private bool houseWoodComplete = false;
    private bool houseMetalComplete = false;

    // Fort variables:
    public GameObject buildFortButton;
    public Text fortNails;
    public Text fortWood;
    public Text fortMetal;
    private int fortNailsNeed = 25;
    private int fortWoodNeed = 6;
    private int fortMetalNeed = 12;
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
        UpdateNailsText();
        UpdateWoodText();
        UpdateMetalText();
        // only here temporarily until we have a way to pick up an object
    }

    public void ToggleBuildMenu(){
        menuBuildIsOpen = !menuBuildIsOpen;
        
        if (!menuBuildIsOpen){
            menuBuild.SetActive(false);
        } else {
            menuBuild.SetActive(true);

            // Set text vars
            UpdateNailsText();
            UpdateWoodText();
            UpdateMetalText();
        }
    }

    void OnCollisionEnter (Collision other) {

        if (other.gameObject.tag == "Nails") {
            Destroy(other.gameObject);
            nailsHave++;
            UpdateNailsText();
        } else if (other.gameObject.tag == "Wood") {
            Destroy(other.gameObject);
            woodHave++;
            UpdateWoodText();
        } else if (other.gameObject.tag == "Metal") {
            Destroy(other.gameObject);
            metalHave++;
            UpdateMetalText();
        }
    }

    public void UpdateNailsText() {
        hutNails.text = nailsHave + " / " + hutNailsNeed;
        shedNails.text = nailsHave + " / " + shedNailsNeed;
        houseNails.text = nailsHave + " / " + houseNailsNeed;
        fortNails.text = nailsHave + " / " + fortNailsNeed; 

        CheckNails();
    }

    public void UpdateWoodText() {
        hutWood.text = woodHave + " / " + hutWoodNeed;
        shedWood.text = woodHave + " / " + shedWoodNeed;
        houseWood.text = woodHave + " / " + houseWoodNeed;
        fortWood.text = woodHave + " / " + fortWoodNeed;

        CheckWood();
    }

    public void UpdateMetalText() {
        hutMetal.text = metalHave + " / " + hutMetalNeed;
        shedMetal.text = metalHave + " / " + shedMetalNeed;
        houseMetal.text = metalHave + " / " + houseMetalNeed;
        fortMetal.text = metalHave + " / " + fortMetalNeed;

        CheckMetal();
    }

    // check if enough of a material to build each structure
    public void CheckNails() {
        if (nailsHave >= hutNailsNeed) {
            hutNailsComplete = true;
            hutNails.color = Color.green;
        } else {
            hutNailsComplete = false;
            hutNails.color = Color.red;
        }

        if (nailsHave >= shedNailsNeed) {
            shedNailsComplete = true;
            shedNails.color = Color.green;
        } else {
            shedNailsComplete = false;
            shedNails.color = Color.red;
        }

        if (nailsHave >= houseNailsNeed) {
            houseNailsComplete = true;
            houseNails.color = Color.green;
        } else {
            houseNailsComplete = false;
            houseNails.color = Color.red;
        }

        if (nailsHave >= fortNailsNeed) {
            fortNailsComplete = true;
            fortNails.color = Color.green;
        } else {
            fortNailsComplete = false;
            fortNails.color = Color.red;
        }

        // Update build button status
        checkHut();
        checkShed();
        checkHouse();
        checkFort();
    }

    public void CheckWood() {
        if (woodHave >= hutWoodNeed) {
            hutWoodComplete = true;
            hutWood.color = Color.green;
        } else {
            hutWoodComplete = false;
            hutWood.color = Color.red;
        }

        if (woodHave >= shedWoodNeed) {
            shedWoodComplete = true;
            shedWood.color = Color.green;
        } else {
            shedWoodComplete = false;
            shedWood.color = Color.red;
        }

        if (woodHave >= houseWoodNeed) {
            houseWoodComplete = true;
            houseWood.color = Color.green;
        } else {
            houseWoodComplete = false;
            houseWood.color = Color.red;
        }

        if (woodHave >= fortWoodNeed) {
            fortWoodComplete = true;
            fortWood.color = Color.green;
        } else {
            fortWoodComplete = false;
            fortWood.color = Color.red;
        }

        // Update build button status
        checkHut();
        checkShed();
        checkHouse();
        checkFort();
    }

    public void CheckMetal() {
        if (metalHave >= hutMetalNeed) {
            hutMetalComplete = true;
            hutMetal.color = Color.green;
        } else {
            hutMetalComplete = false;
            hutMetal.color = Color.red;
        }

        if (metalHave >= shedMetalNeed) {
            shedMetalComplete = true;
            shedMetal.color = Color.green;
        } else {
            shedMetalComplete = false;
            shedMetal.color = Color.red;
        }

        if (metalHave >= houseMetalNeed) {
            houseMetalComplete = true;
            houseMetal.color = Color.green;
        } else {
            houseMetalComplete = false;
            houseMetal.color = Color.red;
        }

        if (metalHave >= fortMetalNeed) {
            fortMetalComplete = true;
            fortMetal.color = Color.green;
        } else {
            fortMetalComplete = false;
            fortMetal.color = Color.red;
        }

        // Update build button status
        checkHut();
        checkShed();
        checkHouse();
        checkFort();
    }

    // check if enough materials to build each structure
    public void checkHut() {
        if (hutNailsComplete && hutWoodComplete && hutMetalComplete){
            buildHutButton.SetActive(true);
        } else {
            buildHutButton.SetActive(false);
        }
    }

    public void checkShed() {
        if (shedNailsComplete && shedWoodComplete && shedMetalComplete){
            buildShedButton.SetActive(true);
        } else {
            buildShedButton.SetActive(false);
        }
    }

    public void checkHouse() {
        if (houseNailsComplete && houseWoodComplete && houseMetalComplete){
            buildHouseButton.SetActive(true);
        } else {
            buildHouseButton.SetActive(false);
        }
    }

    public void checkFort() {
        if (fortNailsComplete && fortWoodComplete && fortMetalComplete){
            buildFortButton.SetActive(true);
        } else {
            buildFortButton.SetActive(false);
        }
    }

    // build each structure
    public void BuildHut(){
        Debug.Log("I built a hut!");
        //actual hut visibility goes here

        nailsHave -= hutNailsNeed;
        woodHave -= hutWoodNeed;
        metalHave -= hutMetalNeed;

        // Set text vars
        UpdateNailsText();
        UpdateWoodText();
        UpdateMetalText();
    }

    public void BuildShed(){
        Debug.Log("I built a shed!");
        //actual hut visibility goes here

        nailsHave -= shedNailsNeed;
        woodHave -= shedWoodNeed;
        metalHave -= shedMetalNeed;

        // Set text vars
        UpdateNailsText();
        UpdateWoodText();
        UpdateMetalText();
    }

    public void BuildHouse(){
        Debug.Log("I built a house!");
        //actual hut visibility goes here

        nailsHave -= houseNailsNeed;
        woodHave -= houseWoodNeed;
        metalHave -= houseMetalNeed;

        // Set text vars
        UpdateNailsText();
        UpdateWoodText();
        UpdateMetalText();
    }

    public void BuildFort(){
        Debug.Log("I built a fort!");
        //actual hut visibility goes here

        nailsHave -= fortNailsNeed;
        woodHave -= fortWoodNeed;
        metalHave -= fortMetalNeed;

        // Set text vars
        UpdateNailsText();
        UpdateWoodText();
        UpdateMetalText();
    }
}
