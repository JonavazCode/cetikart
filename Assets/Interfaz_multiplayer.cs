
using cetikart.controlescenas;
using UnityEngine.SceneManagement;

public class Interfaz_multiplayer : ControlDeEscenas
{

    //// Update is called once per frame
    //void Update()
    //{
    //    if (CrossPlatformInputManager.GetButton("IniciarSesion"))//Esta condicion hace que cuando se presiona el boton de "Un jugador" se envie al usuario a la seleccion de personaje
    //    {
            
    //        SceneManager.LoadScene("Login_Multijugador");//Esta funcion hace que la escena seleccionada se cargue
    //        Debug.Log("Va al login");

    //    }

    //    if (CrossPlatformInputManager.GetButton("Registro"))//Esta condicion hace que cuando se presiona el boton de "Un jugador" se envie al usuario a la seleccion de personaje
    //    {
            
    //        SceneManager.LoadScene("Registro_Multijugador");

    //    }
    //}

    public void IrALoggin()
    {
        SceneManager.LoadScene("Login_Multijugador");
    }

    public void IrAlRegistro()
    {
        SceneManager.LoadScene("Registro_Multijugador");
    }

    public void IrEscenaAnterior()
    {
        EscenaMenuPrincipal();
    }
}
