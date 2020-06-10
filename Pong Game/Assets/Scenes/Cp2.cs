using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cp2 : MonoBehaviour
{
    public int a, b;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Sum(a, b));
        Debug.Log(Prod(a, b));
        Debug.Log(Div(a, b));
    }

    private int Sum(int x, int y)
    {
        return x + y;
    }

    private int Prod(int x, int y)
    {
        return x * y;
    }


    private int Div(int c, int d)
    {
        if (b == 0)
        {
            Debug.Log("You can't devide by 0");
            return 0;
        }
        else
        {
            return c / d;
        }
    }
}
