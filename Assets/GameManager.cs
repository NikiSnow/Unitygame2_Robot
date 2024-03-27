using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float CurAngle = 180; //текущий угол
    public TMP_Text text;
    public TMP_Text textscore;
    public int col = 0;
    public int row = 0;
    public int score = 0;
    public int CounterR = 0;
    public int CounterL = 0;
    public int[,] array; // Объявление массива как члена класса
    // Start is called before the first frame update
    void Start()
    {
        col = 0; row=0;
        {
            array = GenerateArray(5, 5); // mas
            score = score + array[col, row];
            DisplayArray(array);
        }
        int[,] GenerateArray(int rows, int cols)
        {
            int[,] newArray = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // Генерация случайных чисел или заполнение значениями из другого источника
                    newArray[i, j] = Random.Range(1, 101); // Случайные числа от 1 до 100
                }
            }
            return newArray;
        }
    }
    void DisplayArray(int[,] array)
    {
        string output = "";
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int num = array[i, j];
                if (num > 0 && num < 10)
                {
                    output += array[i, j] + "      ";
                }
                else if (10 <= num && num < 100)
                {
                    output += array[i, j] + "    ";
                }
                else if (100 <= num && num < 1000)
                {
                    output += array[i, j] + "  ";
                }
            }
            output += "\n";
        }
        text.text = output; // Присвоение отформатированной строки текстовому полю
    }

    private void Update()
    {
        textscore.text = "Сurrent score: "+ score;
        if (CounterL + CounterR ==8)
        {
            Debug.Log("game is done");
            Debug.Log("Your score is "+score);
            Debug.Log("Max score is ");
            Debug.Log("Min score is ");
        }
    }
}
