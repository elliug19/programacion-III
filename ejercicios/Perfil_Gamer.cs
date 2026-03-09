using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Perfil de Usuario Gamer: Crea un programa que pida al usuario su Nick , 
 * nivel de experiencia (1-100) y si tiene suscripción Premium (booleano). 
 * Al final, muestra un mensaje personalizado que le dé la bienvenida a su nivel correspondiente.
 */

namespace Ejercicios_basicos.Ejercicios_basicos
{
    internal class Perfil_Gamer
    {

        static void Main(string[] args)
        {
            Console.Write("Ingrese su Nickname: ");
            string nickname = "kall";
            Console.Write("Ingrese su nivel de experiencia (1 - 100): ");
            int xp = 20;
            Console.Write("Si tienes premium ingresa (1), de lo contrario ingrese (2): ");
            int UserPremium = 2;

            if (UserPremium == 1)
                Console.WriteLine($"\n¡Bienvenido, {nickname}! Tu nivel de experiencia es {xp} y tu suscripción premium está activa.");
            else
                Console.WriteLine($"\n¡Bienvenido, {nickname}! Tu nivel de experiencia es {xp} y tu suscripción premium no está activa.");

        }
    }
}
