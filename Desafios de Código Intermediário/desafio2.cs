using System;  

//entrada
//A entrada contém apenas um valor de ponto flutuante, que pode ser maior ou igual a zero, com duas casas decimais.
//saida
//Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste e o percentual de reajuste ganho, conforme exemplo abaixo.

class minhaClasse { 

  static void Main(string[] args) {  

    double salario = 0.00; 
    double reajuste = 0.00; 
    double novoSalario = 0.00; 
    double percentual = 0.00; 
  
    salario = Convert.ToDouble(Console.ReadLine()); 

//TODO: Complete os espaços em branco com uma possível solução para o problema:
   
    if(salario < 0) { 
      return ;
    } else if (salario <= 400) { 
       percentual = 0.15; 
      reajuste =  salario*percentual; 
      novoSalario =  salario+reajuste ; 


    } else if (salario <= 800 ) { 
      percentual =  0.12 ; 
      reajuste =  salario*percentual; 
      novoSalario =  salario+reajuste ; 

    } else if (salario <= 1200 ) { 
      percentual = 0.10; 
      reajuste =  salario*percentual; 
      novoSalario =  salario+reajuste ; 

    } else if (salario <= 2000) { 
      percentual = 0.07 ; 
      reajuste =  salario*percentual; 
      novoSalario =  salario+reajuste ; 

    } else { 
      percentual = 0.04; 
      reajuste =  salario*percentual; 
      novoSalario =  salario+reajuste ; 

    } 

    Console.WriteLine("Novo salario: {0:0.00}",        novoSalario      ); 
    Console.WriteLine("Reajuste ganho: {0:0.00}",    reajuste         ); 
    Console.WriteLine("Em percentual: {0} %", percentual * 100); 

  } 
}