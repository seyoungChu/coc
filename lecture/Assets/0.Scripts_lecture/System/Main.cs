using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : SingletonMonobehaviour<Main>
{
    GridManager gridManager;
    InputManager inputManager;
    EntityManager entityManager;
    DataManager dataManager;

	// Use this for initialization
	void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 30;
        Application.runInBackground = true;


        GameObject gridObject = new GameObject("GridManager");
        gridObject.transform.SetParent(transform);
        gridManager = gridObject.AddComponent<GridManager>();
        gridManager.Init();

        GameObject inputObject = new GameObject("InputManager");
        inputObject.transform.SetParent(transform);
        inputManager = inputObject.AddComponent<InputManager>();

        GameObject entityObjct = new GameObject("EntityManager");
        entityObjct.transform.SetParent(transform);
        this.entityManager = entityObjct.AddComponent<EntityManager>();

        GameObject dataObject = new GameObject("DataManager");
        dataObject.transform.SetParent(transform);
        this.dataManager = dataObject.AddComponent<DataManager>();


    }

    // Update is called once per frame
    void Update()
    {

        this.inputManager.TouchUpdate();

        this.inputManager.UpdateGameInput();

        this.entityManager.UpdateEntities();

    }
}
