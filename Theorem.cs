using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Theorem : MonoBehaviour
{
    public TextMeshPro Text;
    public TextMeshPro Text2;
    public int areaCode;

    private int i = 0;
    private double[] nums = { 0, 0, 0 };
    private bool decimalHit = false;
    private double decimalCounter = 0;
    private int infoReceived = 0;
    private bool answerGiven = false;
    private double answer = 0;

    void Update()
    {

        int TextLength = Text.text.Length;
        if (TextLength > 10)
        {
            answerGiven = true;
        }


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            printNum(1);

        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            printNum(2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            printNum(3);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            printNum(4);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            printNum(5);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            printNum(6);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            printNum(7);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            printNum(8);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            printNum(9);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha0))
        {
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


        
        if (areaCode == 1)
        {

            if (infoReceived == 0 && answerGiven == false)
            {
                Text2.text = "A =";
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                infoReceived++;
                i++;
                decimalHit = false;
                decimalCounter = 0;

                if (infoReceived == 1)
                {
                    Text2.text = "B =";
                    Text.text = "";
                }

            }

            if (infoReceived == 2)
            {
                nums[0] *= nums[0];
                nums[1] *= nums[1];
                answer = nums[0] + nums[1];

                bool found = false;
                double a = 0;
                double div = 1;
                while (found == false && div < 100000000)
                {
                    a += 1 / div;
                    if (a * a == answer)
                    {
                        nums[0] = a;
                    }
                    else if (a * a > answer)
                    {
                        a -= 1 / div;
                        div *= 10;
                    }
                }
                if (div >= 100000000)
                {
                    answer = a;
                }

                Text2.text = "C =";
                Text.text = answer.ToString();
                answerGiven = true;
                infoReceived = 0;
            }
        }
        else if (areaCode == 2)
        {

            if (infoReceived == 0 && answerGiven == false)
            {
                Text2.text = "C =";
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                infoReceived++;
                i++;
                decimalHit = false;
                decimalCounter = 0;

                if (infoReceived == 1)
                {
                    Text2.text = "B =";
                    Text.text = "";
                }

            }

            if (infoReceived == 2)
            {
                nums[0] *= nums[0];
                nums[1] *= nums[1];
                answer = nums[0] - nums[1];

                bool found = false;
                double a = 0;
                double div = 1;
                while (found == false && div < 100000000)
                {
                    a += 1 / div;
                    if (a * a == answer)
                    {
                        nums[0] = a;
                    }
                    else if (a * a > answer)
                    {
                        a -= 1 / div;
                        div *= 10;
                    }
                }
                if (div >= 100000000)
                {
                    answer = a;
                }

                Text2.text = "A =";
                Text.text = answer.ToString();
                answerGiven = true;
                infoReceived = 0;
            }
        }
    }

    public void printNum(int n)
    {
        if (answerGiven)
        {
            i = 0;
            nums[0] = 0;
            nums[1] = 0;
            nums[2] = 0;
            decimalHit = false;
            decimalCounter = 0;
            infoReceived = 0;
            answerGiven = false;
            answer = 0;
            Text.text = "";

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
}
