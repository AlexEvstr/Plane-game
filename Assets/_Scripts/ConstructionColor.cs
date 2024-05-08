using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstructionColor : MonoBehaviour
{
    [SerializeField] private SpriteRenderer[] _mainSprites;
    [SerializeField] private Sprite[] _sprites;

    public string indexArrayKey = "SavedIndexArray"; // Ключ для сохранения массива индексов в PlayerPrefs
    private int[] indexArray; // Массив индексов
    private int index;

    private void Start()
    {
        
        if (PlayerPrefs.GetString("SameColor", "no") == "yes")
        {
            Debug.Log("yes");
            LoadIndexes();
            //Debug.Log(indexArray[0]);
            //Debug.Log(indexArray[1]);
            //Debug.Log(indexArray[2]);
            //Debug.Log(indexArray[3]);
            for (int i = 0; i < _mainSprites.Length; i++)
            {
                _mainSprites[i].sprite = _sprites[indexArray[i]];
                //Debug.Log(indexArray[i]);
            }
        }
        else
        {
            Debug.Log("no");
            indexArray = new int[_mainSprites.Length];
            for (int i = 0; i < _mainSprites.Length; i++)
            {
                
                index = Random.Range(0, _sprites.Length);
                indexArray[i] = index;
                Debug.Log(indexArray[i]);
                _mainSprites[i].sprite = _sprites[index];
                
            }
            //Debug.Log(indexArray[0]);
            //Debug.Log(indexArray[1]);
            //Debug.Log(indexArray[2]);
            //Debug.Log(indexArray[3]);
        }

        SaveIndexes();


    }

    void SaveIndexes()
    {
        // Сохраняем длину массива
        PlayerPrefs.SetInt(indexArrayKey + "_Length", indexArray.Length);

        // Сохраняем каждый индекс в PlayerPrefs
        for (int i = 0; i < indexArray.Length; i++)
        {
            PlayerPrefs.SetInt(indexArrayKey + "_" + i, indexArray[i]);
        }
        PlayerPrefs.Save();
    }

    void LoadIndexes()
    {
        // Получаем длину массива
        int arrayLength = PlayerPrefs.GetInt(indexArrayKey + "_Length", 0);

        // Создаем новый массив индексов с полученной длиной
        indexArray = new int[arrayLength];

        // Загружаем каждый индекс из PlayerPrefs
        for (int i = 0; i < arrayLength; i++)
        {
            indexArray[i] = PlayerPrefs.GetInt(indexArrayKey + "_" + i, 0);
        }
    }
}
