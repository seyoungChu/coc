using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    GridManager gridManager;
    InputManager inputManager;

    // Use this for initialization
    void Start()
    {
        GameObject gridObject = new GameObject("GridManager");
        gridObject.transform.SetParent(transform);
        gridManager = gridObject.AddComponent<GridManager>();
        gridManager.Init();

        GameObject inputObject = new GameObject("InputManager");
        inputObject.transform.SetParent(transform);
        inputManager = inputObject.AddComponent<InputManager>();

    }

    // Update is called once per frame
    void Update()
    {

        this.inputManager.TouchUpdate();

        this.inputManager.UpdateGameInput();

    }
}
