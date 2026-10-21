using UnityEngine;
using UnityEngine.InputSystem;

public class ClickScript : MonoBehaviour
{
    //Variables
    private Camera maincam;

    //Awake is called before the first frame
    private void Awake()
    {
        maincam = Camera.main;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //check if the left mouse button is pressed and then call the raycast function if it is
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            Raycasthit();
        }
    }

    private void Raycasthit()
    {
        // get the current mouse position
        Vector2 mousePos = Mouse.current.position.ReadValue();

        // Convert a screen position to a ray
        Ray ray = maincam.ScreenPointToRay(mousePos);


        //Cast a ray and if it hits something do something
        RaycastHit2D hit2D = Physics2D.GetRayIntersection(ray);

        //if we hit something
        if(hit2D.collider != null)
        {
            //set the currentfood to the next number in the array
            if(GameManager.instance.currentfoodnumber < GameManager.instance.shoppingarray.Length - 1)
            {
                GameManager.instance.currentfoodnumber++;
                GameManager.instance.currentfood = GameManager.instance.shoppingarray[GameManager.instance.currentfoodnumber];
            }else
            {
                GameManager.instance.currentfoodnumber = 0;
                GameManager.instance.currentfood = GameManager.instance.shoppingarray[0];
            }
        Debug.Log("Hit" + hit2D.collider.name);
        Debug.Log(GameManager.instance.currentfoodnumber);    
        }
    }

}
