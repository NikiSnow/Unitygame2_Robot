using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Car : MonoBehaviour
{
    public Transform objectToMove; // ������ �� ������, ������� ����� ��������
    public float distanceToMove = 1f; // ����������, �� ������� ����� �������� ������
    public float rotationAngle = 180f; // ���� ��������
    public GameManager MainScript;
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.UI.Button button = GetComponent<UnityEngine.UI.Button>(); // ���� ��������� ������������ ����
        button.onClick.AddListener(MoveObjectDown); // ��������� ��������� ������� ������� �� ������
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
                Debug.Log("��� ���");
            }
            else
            {
                objectToMove.rotation = Quaternion.Euler(0, 0, rotationAngle);
                MainScript.CurAngle = rotationAngle;
            }
            // �������� ������ ���� �� ������������ ����������
            objectToMove.Translate(Vector3.up * distanceToMove);
        }

    }

}
