using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Text textComponent;
    [SerializeField] State StartingState;
    
    State state;
    void Start()
    {

         state = StartingState;
       
         textComponent.text = state.GetStoryText();
           
        //textComponent.text = "I'm added programmatically!";
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }
    
    private void ManageState(){
        var NextStates = state.GetNextState();

         for(int i=0;i<NextStates.Length;i++){
             if(Input.GetKeyDown(KeyCode.Alpha1+i)){

                  state = NextStates[i];    
                  
             }

             if(Input.GetKeyDown(KeyCode.Q)){
                 state = StartingState;
                 break;
             }
         }

        
         textComponent.text = state.GetStoryText();
    }














    //     if(Input.GetKeyDown(KeyCode.Alpha1)){     //Key 1 = option 1
    //         state = NextStates[0];
    //     }

    //     else if(Input.GetKeyDown(KeyCode.Alpha2)){ //Key 2 = option 2
    //         state = NextStates[1];
    //     }

    //     else if(Input.GetKeyDown(KeyCode.Alpha3)){ //Key 3 = option 3
    //         state = NextStates[2];
    //     }

    //     textComponent.text = state.GetStoryText();
    // }

    
}
