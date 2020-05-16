using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")] //Creating custom "State" option based on this class on menu
public class State : ScriptableObject
{

   [TextArea(10,14)] [SerializeField] string StoryText;
    // Start is called before the first frame update

}
