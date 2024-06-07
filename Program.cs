using System;


// Exercise making a calculator that can add, subtract, multiply, and divide

public class Program{
    public static void Main(String[] args){
        String exitKey= null;
        Console.WriteLine("Calculator : Two Number Version \n add First Number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("add Second Number:");
        int secondNumber = int.Parse(Console.ReadLine());
        
        while (exitKey != "e" || exitKey != "E"){
        Console.WriteLine("Add the Operation need to Perform \n 1: ADD \n 2: Substraction \n 3: Multiply \n 4: Division \n For exit press e or E " );
        int operation = int.Parse(Console.ReadLine());
        if(operation == 1){
            Console.WriteLine("The Result is " + (firstNumber + secondNumber));
        }else if(operation == 2){
            Console.WriteLine("The Result is "+( firstNumber-secondNumber));
        }else if(operation == 3){
            Console.WriteLine("The Result is "+( firstNumber*secondNumber));
        }else if(operation == 4){
            Console.WriteLine("The Result is "+( firstNumber/secondNumber));
        }}
        
    }
}