using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;


public class Boton : MonoBehaviour
{
    public void ejecutarsimulacion()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void salirejecucion()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

}
