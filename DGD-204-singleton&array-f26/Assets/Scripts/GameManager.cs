using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{

    //Variables
    public TextMeshProUGUI foodtest;
    public string currentfood;
    public int currentfoodnumber = 0;
    //Make an Array that will hold strings
    public string[] shoppingarray = new string[10]
    {/*0*/"Saffron",/*1*/"Milk",/*2*/"Bread","Eggs","Cheese","Oil","Ham","Noodles",/*8*/"Bacon",/*9*/"PB&J"};

    //Singleton
public static GameManager instance;

//Awake is called when the script initiates pre frame 1
private void Awake()
{
    //if theree is not an instance of this script in the game, make this the main instance
    if(instance == null)
    {
       instance = this;
       DontDestroyOnLoad(gameObject);
    }else //if there are duplicates
    {
        //Destroy all duplicates except the main instance
        Destroy(gameObject);
    }
}

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentfood = shoppingarray[currentfoodnumber];
    }

    // Update is called once per frame
    void Update()
    {
        foodtest.text = currentfood;
    }
}
