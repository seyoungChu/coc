using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : SingletonMonobehaviour<DataManager>
{

    public EntityTable entityTable;
    public Dictionary<int, EntityData> entityData = new Dictionary<int, EntityData>();
    private void Start()
    {

        entityTable = (EntityTable)Resources.Load("Data/EntityTable");
        int i = 0;
        foreach (EntityTable.Sheet s in entityTable.sheets)
        {
            foreach (EntityTable.Param p in s.list)
            {
                Debug.LogWarning(i + " /  " + p.ID + " / " + p.EntityCategory.ToString() + " / " + p.EntityType.ToString() + "/" + p.Prefab);
                entityData.Add(p.ID, new EntityData(p.ID, p.EntityCategory, p.EntityType, p.HP, p.Level, p.AttackPower, p.SearchRange, p.Prefab));
                i++;
            }
        }

    }

    public EntityData GetEntityData(int ID)
    {
        if (this.entityData.ContainsKey(ID))
        {
            return this.entityData[ID];
        }
        else
        {
            return null;
        }
    }

    public EntityData GetEntityData(EntityCategory category)
    {
        foreach (KeyValuePair<int, EntityData> kv in entityData)
        {
            if (kv.Value.entCategory == category)
            {
                return kv.Value;
            }
        }
        return null;
    }

}
