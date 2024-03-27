using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Car : MonoBehaviour
{
    public Transform objectToMove; // ссылка на объект, который нужно сдвинуть
    public float distanceToMove = 1f; // расстояние, на которое нужно сдвинуть объект
    public float rotationAngle = 180f; // угол поворота
    public GameManager MainScript;
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.UI.Button button = GetComponent<UnityEngine.UI.Button>(); // явно указываем пространство имен
        button.onClick.AddListener(MoveObjectDown); // добавляем слушатель события нажатия на кнопку
    }

    void MoveObjectDown()
    {
        MainScript.CounterL=MainScript.CounterL+1;
        if (MainScript.CounterL == 5)
        {
            Debug.Log("BABAH");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        {
            MainScript.col = MainScript.col + 1;
            MainScript.score = MainScript.score + MainScript.array[MainScript.col, MainScript.row];
            if (MainScript.CurAngle == rotationAngle)
            {
                Debug.Log("все гуд");
            }
            else
            {
                objectToMove.rotation = Quaternion.Euler(0, 0, rotationAngle);
                MainScript.CurAngle = rotationAngle;
            }
            // Сдвигаем объект вниз на определенное расстояние
            objectToMove.Translate(Vector3.up * distanceToMove);
        }

    }

}
