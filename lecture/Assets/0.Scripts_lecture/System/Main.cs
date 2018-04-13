using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : SingletonMonobehaviour<Main>
{
    GridManager gridManager;
    InputManager inputManager;
    EntityManager entityManager;
    DataManager dataManager;
    TimeManager timeManager;

	// Use this for initialization
	void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 30;
        Application.runInBackground = true;


        //GameObject gridObject = new GameObject("GridManager");
        //gridObject.transform.SetParent(transform);
        //gridManager = gridObject.AddComponent<GridManager>();
        this.gridManager = (GridManager)AddManager<GridManager>();
        this.gridManager.Init();

        //GameObject inputObject = new GameObject("InputManager");
        //inputObject.transform.SetParent(transform);
        //inputManager = inputObject.AddComponent<InputManager>();
        this.inputManager = (InputManager)AddManager<InputManager>();

        //GameObject entityObjct = new GameObject("EntityManager");
        //entityObjct.transform.SetParent(transform);
        //this.entityManager = entityObjct.AddComponent<EntityManager>();
        this.entityManager = (EntityManager)AddManager<EntityManager>();


        //GameObject dataObject = new GameObject("DataManager");
        //dataObject.transform.SetParent(transform);
        //this.dataManager = dataObject.AddComponent<DataManager>();
        this.dataManager = (DataManager)AddManager<DataManager>();

        this.timeManager = (TimeManager)AddManager<TimeManager>();


    }

    UnityEngine.Component AddManager<T>()
    {
        GameObject newObject = new GameObject(typeof(T).ToString());
        newObject.transform.SetParent(transform);
        return newObject.AddComponent(typeof(T));
    }

    // Update is called once per frame
    void Update()
    {
        this.timeManager.UpdateTime();

        this.inputManager.TouchUpdate();

        this.inputManager.UpdateGameInput();

        this.entityManager.UpdateEntities();


    }
}
