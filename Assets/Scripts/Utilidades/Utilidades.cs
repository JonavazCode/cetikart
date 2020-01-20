using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace cetikart.utilidades
{
    /// <summary>
    /// Clase estática con funcionalidades que pueden ser utilizadas en diferentes lugares del proyecto
    /// </summary>
    public static class Utilidades
    {
        /// <summary>
        /// Función que encontrará la posicion actual del jugador según el nombre envíado
        /// </summary>
        /// <param name="cppj">Instancia de un script que tiene las posiciones en ese momento</param>
        /// <param name="nombre_jugador"> Nombre del profesor a comparar con las posiciones</param>
        /// <returns></returns>
        public static int posicion_carrera_por_nombre(this CheckpointsPerPJ cppj, string nombre_jugador)
        {
            if (cppj.uno == nombre_jugador)
            {
                return 1;
            }
            else if (cppj.dos == nombre_jugador)
            {
                return 2;
            }
            else if (cppj.tres == nombre_jugador)
            {
                return 3;
            }
            else if (cppj.cuatro == nombre_jugador)
            {
                return 4;
            }
            else if (cppj.cinco == nombre_jugador)
            {
                return 5;
            }
            else if (cppj.seis == nombre_jugador)
            {
                return 6;
            }
            else if (cppj.siete == nombre_jugador)
            {
                return 7;
            }
            else
            {
                return 8;
            }
        }

        /// <summary>
        /// Método que devuelve el nombre del jugador que está adelante de la posicion enviada
        /// </summary>
        /// <param name="cppj">Instancia de un script que tiene las posiciones en ese momento</param>
        /// <param name="posicion">Posicion del jugador atacante </param>
        /// <returns></returns>
        public static string nombre_sig_jugador(this CheckpointsPerPJ cppj, int posicion)
        {
            if (posicion == 8)
            {
                return cppj.siete;
            }
            else if (posicion == 7)
            {
                return cppj.seis;
            }
            else if (posicion == 6)
            {
                return cppj.cinco;
            }
            else if (posicion == 5)
            {
                return cppj.cuatro;
            }
            else if (posicion == 4)
            {
                return cppj.tres;
            }
            else if (posicion == 3)
            {
                return cppj.dos;
            }
            else if (posicion == 2)
            {
                return cppj.uno;
            }
            else
            {
                return "uno";
            }
        }


        public static int checkpoint_actual_jugador(this CheckpointsPerPJ cppj, string nombre_jugador, GameObject[] checkpoints)
        {

            if (nombre_jugador.Contains(nameof(cppj.molina)))
            {
                for (int i = 0; i <= checkpoints.Length - 1; i++)
                {
                    if (cppj.molina.transform == checkpoints[i].transform)
                    {
                        return i;
                    }

                }
            }
            else if (nombre_jugador.Contains(nameof(cppj.coco)))
            {
                for (int i = 0; i <= checkpoints.Length - 1; i++)
                {
                    if (cppj.coco.transform == checkpoints[i].transform)
                    {
                        return i;
                    }
                }
            }
            else if (nombre_jugador.Contains(nameof(cppj.areli)))
            {
                for (int i = 0; i <= checkpoints.Length - 1; i++)
                {
                    if (cppj.areli.transform == checkpoints[i].transform)
                    {
                        return i;
                    }
                }
            }
            else if (nombre_jugador.Contains(nameof(cppj.nino)))
            {
                for (int i = 0; i <= checkpoints.Length - 1; i++)
                {
                    if (cppj.nino.transform == checkpoints[i].transform)
                    {
                        return i;
                    }
                }
            }
            else if (nombre_jugador.Contains(nameof(cppj.agentek)))
            {
                for (int i = 0; i <= checkpoints.Length - 1; i++)
                {
                    if (cppj.agentek.transform == checkpoints[i].transform)
                    {
                        return i;
                    }
                }
            }
            else if (nombre_jugador.Contains(nameof(cppj.sergio)))
            {
                for (int i = 0; i <= checkpoints.Length - 1; i++)
                {
                    if (cppj.sergio.transform == checkpoints[i].transform)
                    {
                        return i;
                    }
                }
            }
            else if (nombre_jugador.Contains(nameof(cppj.gussa)))
            {
                for (int i = 0; i <= checkpoints.Length - 1; i++)
                {
                    if (cppj.gussa.transform == checkpoints[i].transform)
                    {
                        return i;
                    }
                }
            }
            else if (nombre_jugador.Contains(nameof(cppj.ulyses)))
            {
                for (int i = 0; i <= checkpoints.Length - 1; i++)
                {
                    if (cppj.ulyses.transform == checkpoints[i].transform)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
