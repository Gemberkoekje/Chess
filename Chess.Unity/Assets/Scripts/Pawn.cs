using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess.Core.Factories;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameFactory.NewGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
