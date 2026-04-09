using StacksAndQueues.Backend;

var queue = new Queue<string>();
var option = string.Empty;

do
{
    option = Menu();
    switch (option)
    {
        case "1":
            try
            {
                Console.WriteLine("Digite el elemento a encolar");
                var element = Console.ReadLine() ?? string.Empty;
                queue.Enqueue(element);
                Console.WriteLine($"Elemento {element} encolado");
                

            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;

        case "2":
            try
            {
                var dequeueElement = queue.Dequeue();
                Console.WriteLine($"Elemento: {dequeueElement} desencolado");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;
        case "0":
            Console.WriteLine("Saliendo del programa");
            break;
        default:
            Console.WriteLine("Opcion no valida");
            break;
    }

}
while (option != "0");

string Menu()
{
    Console.WriteLine("1. Encolar");
    Console.WriteLine("2. Desencolar");
    Console.WriteLine("0. Salir");
    Console.WriteLine("Elija una opcion");
    return Console.ReadLine() ?? string.Empty;

}


//===================================================================================================
//Stacks
//===================================================================================================
// coment ctrl k c and descoment  ctrl k u

//using StacksAndQueues.Backend;
//var stack = new Stack<string>();
//var option = string.Empty;

//do
//{
//    option = Menu();
//    switch (option)
//    {
//        case "1":
//            Console.WriteLine("Digite el elemento a apilar");
//            var element = Console.ReadLine() ?? string.Empty;
//            stack.Push(element);
//            Console.WriteLine($"Elemento {element} apilado");
//            break;
//        case "2":
//            try
//            {
//                var poppedElement = stack.Pop();
//                Console.WriteLine($"Elemento: {poppedElement} desapilado");
//            }
//            catch (InvalidOperationException ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            break;
//        case "3":
//            try
//            {
//                var topElement = stack.Peek();
//                Console.WriteLine($"Elemeto: {topElement} en el tope");
//            }
//            catch (InvalidOperationException ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            break;
//        case "0":
//            Console.WriteLine("Saliendo del programa");
//            break;
//        default:
//            Console.WriteLine("Opcion no valida");
//            break;
//    }

//}
//while (option != "0");

//string Menu()
//{
//    Console.WriteLine("1. Apilar");
//    Console.WriteLine("2. Desapilar");
//    Console.WriteLine("3. Ver Tope");
//    Console.WriteLine("0. Salir");
//    Console.WriteLine("Elija una opcion");
//    return Console.ReadLine() ?? string.Empty;

//}

