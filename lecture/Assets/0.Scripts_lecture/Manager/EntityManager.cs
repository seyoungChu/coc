using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityManager : SingletonMonobehaviour<EntityManager>
{

    public List<Entity> entities = new List<Entity>();

    // Update is called once per frame
    public void UpdateEntities()
    {
        if (entities.Count == 0)
        {
            return;
        }
        for (int i = 0; i < entities.Count; ++i)
        {
            this.entities[i].UpdateEntity();
        }
    }
    //temp!
    private void Start()
    {
        Building[] buildings = FindObjectsOfType<Building>();
        if (buildings == null || buildings.Length == 0)
        {
            return;
        }

        for (int i = 0; i < buildings.Length; i++)
        {
            if (entities.Contains(buildings[i]) == false)
            {
                buildings[i].CashingObject();
                entities.Add(buildings[i]);
            }
        }

    }
}
