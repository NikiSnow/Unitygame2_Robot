using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarRight : MonoBehaviour
{
    public Transform objectToMove; // ссылка на объект, который нужно сдвинуть
    public float distanceToMove = 1f; // расстояние, на которое нужно сдвинуть объект
    public float rotationAngle = 90f; // угол поворота
    public GameManager MainScript;
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.UI.Button button = GetComponent<UnityEngine.UI.Button>(); // явно указываем пространство имен
        button.onClick.AddListener(MoveObjectDown); // добавляем слушатель события нажатия на кнопку
    }

    void MoveObjectDown()
    {
        MainScript.CounterR = MainScript.CounterR + 1;

        if (MainScript.CounterR == 5)
        {
            Debug.Log("BABAH");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        {
            MainScript.row = MainScript.row + 1;
            MainScript.score = MainScript.score + MainScript.array[MainScript.col, MainScript.row];
            if (MainScript.CurAngle == rotationAngle)
            {
                Debug.Log("все гуд");
            }
            else
            {
                objectToMove.rotation = Quaternion.Euler(0, 0, -rotationAngle);
                MainScript.CurAngle = rotationAngle;
            }
            // Сдвигаем объект вниз на определенное расстояние
            objectToMove.Translate(Vector3.up * distanceToMove);
        }

    }

}
