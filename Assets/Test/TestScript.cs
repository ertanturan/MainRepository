using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    void Start()
    {
       //call the submodule from here 
       SubmoduleClass submoduleClass = new SubmoduleClass();

       Debug.Log(submoduleClass.SubmoduleCall());
    }

    
}
