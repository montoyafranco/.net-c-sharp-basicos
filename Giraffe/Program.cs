

namespace Giraffe
{ class Program
    {   
        static void Main(string[] args) {


            //Console.Write("Enter your Name pls adventurer: ");
            //string name =  Console.ReadLine();
            //Console.WriteLine("Hello" + name + ".welcome to your new adventure");
            //Console.Write("Entender your age");
            //string edad = Console.ReadLine();            
            //Console.WriteLine(name +" Your age is : " + edad + edad + " So be careful ");


            //Console.Write("Ener a number pls: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Numero de recien elegido es : " + num1);
            //Console.ReadLine();

            //int[] luckyNumbers = { 4, 5, 6, 5, 6, 4, 2, 3, 1 };
            //luckyNumbers[1] = 200;
            //Console.WriteLine(luckyNumbers[1]);
            //Console.ReadLine();

            //Console.Write("Clase a elegir para su avatar: ");
            //string clase__guerrero = Console.ReadLine();
            //Console.WriteLine("Clase elegida: " + clase__guerrero );

            //Console.Write("Que arma tendra: ");
            //string clase__arma = Console.ReadLine();
            //Console.WriteLine("Arma elegida: " + clase__arma);

            //Console.WriteLine("Aventurero eres un " + clase__guerrero + " .Sabia eleccion , junto con tu arma elegida  " + clase__arma + "tienes muchas probabilidades de completar tu travesia" );

            //Si quiero crear un array vacio tengo que decir si o si cuanto va a tener de espacio

            string[] friends = new string[5];
            friends[0] = "Jim";
            Console.WriteLine(friends[0]);

            Console.WriteLine("Aca invoco un numero y le pasa un parametro: " + Doble(5));

        }

        static int Doble(int num)
        {
            int resultado = num * 2;
            return resultado;

        }

    }

}