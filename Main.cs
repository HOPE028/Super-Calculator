using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Main : MonoBehaviour
{
    public TextMeshPro Text;
    Vector2 clickPos;

    private double[] nums = { 0, 0 };
    private int i = 0;
    private int operation = -3;
    private bool answerOperation = false;
    private bool negativeTwice = false;
    private bool negativeNum = false;
    private bool decimalHit = false;
    private double decimalCounter = 0;

    private bool jokeOver = false;

    void Start()
    {
        Text = FindObjectOfType<TextMeshPro>();
    }


    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Alpha1)) {
            printNum(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2)) {
            printNum(2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3)) {
            printNum(3);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4)) {
            printNum(4);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5)) {
            printNum(5);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6)) {
            printNum(6);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7)) {
            printNum(7);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8)) {
            printNum(8);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9)) {
            printNum(9);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha0)) {
            printNum(0);
        }
        //.
        else if (Input.GetKeyDown(KeyCode.Period))
        {
            Debug.Log(".");
            if (decimalHit == false)
            {
                decimalHit = true;
                Text.text += ".";
            }
        }
        //=
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("=");
            equal(operation);
        }
        //C
        else if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Debug.Log("C");
            erase();
        }


        int lengthOfString = Text.text.Length;
        if (lengthOfString > 40) {
            Text.text = "You suck";
            jokeOver = true;
        }
        if (nums[0] == 80085) {
            Text.text = "BOOBS";
            jokeOver = true;
        }



        if (Input.GetMouseButtonDown(0)) {
            clickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log(clickPos);

            if (jokeOver) {
                erase();
                jokeOver = false;
            }
            
            //+/-
            if (clickPos.x > -3.1 && clickPos.x < -1.7 && clickPos.y > -4.7 && clickPos.y < -3.7)
            {
                Debug.Log("+/-");

                if (nums[i] == 0 && negativeTwice == false)
                {
                    Text.text += "-";
                    negativeNum = true;
                    negativeTwice = true;
                }
            }
            //.
            else if (clickPos.x > 0.2 && clickPos.y > -4.7 && clickPos.x < 1.6 && clickPos.y < -3.7)
            {
                Debug.Log(".");
                if (decimalHit == false) { 
                    decimalHit = true;
                    Text.text += ".";
                }
            }

            //numbers

            //1
            else if (clickPos.x > -3.1 && clickPos.x < -1.7 && clickPos.y > -3.5 && clickPos.y < -2.5)
            {
                Debug.Log("1");
                printNum(1);
            }
            //2
            else if (clickPos.x > -1.4 && clickPos.x < 0 && clickPos.y > -3.5 && clickPos.y < -2.5)
            {
                Debug.Log("2");
                printNum(2);
            }
            //3
            else if (clickPos.x > 0.2 && clickPos.x < 1.6 && clickPos.y > -3.5 && clickPos.y < -2.5)
            {
                Debug.Log("3");
                printNum(3);
            }
            //4
            else if (clickPos.x > -3.1 && clickPos.x < -1.7 && clickPos.y > -2.3 && clickPos.y < -1.3)
            {
                Debug.Log("4");
                printNum(4);
            }
            //5
            else if (clickPos.x > -1.4 && clickPos.x < 0 && clickPos.y > -2.3 && clickPos.y < -1.3)
            {
                Debug.Log("5");
                printNum(5);
            }
            //6
            else if (clickPos.x > 0.2 && clickPos.x < 1.6 && clickPos.y > -2.3 && clickPos.y < -1.3)
            {
                Debug.Log("6");
                printNum(6);
            }
            //7
            else if (clickPos.x > -3.1 && clickPos.x < -1.7 && clickPos.y > -1.1 && clickPos.y < -0.1)
            {
                Debug.Log("7");
                printNum(7);
            }
            //8
            else if (clickPos.x > -1.4 && clickPos.x < 0 && clickPos.y > -1.1 && clickPos.y < -0.1)
            {
                Debug.Log("8");
                printNum(8);
            }
            //9
            else if (clickPos.x > 0.2 && clickPos.x < 1.6 && clickPos.y > -1.1 && clickPos.y < -0.1)
            {
                Debug.Log("9");
                printNum(9);
            }
            //0
            else if (clickPos.x > -1.4 && clickPos.x < 0 && clickPos.y > -4.7 && clickPos.y < -3.7)
            {
                Debug.Log("0");
                printNum(0);
            }

            //operations

            //+
            else if (clickPos.x > 1.8 && clickPos.x < 3.2 && clickPos.y > -3.5 && clickPos.y < -2.5)
            {
                Debug.Log("+");
                operationMethod(1);
            }
            //X
            else if (clickPos.x > 1.8 && clickPos.x < 3.2 && clickPos.y > -2.3 && clickPos.y < -1.3)
            {
                Debug.Log("x");
                operationMethod(3);
            }
            //-
            else if (clickPos.x > 1.8 && clickPos.x < 3.2 && clickPos.y > -1.1 && clickPos.y < -0.1)
            {
                Debug.Log("-");
                operationMethod(2);
            }
            //\
            else if (clickPos.x > 1.8 && clickPos.x < 3.2 && clickPos.y > 0.2 && clickPos.y < 1.1)
            {
                Debug.Log("/");
                operationMethod(4);
            }
            //^
            else if (clickPos.x > 0.2 && clickPos.x < 1.6 && clickPos.y > 0.2 && clickPos.y < 1.1)
            {
                Debug.Log("^");
                operationMethod(5);
            }
            //Square Root
            else if (clickPos.x > -1.4 && clickPos.x < 0 && clickPos.y > 0.2 && clickPos.y < 1.1)
            {
                Debug.Log("Square root");
                operationMethod(6);
            }

            //Equal
            else if (clickPos.x > 1.8 && clickPos.x < 3.2 && clickPos.y > -4.7 && clickPos.y < -3.7)
            {
                Debug.Log("=");
                equal(operation);
            }

            //C
            else if (clickPos.x > -3.1 && clickPos.x < -1.7 && clickPos.y > 0.2 && clickPos.y < 1.1)
            {
                Debug.Log("C");
                erase();
            }

        }
    }

    public void printNum(int n) {
        
        if (answerOperation)
        {
            erase();
        }
        else if (decimalHit)
        {
            decimalCounter++;
            double decimalAdded = n;
            for (int a = 0; a < decimalCounter; a++)
            {
                decimalAdded = decimalAdded / 10;
            }
            nums[i] += decimalAdded;
            Text.text += n.ToString();
        }
        else
        {
            nums[i] *= 10;
            nums[i] += n;

            Text.text += n.ToString();
        }
    }
    public void printChar(int op) {
        if (negativeNum) {
            nums[i] *= -1;
            negativeNum = false;
            negativeTwice = false;
        }

        i++;
        answerOperation = false;

        if (op == 1)
        {
            Text.text += " + ";
        }
        else if (op == 2)
        {
            Text.text += " - ";
        }
        else if (op == 3)
        {
            Text.text += " X ";
        }
        else if (op == 4)
        {
            Text.text += " / ";
        }
        else if (op == 5)
        {
            Text.text += " ^ ";
        }
        else if (op == 6) {
            i++;
            equal(6);
            //Text.text += " SquareRoot ";
        }

        decimalHit = false;
        decimalCounter = 0;
    }
    
    //public void addNum(int n, bool opAct) {
        
    //}
    public void equal(int op) {

        if (negativeNum)
        {
            nums[i] *= -1;
            negativeNum = false;
            negativeTwice = false;
        }

        if (op == 1)
        {
            nums[0] = nums[0] + nums[1];
            nums[1] = 0;
        }
        else if (op == 2)
        {
            nums[0] = nums[0] - nums[1];
            nums[1] = 0;
        }
        else if (op == 3)
        {
            nums[0] = nums[0] * nums[1];
            nums[1] = 0;
        }
        else if (op == 4)
        {
            nums[0] = nums[0] / nums[1];
            nums[1] = 0;
        }
        else if (op == 5)
        {
            if (nums[1] != 0)
            {
                double total = nums[0];
                for (int a = 0; a < nums[1] - 1; a++)
                {
                    total *= nums[0];
                }
                nums[0] = total;
                nums[1] = 0;
            }
            else
            {
                nums[0] = 1;
                nums[1] = 0;
            }
        }
        else if (op == 6) {
            bool found = false;
            double a = 0;
            double div = 1;
            while (found == false && div < 100000000) {
                a += 1 / div;
                if (a * a == nums[0])
                {
                    nums[0] = a;
                    nums[1] = 0;
                }
                else if (a * a > nums[0]) {
                    a -= 1 / div;
                    div *= 10;
                }
            }
            if (div >= 100000000) {
                nums[0] = a;
                nums[1] = 0;
            }
            operation = -3;
        }
        i = 0;
        Text.text = nums[0].ToString();
        answerOperation = true;
    }
    public void erase() {
        nums[0] = 0;
        nums[1] = 0;
        i = 0;
        operation = -3;
        answerOperation = false;
        negativeTwice = false;
        negativeNum = false;
        decimalCounter = 0;
        decimalHit = false;
        Text.text = "";
    }
    public void operationMethod(int op) {
        if (i == 1)
        {
            equal(operation);
            operation = op;
            printChar(operation);
        }
        else
        {
            operation = op;
            printChar(operation);
        }
    }
}
