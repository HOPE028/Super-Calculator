using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter: MonoBehaviour
{
    public void goHome() {
        SceneManager.LoadScene(1);
    }

    public void goNormal() {
        SceneManager.LoadScene(0);
    }

    public void goArea() {
        SceneManager.LoadScene(2);
    }

    public void goCircleArea() {
        SceneManager.LoadScene(3);
    }

    public void goConeArea() {
        SceneManager.LoadScene(4);
    }
    public void goCylinderArea() {
        SceneManager.LoadScene(5);
    }
    public void goRectangularPyramid() {
        SceneManager.LoadScene(6);
    }
    public void goSphere() {
        SceneManager.LoadScene(7);
    }
    public void goTrianglePrism() {
        SceneManager.LoadScene(8);
    }
    public void goTriangularPyramid() {
        SceneManager.LoadScene(9);
    }



    public void goSurfaceArea() {
        SceneManager.LoadScene(10);
    }
    public void goAttachedCubeSA() {
        SceneManager.LoadScene(11);
    }
    public void goConeSA() {
        SceneManager.LoadScene(12);
    }
    public void goCylinderSA() {
        SceneManager.LoadScene(13);
    }
    public void goRectangularPyramidSA() {
        SceneManager.LoadScene(14);
    }
    public void goSphereSA() {
        SceneManager.LoadScene(15);
    }
    public void goTriangularPrismDegree() {
        SceneManager.LoadScene(16);
    }
    public void goTriangularPrismSA() {
        SceneManager.LoadScene(17);
    }
    public void goTriangularPyramidSA() {
        SceneManager.LoadScene(18);
    }

    public void goTheorem() {
        SceneManager.LoadScene(19);
    }
    public void goFindC() {
        SceneManager.LoadScene(20);
    }
    public void goFindA() {
        SceneManager.LoadScene(21);
    }



    public void quitGame() {
        Debug.Log("QUIT");
        Application.Quit();
    }
}





//0 normal calculator
//1 Home
//2 Area
    //3 Circle