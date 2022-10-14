using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSave : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
   
    }
    public void SaveGame()
    {
        SaveData saveData = new SaveData();
        saveData.positions = new SaveData.Position[1];
        saveData.positions[0] = new SaveData.Position();
        saveData.positions[0].x = transform.position.x;
        saveData.positions[0].y = transform.position.y;
        SaveManager.SaveGameState(saveData);
    }

    public void LoadGame()
    {
        SaveData saveData = SaveManager.LoadGameState();
        if(saveData != null)
        {
            transform.position = new Vector3(saveData.positions[0].x, saveData.positions[0].y);
        }
    }
}
